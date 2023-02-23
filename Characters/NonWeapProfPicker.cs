using System;
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
    public partial class NonWeapProfPicker : Form
    {
        TABLE_NonWeapProficiencies table = new TABLE_NonWeapProficiencies();

        int points = 0; // Remaining points Taken from player.NumOfNonWeaponProf;
       
        #region Constructors
        public NonWeapProfPicker(Onmyoji Player)
        {
            InitializeComponent();
            points = Player.NumNonWeaponProf;
            PopulateGeneralList();
            PopulateClassList(4);
            lbl_Class.Text = "Onmyoji";
            ShowRemainingPoints();
        }

        public NonWeapProfPicker(Shinobi Player)
        {
            InitializeComponent();
            points = Player.NumNonWeaponProf;
            PopulateGeneralList();
            PopulateClassList(2);
            lbl_Class.Text = "Shinobi";
            ShowRemainingPoints();
        }

        public NonWeapProfPicker(Bushi Player)
        {
            InitializeComponent();
            points = Player.NumNonWeaponProf;
            PopulateGeneralList();
            PopulateClassList(1);
            lbl_Class.Text = "Bushi";
            ShowRemainingPoints();
        }

        public NonWeapProfPicker(Sohei Player)
        {
            InitializeComponent();
            points = Player.NumNonWeaponProf;
            PopulateGeneralList();
            PopulateClassList(3);
            lbl_Class.Text = "Sohei";
            ShowRemainingPoints();
        }
        #endregion
        #region Lists
        void PopulateGeneralList()
        {
            foreach(NonWeapProficiency p in table.NonWeaponProficiencies)
            {
                if(p.ProfType == NonWeapProficiency.Type.General)
                {
                    lb_General.Items.Add(string.Format("{0} Cost:{1} {2} {3}",p.Name,p.Cost,p.Ability,p.Modifier));
                }
            }
        }

        void PopulateClassList(int classNum)
        {
            switch(classNum)
            {
                case 1: // Warrior
                    foreach(NonWeapProficiency p in table.NonWeaponProficiencies)
                    {
                        if(p.ProfType == NonWeapProficiency.Type.Warrior)
                        {
                            lb_Class.Items.Add(string.Format("{0} Cost:{1} {2} {3}", p.Name, p.Cost, p.Ability, p.Modifier));
                        }
                    }
                    break;
                case 2: // Thief
                    foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
                    {
                        if (p.ProfType == NonWeapProficiency.Type.Thief)
                        {
                            lb_Class.Items.Add(string.Format("{0} Cost:{1} {2} {3}", p.Name, p.Cost, p.Ability, p.Modifier));
                        }
                    }
                    break;
                case 3: // Priest
                    foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
                    {
                        if (p.ProfType == NonWeapProficiency.Type.Priest)
                        {
                            lb_Class.Items.Add(string.Format("{0} Cost:{1} {2} {3}", p.Name, p.Cost, p.Ability, p.Modifier));
                        }
                    }
                    break;
                case 4: // Wizard
                    foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
                    {
                        if (p.ProfType == NonWeapProficiency.Type.Mage)
                        {
                            lb_Class.Items.Add(string.Format("{0} Cost:{1} {2} {3}", p.Name, p.Cost, p.Ability, p.Modifier));
                        }
                    }
                    break;


            }
        }

        private void lb_General_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_General.SelectedIndex != -1)
            {
                foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
                {
                    if (p.Name == lb_General.Text)
                    {
                        lbl_Description.Text = string.Format("Description:{0}", p.Description);
                        break;
                    }
                }
                lb_Class.SelectedIndex = -1;
            }
        }
        
        private void lb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lb_Class.SelectedIndex != -1)
            {
                foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
                {
                    if (p.Name == lb_Class.Text)
                    {
                        lbl_Description.Text = string.Format("Description:{0}", p.Description);
                        break;
                    }
                }
                lb_General.SelectedIndex = -1;
            }
        }

        private void lb_Known_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
            {
                if (p.Name == lb_Known.Text)
                {
                    lbl_Description.Text = string.Format("Description:{0}", p.Description);
                    return;
                }
            }
        }


        #endregion

        #region Buttons
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(lb_General.SelectedIndex != -1 || lb_Class.SelectedIndex != -1)
            {
                if(lb_Class.SelectedIndex != -1)
                {
                    foreach(NonWeapProficiency p in table.NonWeaponProficiencies)
                    {
                        if(lb_Class.Text.Contains(p.Name))
                        {
                            if(points - p.Cost >= 0)
                            {
                                points -= p.Cost;
                                lb_Known.Items.Add(p.Name);
                                lb_Class.Items.Remove(lb_Class.Text);
                                ShowRemainingPoints();
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (NonWeapProficiency p in table.NonWeaponProficiencies)
                    {
                        if (lb_General.Text.Contains(p.Name))
                        {
                            if (points - p.Cost >= 0)
                            {
                                points -= p.Cost;
                                lb_Known.Items.Add(p.Name);
                                lb_General.Items.Remove(lb_General.Text);
                                ShowRemainingPoints();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if(lb_Known.SelectedIndex != -1)
            {
                foreach(NonWeapProficiency p in table.NonWeaponProficiencies)
                {
                    if(lb_Known.Text == p.Name)
                    {
                        points += p.Cost;
                        ShowRemainingPoints();
                        lb_Known.Items.Remove(lb_Known.Text);
                    }
                }
            }
        }
        #endregion

        #region Labels

        void ShowRemainingPoints()
        {
            lbl_Remaining.Text = string.Format("Remaining:{0}", points);
        }

        #endregion
    }
}
