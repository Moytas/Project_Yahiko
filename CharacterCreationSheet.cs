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
    public partial class CharacterCreationSheet : Form
    {
        public Player _player;
        
        public Bushi _Bushi;
        public Shinobi _Shinobi;
        public Onmyoji _Onmyoji;
        public Sohei _Sohei;

        private int _index = 0;
        
        private DMOptions DM;
        
        public CharacterCreationSheet()
        {
            DM = new DMOptions();
            InitializeComponent();
            EnableStatRoll();
        }

        private void NameEnable() // stupid name
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
            CharacterCreationSheet.ActiveForm.Text = String.Format("{0}'s Sheet",tb_FirstName.Text);
        }

        public void GetPlayer(ref Player player)
        {
            _player =  player;
            SetUpWeapon(_player);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               
            }
        }

        public void SetUpWeapon(Player p)
        {
            tb_WeaponName.Text = p.EquipedWeapon.Name;
            tb_WeaponSpeedValue.Text = p.EquipedWeapon.Speed.ToString();
            tb_WeaponTypeValue.Text = "B";
            tb_DmgSValue.Text = String.Format("{0}d{1}", p.EquipedWeapon.NumOfDie_Small, p.EquipedWeapon.TypeOfDie_Small);
            tb_DmgLValue.Text = String.Format("{0}d{1}", p.EquipedWeapon.NumOfDie_Large, p.EquipedWeapon.TypeOfDie_Large);
        }

        private void EnableStatRoll()
        {
            SetupRandomButton();
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
                    BindStatsToPlayer();
                    SetAvailableClasses();
                    SetMovementRates();
                    break;
                case 7: // Class

                    if (cb_Class.Text.Contains("Bushi"))
                    {
                        _player.CharacterClass = 1;
                    }
                    else if (cb_Class.Text.Contains("Shinobi"))
                    {
                        _player.CharacterClass = 2;
                        for(int i = 0; i < cb_Alignment.Items.Count;i++)
                        {
                            if (cb_Alignment.Items[i].ToString().Contains("Lawful"))
                            {
                                cb_Alignment.Items.RemoveAt(i);
                            }
                        }
                    }
                    else if (cb_Class.Text.Contains("Sohei"))
                    {
                        _player.CharacterClass = 3;
                    }
                    else if (cb_Class.Text.Contains("Onmyoji"))
                    {
                        _player.CharacterClass = 4;
                    }
                    
                    if (_player.CharacterClass == 0)
                    {
                        lb_InfoText.Text = "No available classes... Roll again";
                        Thread.Sleep(3000);
                        RestartChar();
                    }

                    _player.XPToNext = DM.GetXPToNext(_player.CharacterClass, 1);
                    lb_XPToNextValue.Text = _player.XPToNext.ToString();
                    if(_player.CharacterClass == 1)
                    {
                        _player.CharacterStats.ChangeHPWarrior(_player.CharacterStats.Current_Con);
                    }
                    SetHP();
                    SetNumOfProficiencies();
                    btn_confirm.Enabled = false;
                    btn_confirm.Visible = false;
                    btn_confirm.Location = new Point(cb_Alignment.Location.X + 50, cb_Alignment.Location.Y);
                    cb_Alignment.Enabled = true;
                    cb_Alignment.Visible = true;
                    cb_Class.Enabled = false;
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
                    ud_Height.Visible = true;
                    ud_Height.Enabled = true;
                    ud_Age.Visible = true;
                    ud_Age.Enabled = true;
                    switch (_player.CharacterRace)// 0 = Human 1 = Elf 2 = Dwarf 3 = Gnome 4 = Halfling 5 = Half Elf
                    {
                        case 0:
                            ud_Height.Minimum = 5;
                            ud_Height.Maximum = 7;
                            ud_Age.Minimum = 18;
                            ud_Age.Maximum = 23;
                            ud_Age.Value = ud_Age.Minimum;
                            ud_Height.Value = ud_Height.Minimum;
                            break;
                        case 1:
                            ud_Height.Minimum = 4;
                            ud_Height.Maximum = 6;
                            ud_Age.Minimum = 110;
                            ud_Age.Maximum = 220;
                            ud_Age.Value = ud_Age.Minimum;
                            ud_Height.Value = ud_Height.Minimum;
                            break;
                        case 2:
                            ud_Height.Minimum = 3;
                            ud_Height.Maximum = 5;
                            ud_Age.Minimum = 110;
                            ud_Age.Maximum = 150;
                            ud_Age.Value = ud_Age.Minimum;
                            ud_Height.Value = ud_Height.Minimum;
                            break;
                        case 3:
                            ud_Height.Minimum = 2;
                            ud_Height.Maximum = 4;
                            ud_Height.Value = ud_Height.Minimum;

                            ud_Age.Minimum = 80;
                            ud_Age.Maximum = 90;
                            ud_Age.Value = ud_Age.Minimum;
                            break;
                        case 4:
                            ud_Height.Minimum = 2;
                            ud_Height.Maximum = 4;
                            ud_Height.Value = ud_Height.Minimum;
                            
                            ud_Age.Minimum = 20;
                            ud_Age.Maximum = 30;
                            ud_Age.Value = ud_Age.Minimum;
                            break;
                        case 5:
                            ud_Height.Minimum = 4;
                            ud_Height.Maximum = 6;
                            ud_Height.Value = ud_Height.Minimum;

                            ud_Age.Minimum = 18;
                            ud_Age.Maximum = 30;
                            ud_Age.Value = ud_Age.Minimum;
                            break;
                    }
                    
                    cb_Gender.Enabled = false;
                    //btn_confirm.Enabled = false;
                    //btn_confirm.Visible = false;
                    btn_confirm.Location = new Point(ud_Height.Location.X + ud_Height.Width, ud_Height.Location.Y);
                    break;
                
                case 10://Height & Age
                    NameEnable();
                    break;
                case 11://First Name
                    _player.FirstName = tb_FirstName.Text;
                    tb_FirstName.Enabled = false;
                    tb_LastName.Enabled = true;
                    tb_LastName.Focus();
                    break;
                case 12://Last name
                    _player.LastName = tb_LastName.Text;
                    btn_RandomName.Enabled = false;
                    btn_RandomName.Visible = false;
                    tb_LastName.Enabled = false;
                    btn_confirm.Text = "Continue";
                    btn_confirm.Location = new Point(620, 378);
                    btn_confirm.Enabled = true;
                    //btn_confirm.Visible = false;
                    break;
                case 13://next form
                    btn_Restart.Enabled = false;
                    btn_Restart.Visible = false;
                    //DECIDE NEXT FORM
                    switch(_player.CharacterClass)
                    {
                        case 1://Warrior
                            _Bushi =  new Bushi(_player);
                            WeaponSpecialization weaponSpecializationForm = new WeaponSpecialization(_Bushi);
                            weaponSpecializationForm.Show();
                            this.Hide();
                            break;
                        case 2://Thief
                            break;
                        case 3://Priest?
                            break;
                        case 4://Mage?
                            break;
                    }
                    break;
            }
            _index++;
        }

        void SetNumOfProficiencies()
        {
            switch(_player.CharacterClass)
            {
                case 1:
                    _player.NumNonWeaponProf = 3 + _player.CharacterStats.NumLanguages;
                    _player.NumWeaponProf = 4;
                    break;
                case 2:
                    _player.NumNonWeaponProf = 3 + _player.CharacterStats.NumLanguages;
                    _player.NumWeaponProf = 2;
                    break;
                case 3:
                    _player.NumNonWeaponProf = 4 + _player.CharacterStats.NumLanguages;
                    _player.NumWeaponProf = 2;
                    break;
                case 4:
                    _player.NumNonWeaponProf = 4 + _player.CharacterStats.NumLanguages;
                    _player.NumWeaponProf = 1;
                    break;
            }
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

        private void BindStatsToPlayer()
        {
            _player.CharacterStats.Initial_Str = int.Parse(lb_StrValue.Text);
            _player.CharacterStats.Current_Str = _player.CharacterStats.Initial_Str;
            _player.CharacterStats.SetAbilities(_player.CharacterStats.Current_Str, "STR", 0); //PROSOXH EDW

            _player.CharacterStats.Initial_Dex = int.Parse(lb_DexValue.Text);
            _player.CharacterStats.Current_Dex = _player.CharacterStats.Initial_Dex;
            _player.CharacterStats.SetAbilities(_player.CharacterStats.Current_Dex, "DEX");

            _player.CharacterStats.Initial_Con = int.Parse(lb_ConValue.Text);
            _player.CharacterStats.Current_Con = _player.CharacterStats.Initial_Con;
            _player.CharacterStats.SetAbilities(_player.CharacterStats.Current_Con, "CON");

            _player.CharacterStats.Initial_Int = int.Parse(lb_IntValue.Text);
            _player.CharacterStats.Current_Int = _player.CharacterStats.Initial_Int;
            _player.CharacterStats.SetAbilities(_player.CharacterStats.Current_Int, "INT");

            _player.CharacterStats.Initial_Wis = int.Parse(lb_WisValue.Text);
            _player.CharacterStats.Current_Wis = _player.CharacterStats.Initial_Wis;
            _player.CharacterStats.SetAbilities(_player.CharacterStats.Current_Wis, "WIS");

            _player.CharacterStats.Initial_Cha = int.Parse(lb_ChaValue.Text);
            _player.CharacterStats.Current_Cha = _player.CharacterStats.Initial_Cha;
            _player.CharacterStats.SetAbilities(_player.CharacterStats.Current_Cha, "CHA");

            SetupAbilities();
            gb_Abilities.Visible = true;

        }

        void SetupAbilities() // FILL THEM IN
        {

        }

        private void SetAvailableClasses()
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
                if (available.Contains("Bushi"))
                {
                    available.Remove("Bushi");
                }
            }

            if (available.Count == 0)
            {
                RestartChar();
            }
            else
            {
                cb_Class.Items.Clear();
                for (int i = 0; i < available.Count;i++)
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
            switch(_player.CharacterClass)
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
            btn_RollStats.Location = new Point(124, 116);
            btn_RollStats.BringToFront();
            btn_RollStats.Enabled = true;
            btn_RollStats.Visible = true;
            lb_RollResult.Text = "";
            lb_StrValue.Text = "";
            lb_RollResult.Location = new Point(127, 116);
            lb_RollResult.BringToFront();
            btn_confirm.Text = "Confirm";
            btn_confirm.Enabled = false;
            btn_confirm.Visible = false;

            cb_Alignment.SelectedItem = "";
            cb_Class.SelectedItem = "";
            cb_Gender.SelectedItem = "";
            cb_Race.SelectedItem = "";
            btn_confirm.Location = new Point(cb_Race.Location.X + cb_Race.Text.Length + 10, cb_Race.Location.Y);
        }

       void SetupRandomButton()
        {
            btn_RollStats.Location = new Point(124, 116);
            btn_RollStats.BringToFront();
            btn_RollStats.Enabled = true;
            btn_RollStats.Visible = true;
            lb_RollResult.Text = "";
            lb_RollResult.Location = new Point(127, 116);
            lb_RollResult.BringToFront();
        }

        private void ud_Age_ValueChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            btn_confirm.Visible = true;
            btn_confirm.BringToFront();
        }

        private void ud_Height_ValueChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            btn_confirm.Visible = true;
            btn_confirm.BringToFront();
        }
    }
}
