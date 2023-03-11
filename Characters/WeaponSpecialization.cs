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
    public partial class WeaponSpecialization : Form
    {
        DMOptions DM;
        Bushi Player;
        public WeaponSpecialization(Bushi _Player)
        {
            Player = _Player;
            DM = new DMOptions();
            InitializeComponent();
            CreateAvailableList();
            InitButtons();
            ShowRemaining();
            btn_Confirm.Enabled = false;
        }

        void ShowRemaining()
        {
            lbl_Remaining.Text = string.Format("Remaing proficiencies:{0}", Player.NumWeaponProf);
        }

        void InitButtons()
        {
            btn_ForgetAvailableProficient.Enabled = false;
            btn_ForgetSpecializedProficient.Enabled = false;
            btn_LearnProficientSpecialized.Enabled = false;
        }

        void CreateAvailableList()
        {
            foreach(Weapon w in DM.WeaponsList)
            {
                lb_Available.Items.Add(w.Name);
            }
        }

        private void ShowDescription(string desc)
        {
            foreach (WeaponProficiency w in DM.WeaponProficiencies)
            {
                if (desc == w.Name)
                {
                    lbl_Description.Text = string.Format("Description:{0}", w.Description);
                    break;
                }
            }
        }
        private void lb_Available_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDescription(lb_Available.Text);
        }

        private void btn_LearnAvailableProficient_Click(object sender, EventArgs e)
        {
            if(Player.NumWeaponProf > 0)
            {
                Player.NumWeaponProf--;
                ShowRemaining();
                lb_Proficient.Items.Add(lb_Available.Text);
                lb_Available.Items.Remove(lb_Available.Text);
            }
            else
            {
                if(Player.NumWeaponProf == 0)
                {
                    btn_LearnAvailableProficient.Enabled = false;
                }
            }
        }

        private void btn_ForgetAvailableProficient_Click(object sender, EventArgs e)
        {
            lb_Available.Items.Add(lb_Proficient.Text);
            lb_Proficient.Items.Remove(lb_Proficient.Text);
            Player.NumWeaponProf++;
            ShowRemaining();

            if(lb_Proficient.Items.Count == 0)
            {
                btn_ForgetAvailableProficient.Enabled = false;
            }
        }

        private void lb_Proficient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDescription(lb_Proficient.Text);

            if(!btn_ForgetAvailableProficient.Enabled)
            {
                btn_ForgetAvailableProficient.Enabled = true;
            }

            if(!btn_LearnProficientSpecialized.Enabled)
            {
                btn_LearnProficientSpecialized.Enabled = true;
            }

            if(lb_Proficient.Items.Count == 0 && lb_Specialized.Items.Count == 0)
            {
                btn_Confirm.Enabled = false;
            }
            else
            {
                btn_Confirm.Enabled = true;
            }

        }

        private void btn_LearnProficientSpecialized_Click(object sender, EventArgs e)
        {
            if(lb_Specialized.Items.Count == 0)
            {
                if(lb_Proficient.Text != "Dankyu" || lb_Proficient.Text != "Hankyu")
                {
                    if(Player.NumWeaponProf >= 2)
                    {
                        Player.NumWeaponProf -= 2;
                        ShowRemaining();
                        
                    }
                }
                else
                {
                    if (Player.NumWeaponProf >= 3)
                    {
                        Player.NumWeaponProf -= 3;
                        ShowRemaining();
                    }
                }
                lb_Specialized.Items.Add(lb_Proficient.Text);
                lb_Proficient.Items.Remove(lb_Proficient.Text);
            }
            else
            {
                if(btn_LearnProficientSpecialized.Enabled)
                {
                    btn_LearnProficientSpecialized.Enabled = false;
                }
            }
        }

        private void btn_ForgetSpecializedProficient_Click(object sender, EventArgs e)
        {
            if (lb_Specialized.Text == "Hankyu" || lb_Specialized.Text == "Dankyu")
            {
                Player.NumWeaponProf += 3;
                ShowRemaining();
            }
            else
            {
                Player.NumWeaponProf += 2;
                ShowRemaining();
            }
            lb_Proficient.Items.Add(lb_Specialized.Text);
            lb_Specialized.Items.Remove(lb_Specialized.Text);
        }

        private void lb_Specialized_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDescription(lb_Specialized.Text);

            if(!btn_ForgetSpecializedProficient.Enabled)
            {
                btn_ForgetSpecializedProficient.Enabled = true;
            }

            if (lb_Proficient.Items.Count == 0 && lb_Specialized.Items.Count == 0)
            {
                btn_Confirm.Enabled = false;
            }
            else
            {
                btn_Confirm.Enabled = true;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //Save character
            if(lb_Specialized.Items.Count > 0)
            {  
                foreach(WeaponProficiency w in DM.WeaponProficiencies)
                {
                    if(w.Name == lb_Specialized.Items[0])
                    {
                        Player.WeaponSpecialization = w;
                    }
                }
            }

            if(lb_Proficient.Items.Count > 0)
            {
                foreach (WeaponProficiency w in DM.WeaponProficiencies)
                {
                    for (int i = 0; i < lb_Proficient.Items.Count; i++)
                    {
                        if (w.Name == lb_Proficient.Items[i])
                        {
                            Player.WeaponProf.Add(w);
                        }
                    }
                }
            }
            //Show Non Weapon Proficiencies
            NonWeapProfPicker nextForm = new NonWeapProfPicker(Player);
            nextForm.Show();
            this.Close();
        }
    }
}
