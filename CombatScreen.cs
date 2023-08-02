using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahiko
{
  public partial class CombatScreen : Form
  {
    Bushi Player_Warrior = null;
    Shinobi Player_Thief = null;
    Onmyoji Player_Mage = null;
    Sohei Player_Priest = null;
    Enemy Opponent = null;

    bool isCritical = false;

    void Initialize()
    {
      this.Text = string.Format("{0} VS {1} Round: {2}", Player_Warrior.FirstName, "Test", 1);
      SetDmText("mpla mpla mpla mpla");
      
      Console.WriteLine("AAA");
      SetUpForOptions();
    }

    #region Constructors
    //TEST
    public CombatScreen()
    {
      Player_Warrior = new Bushi();
      InitializeComponent();

      Initialize();

    }

    public CombatScreen(Bushi Player)
    {
      Player_Warrior = Player;
      InitializeComponent();
    }

    public CombatScreen(Sohei Player)
    {
      Player_Priest = Player;
      InitializeComponent();
    }

    public CombatScreen(Shinobi Player)
    {
      Player_Thief = Player;
      InitializeComponent();
    }

    public CombatScreen(Onmyoji Player)
    {
      Player_Mage = Player;
      InitializeComponent();
    }
    #endregion

    #region Panel Management

    
    void ShowOptionsPanel()
    {
     
    }

    void SetUpForInitiative()
    {
     
    }

    void SetUpForOptions()
    {
      if(InfoPanel.Visible == false)
      {
        InfoPanel.Visible = true;
      }

      Button Attack = new Button();
      Attack.Parent = InfoPanel;
      Attack.BackColor = Color.Red;
      Attack.ForeColor = Color.White;
      Attack.Text = "Attack with ...";
      Attack.Click += Attack_Click;
    }

    private void Attack_Click(object sender, EventArgs e)
    {
      int result = PlayerAction_RollInitiative();
      if (result == 0)
      {
        lbl_DmText.Text = "ERROR";
      }
      else
      {
        lbl_DmText.Text = result.ToString();
      }
    }

    #endregion

    #region Text

    void SetDmText(string txt)
    {
      lbl_DmText.Text = "";
      lbl_DmText.Text = txt;
    }

    #endregion

    #region CombatManager

    int PlayerAction_RollInitiative()
    {
      if(Player_Warrior != null)
      {
        return RollInitiative(Player_Warrior.EquipedWeapon.Speed);
      }

      if (Player_Thief != null)
      {
        return RollInitiative(Player_Thief.EquipedWeapon.Speed);
      }

      if (Player_Mage != null)
      {
        return RollInitiative(Player_Mage.EquipedWeapon.Speed);
      }
      
      if (Player_Priest != null)
      {
        return RollInitiative(Player_Priest.EquipedWeapon.Speed);
      }

      return -1;
    }

    int PlayerAction_RollAttack()
    {
      if (Player_Warrior != null)
      {
        if(IsAttackSuccess(Player_Warrior.THAC0,Opponent.GetAC()))
        {

        }
      }

      

      return -1;
    }

    int RollInitiative(int speed)
    {
      Random rand = new Random();

      return rand.Next(1, 11) + speed;
    }

    bool IsAttackSuccess(int THAC,int vsAc)
    {
      int rollResult = Roll20();
      if (rollResult == 1)
      {
        return false;
      }
      
      if(rollResult == 20)
      {
        isCritical = true;
        return true;
      }

      if(THAC - rollResult >= vsAc)
      {
        return true;
      }

      return false;
    }

    bool IsAttackSuccess(int THAC, int vsAc, int bonus)
    {
      int rollResult = Roll20(bonus);
      if (rollResult == 1)
      {
        return false;
      }

      if (rollResult == 20)
      {
        isCritical = true;
        return true;
      }

      if (THAC - rollResult >= vsAc)
      {
        return true;
      }

      return false;
    }

    int Roll20()
    {
      Random rand = new Random();
      return rand.Next(1, 21);
    } //Natural 20

    int Roll20(int bonus)
    {
      Random rand = new Random();
      int result = rand.Next(1, 21);

      if(result == 20)
      {
        return result;
      }

      if(result == 1)
      {
        return result;
      }

      return result + bonus;
    } //Roll 20 with bonus

    int RollDmg(int min, int max)
    {
      Random rand = new Random();
      return rand.Next(min, max+1);
    }

    int RollDmg(int min, int max, int bonus)
    {
      Random rand = new Random();
      return rand.Next(min, max + 1) + bonus;
    }

    int RollCritical(int min,int max)
    {
      int result = 0;
      Random rand = new Random();

      result = rand.Next(min, max + 1);

      isCritical = false;
      result *= 2;
      return result;

    }

    int RollCritical(int min, int max,int bonus)
    {
      int result = 0;
      Random rand = new Random();

      result = rand.Next(min, max + 1);

      isCritical = false;
      result *= 2;
      result += bonus;
      return result;

    }

    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
     
    }
  }
}
