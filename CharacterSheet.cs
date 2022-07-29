using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahiko
{
    public partial class CharacterSheet : Form
    {
        public Player _player;
        
        public Bushi _Bushi;
        public Shinobi _Shinobi;
        public Onmyoji _Onmyoji;
        public Sohei _Sohei;

        private int _index = 0;
        
        private DMOptions DM;
        
        public CharacterSheet()
        {
            DM = new DMOptions();
            InitializeComponent();
            EnableStatRoll();
        }

        private void InitialConfig()
        {
            tb_FirstName.Enabled = true;
            tb_LastName.Enabled = false;
            btn_RandomName.Enabled = true;
            btn_RandomName.Visible = true;
        }

        private void CreateRandomPlayer()
        {
        }

        private void SetWeapon(Weapon weapon)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CharacterSheet.ActiveForm.Text = String.Format("{0}'s Sheet",tb_FirstName.Text);

        }

        public void GetPlayer(ref Player player)
        {
            _player = player;
            SetUpWeapon(_player);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (tb_FirstName.Enabled)
                {
                    tb_FirstName.Enabled = false;
                    tb_LastName.Enabled = true;
                    tb_LastName.Focus();
                }
                else
                {
                    btn_RandomName.Enabled = false;
                    btn_RandomName.Visible = false;
                    tb_LastName.Enabled = false;
                    btn_confirm.Enabled = true;
                    btn_confirm.Visible = true;
                }
            }
        }

        public void SetUpWeapon(Player p)
        {
            tb_WeaponName.Text = p.EquipedWeapon.Name;
            tb_WeaponSpeedValue.Text = p.EquipedWeapon.Speed.ToString();
            tb_WeaponTypeValue.Text = p.EquipedWeapon.Type;
            tb_DmgSValue.Text = String.Format("{0}d{1}", p.EquipedWeapon.NumOfDie_Small, p.EquipedWeapon.TypeOfDie_Small);
            tb_DmgLValue.Text = String.Format("{0}d{1}", p.EquipedWeapon.NumOfDie_Large, p.EquipedWeapon.TypeOfDie_Large);
        }

        private void EnableStatRoll()
        {
            btn_RollStats.Enabled = true;
            btn_RollStats.Visible = true;
        }

        private void btn_RollStats_Click(object sender, EventArgs e)
        {
            int[] rollResults = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Dice d6 = new Dice(1,7);
                rollResults[i] = d6.GetResult(1,6);
                Thread.Sleep(new Random().Next(10, 990));
            }
            int total = 0;
            foreach(int rollResult in rollResults)
            {
                total += rollResult;
            }
            lb_RollResult.Text = String.Format("{0} + {1} + {2} = {3}", rollResults[0], rollResults[1], rollResults[2], total);
            lb_RollResult.Visible = true;
            if(_index < 6)
            {
                switch(_index)
                {
                    case 0:
                        lb_StrValue.Visible = true;
                        lb_StrValue.Text = total.ToString();
                        _player.CharacterStats.Initial_Str = total;
                        _player.CharacterStats.Current_Str = _player.CharacterStats.Initial_Str;
                        break;
                    case 1:
                        lb_Dex.Visible = true;
                        lb_DexValue.Visible = true;
                        lb_DexValue.Text = total.ToString();
                        _player.CharacterStats.Initial_Dex = total;
                        _player.CharacterStats.Current_Dex = _player.CharacterStats.Initial_Dex;
                        break;
                    case 2:
                        lb_Con.Visible = true;
                        lb_ConValue.Visible = true;
                        lb_ConValue.Text = total.ToString();
                        _player.CharacterStats.Initial_Con = total;
                        _player.CharacterStats.Current_Con = _player.CharacterStats.Initial_Con;
                        break;
                    case 3:
                        lb_Int.Visible = true;
                        lb_IntValue.Visible = true;
                        lb_IntValue.Text = total.ToString();
                        _player.CharacterStats.Initial_Int = total;
                        _player.CharacterStats.Current_Int = _player.CharacterStats.Initial_Int;
                        break;
                    case 4:
                        lb_Wis.Visible = true;
                        lb_WisValue.Visible = true;
                        lb_WisValue.Text = total.ToString();
                        _player.CharacterStats.Initial_Wis = total;
                        _player.CharacterStats.Current_Wis = _player.CharacterStats.Initial_Wis;
                        break;
                    case 5:
                        lb_Cha.Visible = true;
                        lb_ChaValue.Visible = true;
                        lb_ChaValue.Text = total.ToString();
                        _player.CharacterStats.Initial_Cha = total;
                        _player.CharacterStats.Current_Cha = _player.CharacterStats.Initial_Cha;
                        btn_Restart.Enabled = true;
                        btn_Restart.Visible = true;
                        break;
                }
                _index++;
            }
            
            ChangePosition();
        }

        private void ChangePosition()
        {
            if (_index < 6)
            {
                if (_index > 1)
                {
                    lb_RollResult.Location = new Point(lb_RollResult.Location.X, lb_RollResult.Location.Y + 15);
                }
                btn_RollStats.Location = new Point(btn_RollStats.Location.X, btn_RollStats.Location.Y + 15);
            }
            else
            {
                btn_RollStats.Visible = false;
                btn_RollStats.Enabled = false;
                EnableRacePicker();
            }
        }

        private void EnableRacePicker()
        {
            btn_confirm.Location = new Point(cb_Race.Location.X + 150, cb_Race.Location.Y);
            btn_confirm.BringToFront();
            cb_Race.Enabled = true;
            cb_Race.Visible = true;
            cb_Race.Items.Clear();
            List<string> Races = new List<string>();
            Races.Add("Human");
            Races.Add("Elf");
            Races.Add("Dwarf");
            Races.Add("Gnome");
            Races.Add("Halfling");
            Races.Add("Half-Elf");

            foreach(string s in Races)
            {
                cb_Race.Items.Add(s);
            }
           // cb_Race.SelectedItem = cb_Race.Items[0];
        }

        private void cb_Race_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_RollResult.Visible = false;
            btn_confirm.Visible = true;
            btn_confirm.Enabled = true;
            ChangeStats(cb_Race.SelectedIndex);
        }
        private void ChangeStats(int race)
        {
            switch(race)
            {
               default://HUMAN & HALF-ELF
                    lb_ChaValue.Text = _player.CharacterStats.Initial_Cha.ToString();
                    lb_ConValue.Text = _player.CharacterStats.Initial_Con.ToString();
                    lb_DexValue.Text = _player.CharacterStats.Initial_Dex.ToString();
                    lb_IntValue.Text = _player.CharacterStats.Initial_Int.ToString();
                    lb_StrValue.Text = _player.CharacterStats.Initial_Str.ToString();
                    lb_WisValue.Text = _player.CharacterStats.Initial_Wis.ToString();
                    break;
                case 1://ELF +1 dex -1 con
                    lb_ChaValue.Text = _player.CharacterStats.Initial_Cha.ToString();
                    lb_ConValue.Text = (_player.CharacterStats.Initial_Con - 1).ToString();
                    lb_DexValue.Text = (_player.CharacterStats.Initial_Dex + 1).ToString();
                    lb_IntValue.Text = _player.CharacterStats.Initial_Int.ToString();
                    lb_StrValue.Text = _player.CharacterStats.Initial_Str.ToString();
                    lb_WisValue.Text = _player.CharacterStats.Initial_Wis.ToString();
                    break;
                case 2://DWARF +1 con -1 cha
                    lb_ChaValue.Text = (_player.CharacterStats.Initial_Cha - 1).ToString();
                    lb_ConValue.Text = (_player.CharacterStats.Initial_Con + 1).ToString();
                    lb_DexValue.Text = _player.CharacterStats.Initial_Dex.ToString();
                    lb_IntValue.Text = _player.CharacterStats.Initial_Int.ToString();
                    lb_StrValue.Text = _player.CharacterStats.Initial_Str.ToString();
                    lb_WisValue.Text = _player.CharacterStats.Initial_Wis.ToString();
                    break;
                case 3://GNOME +1 int -1 wis
                    lb_ChaValue.Text = _player.CharacterStats.Initial_Cha.ToString();
                    lb_ConValue.Text = _player.CharacterStats.Initial_Con.ToString();
                    lb_DexValue.Text = _player.CharacterStats.Initial_Dex.ToString();
                    lb_IntValue.Text = (_player.CharacterStats.Initial_Int + 1).ToString();
                    lb_StrValue.Text = _player.CharacterStats.Initial_Str.ToString();
                    lb_WisValue.Text = (_player.CharacterStats.Initial_Wis - 1).ToString();
                    break;
                case 4://HALFLING +1 dex -1 str
                    lb_ChaValue.Text = _player.CharacterStats.Initial_Cha.ToString();
                    lb_ConValue.Text = _player.CharacterStats.Initial_Con.ToString();
                    lb_DexValue.Text = (_player.CharacterStats.Initial_Dex + 1).ToString();
                    lb_IntValue.Text = _player.CharacterStats.Initial_Int.ToString();
                    lb_StrValue.Text = (_player.CharacterStats.Initial_Str - 1).ToString();
                    lb_WisValue.Text = _player.CharacterStats.Initial_Wis.ToString();
                    break;
               
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            switch(_index)
            {
                case 6: // Race
                    btn_confirm.Location = new Point(cb_Class.Location.X + 150, cb_Class.Location.Y);
                    btn_confirm.Enabled = false;
                    btn_confirm.Visible = false;
                    btn_confirm.BringToFront();
                    _player.CharacterRace = cb_Race.SelectedIndex; // 0 = Human 1 = Elf 2 = Dwarf 3 = Gnome 4 = Halfling 5 = Half Elf
                    cb_Race.Enabled = false;
                    cb_Class.Enabled = true;
                    cb_Class.Visible = true;
                    BindStatsToPlayer(ref _player);
                    SetAvailableClasses(ref _player);
                    SetMovementRates();
                    break;
                case 7: // Class
                    cb_Class.Enabled = false;
                    string _class = cb_Class.Text;
                    int index = 0;
                    if(_class.Contains("Bushi"))
                    {
                        index = 1;
                    }
                    else if (_class.Contains("Shinobi"))
                    {
                        index = 2;
                    }
                    else if (_class.Contains("Sohei"))
                    {
                        index = 3;
                    }
                    else if (_class.Contains("Onmyoji"))
                    {
                        index = 4;
                    }

                    if (index != 0)
                    {
                        _player.PlayerClass = index;
                    }
                    else
                    {
                        RestartChar();
                    }
                    _player.XPToNext = DM.GetXPToNext(_player.PlayerClass, 1);
                    lb_XPToNextValue.Text = _player.XPToNext.ToString();
                    if(_player.PlayerClass == 1)
                    {
                        _player.CharacterStats.ChangeHPWarrior(_player.CharacterStats.Current_Con);
                    }
                    SetHP();
                   
                    btn_confirm.Enabled = false;
                    btn_confirm.Visible = false;
                    btn_confirm.Location = new Point(cb_Alignment.Location.X + 150, cb_Alignment.Location.Y);
                    cb_Alignment.Enabled = true;
                    cb_Alignment.Visible = true;
                    break;
                case 8: // Alignment
                    cb_Alignment.Enabled = false;
                    cb_Gender.Enabled = true;
                    cb_Gender.Visible = true;
                    btn_confirm.Enabled = false;
                    btn_confirm.Visible = false;
                    btn_confirm.Location = new Point(cb_Gender.Location.X + 100, cb_Gender.Location.Y);
                    break;
                case 9:// Gender
                    InitialConfig();
                    cb_Gender.Enabled = false;
                    btn_confirm.Enabled = false;
                    btn_confirm.Visible = false;
                    btn_confirm.Text = "Continue";
                    btn_confirm.Location = new Point(620, 378);
                    break;
                case 10:
                    Specialization spec = new Specialization(ref _player);
                    spec.Show();
                    btn_confirm.Enabled = true;
                    btn_confirm.Visible = true;
                    break;
                case 11:
                    
                    break;
            }
            _index++;
        }

        private void SetMovementRates()
        {
            switch(_player.CharacterRace)
            {
                case 3:
                    _player.MovementRate = 6;
                    break;
                case 4:
                    _player.MovementRate = 6;
                    break;
                case 5:
                    _player.MovementRate = 6;
                    break;
                default:
                    _player.MovementRate = 12;
                    break;
            }
            lb_MoveBValue.Text = _player.MovementRate.ToString();
        }

        private void BindStatsToPlayer(ref Player p)
        {
            p.CharacterStats.Initial_Str = int.Parse(lb_StrValue.Text);
            p.CharacterStats.Current_Str = p.CharacterStats.Initial_Str;
            p.CharacterStats.SetAbilities(p.CharacterStats.Current_Str, "STR", 0); //PROSOXH EDW

            p.CharacterStats.Initial_Dex = int.Parse(lb_DexValue.Text);
            p.CharacterStats.Current_Dex = p.CharacterStats.Initial_Dex;
            p.CharacterStats.SetAbilities(p.CharacterStats.Current_Dex, "DEX");
            
            p.CharacterStats.Initial_Con = int.Parse(lb_ConValue.Text);
            p.CharacterStats.Current_Con = p.CharacterStats.Initial_Con;
            p.CharacterStats.SetAbilities(p.CharacterStats.Current_Con, "CON");
            
            p.CharacterStats.Initial_Int = int.Parse(lb_IntValue.Text);
            p.CharacterStats.Current_Int = p.CharacterStats.Initial_Int;
            p.CharacterStats.SetAbilities(p.CharacterStats.Current_Int, "INT");

            p.CharacterStats.Initial_Wis = int.Parse(lb_WisValue.Text);
            p.CharacterStats.Current_Wis = p.CharacterStats.Initial_Wis;
            p.CharacterStats.SetAbilities(p.CharacterStats.Current_Wis, "WIS");

            p.CharacterStats.Initial_Cha = int.Parse(lb_ChaValue.Text);
            p.CharacterStats.Current_Cha = p.CharacterStats.Initial_Cha;
            p.CharacterStats.SetAbilities(p.CharacterStats.Current_Cha, "CHA");
        }

        private void SetAvailableClasses(ref Player player)
        {
            List<string> available = new List<string>();
            switch (_player.CharacterRace)
            {
                default:
                    available.Add("Bushi");
                    available.Add("Shinobi");
                    available.Add("Onmyoji");
                    available.Add("Sohei");
                    break;
                case 2://dwarf
                    available.Add("Bushi");
                    available.Add("Shinobi");
                    available.Add("Sohei");
                    break;
            }

            if (_player.CharacterStats.Initial_Dex < 9)
            {
                if (available.Contains("Shinobi"))
                {
                    available.Remove("Shinobi");
                }
            }

            if (_player.CharacterStats.Initial_Wis < 9)
            {
                if (available.Contains("Sohei"))
                {
                    available.Remove("Sohei");
                }
            }

            if (_player.CharacterStats.Initial_Int < 9)
            {
                if (available.Contains("Onmyoji"))
                {
                    available.Remove("Onmyoji");
                }
            }

            if (_player.CharacterStats.Initial_Str < 9)
            {
                for(int i = 0; i < available.Count; i++)
                {
                    if (available[i] == "Bushi")
                    {
                        available.RemoveAt(i);
                    }
                }
            }

            if (available.Count == 0)
            {
                RestartChar();
            }
            else
            {
                for(int i = 0; i < available.Count;i++)
                {
                    cb_Class.Items.Add(available[i]);
                }
            }
        }

        private void cb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            btn_confirm.Visible = true;
            btn_confirm.BringToFront();
        }

        private void cb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            btn_confirm.Visible = true;
            btn_confirm.BringToFront();
        }

        private void btn_RandomName_Click(object sender, EventArgs e)
        {
            if (tb_FirstName.Enabled)
            {
                Random rand = new Random();
                
                if (cb_Gender.Text == "Otoko")
                {
                    int _r = rand.Next(0, DM.FirstNames_Male.Count);
                    tb_FirstName.Text = DM.FirstNames_Male[_r];
                }
                else
                {
                    int _r = rand.Next(0, DM.FirstNames_Female.Count);
                    tb_FirstName.Text = DM.FirstNames_Female[_r];
                }
                tb_FirstName.Select();
            }
            else
            {
                Random rand = new Random();
                int _r = rand.Next(0, DM.LastNames.Count);
                tb_LastName.Text = DM.LastNames[_r];
                tb_LastName.Select();
            }
        }

        private void cb_Alignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            btn_confirm.Visible = true;
            btn_confirm.BringToFront();
        }

        private void SetHP()
        {
            switch(_player.PlayerClass)
            {
                case 1://warrior
                    _player.HP_Max = 10;
                    _player.HP_Max += _player.CharacterStats.HPAdj;
                    _player.HP_Current = _player.HP_Max;
                    lb_HPValue.Text = _player.HP_Max.ToString();
                    break;
                case 2://rogue
                    _player.HP_Max = 6;
                    _player.HP_Max += _player.CharacterStats.HPAdj;
                    _player.HP_Current = _player.HP_Max;
                    lb_HPValue.Text = _player.HP_Max.ToString();
                    break;
                case 3://priest
                    _player.HP_Max = 8;
                    _player.HP_Max += _player.CharacterStats.HPAdj;
                    _player.HP_Current = _player.HP_Max;
                    lb_HPValue.Text = _player.HP_Max.ToString();
                    break;
                case 4://mage
                    _player.HP_Max = 4;
                    _player.HP_Max += _player.CharacterStats.HPAdj;
                    _player.HP_Current = _player.HP_Max;
                    lb_HPValue.Text = _player.HP_Max.ToString();
                    break;
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            RestartChar();
        }

        void RestartChar()
        {
            _index = 0;
            cb_Race.Enabled = false;
            cb_Class.Enabled = false;
            cb_Gender.Enabled = false;
            tb_FirstName.Enabled = false;
            lb_Cha.Visible = false;
            lb_ChaValue.Visible = false;
            lb_Wis.Visible = false;
            lb_WisValue.Visible = false;
            lb_Int.Visible = false;
            lb_IntValue.Visible = false;
            lb_Con.Visible = false;
            lb_ConValue.Visible = false;
            lb_Dex.Visible = false;
            lb_DexValue.Visible = false;
            btn_RollStats.Location = new Point(6, 13);
            btn_RollStats.BringToFront();
            btn_RollStats.Enabled = true;
            btn_RollStats.Visible = true;
            lb_RollResult.Text = "";
            lb_StrValue.Text = "";
            lb_RollResult.Location = new Point(15, 13);
            lb_RollResult.BringToFront();
        }
    }
}
