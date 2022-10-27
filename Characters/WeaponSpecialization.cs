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
        int Available;
        const string InitialText = "The formidable bushi is a true master of weapons...\n";
        string AvailableText;
        public WeaponSpecialization(Player player)
        {
            DM = new DMOptions();
            Player = new Bushi(player);
            InitializeComponent();
            InitialSetUp();
            Available = Player.NumWeaponProf;
            AvailableText = string.Format("Remaining: {0}", Available);
            lbl_WeaponSpecializationInfo.Text = InitialText + AvailableText;
            btn_Confirm.Enabled = false;
        }

        void InitialSetUp()
        {
            lb_Available.Items.Clear();
            lb_Proficient.Items.Clear();
            lb_Specialized.Items.Clear();

            for(int i = 0; i < DM.WeaponProficiencies.Count;i++)
            {
                lb_Available.Items.Add(DM.WeaponProficiencies[i].Name);
            }
        }

        void UpdateAvailableText()
        {
            AvailableText = string.Format("Remaining: {0}", Available);
            lbl_WeaponSpecializationInfo.Text = InitialText + AvailableText;
        }

        private void btn_LearnAvailable_Click(object sender, EventArgs e)
        {
            foreach(WeaponProficiency wp in DM.WeaponProficiencies)
            {
                if(wp.Name == lb_Available.Text)
                {
                    if(Available >= wp.Cost)
                    {
                        lb_Proficient.Items.Add(wp.Name);
                        lb_Available.Items.Remove(lb_Available.SelectedItem);
                        Available -= wp.Cost;
                        Player.NumWeaponProf = Available;
                        UpdateAvailableText();
                        if(!btn_Confirm.Enabled)
                        {
                            btn_Confirm.Enabled = true;
                        }
                    }
                    return;
                }
            }
        }

        private void btn_LearnProficient_Click(object sender, EventArgs e)
        {
            foreach (WeaponProficiency wp in DM.WeaponProficiencies)
            {
                if (wp.Name == lb_Proficient.Text)
                {
                    if (Available >= wp.Cost + 1)
                    {
                        lb_Specialized.Items.Add(wp.Name);
                        lb_Proficient.Items.Remove(lb_Proficient.SelectedItem);
                        Available -= wp.Cost + 1;
                        Player.NumWeaponProf = Available;
                        UpdateAvailableText();
                    }
                    return;
                }
            }
        }

        private void btn_ForgetProficient_Click(object sender, EventArgs e)
        {
            foreach (WeaponProficiency wp in DM.WeaponProficiencies)
            {
                if (wp.Name == lb_Proficient.Text)
                {   
                    lb_Available.Items.Add(wp.Name);
                    lb_Proficient.Items.Remove(lb_Proficient.SelectedItem);
                    Available += wp.Cost;
                    Player.NumWeaponProf = Available;
                    UpdateAvailableText();
                    if(lb_Proficient.Items.Count == 0)
                    {
                        btn_Confirm.Enabled = false;
                    }
                    return;
                }
            }
        }

        private void btn_ForgetSpecialized_Click(object sender, EventArgs e)
        {
            foreach (WeaponProficiency wp in DM.WeaponProficiencies)
            {
                if (wp.Name == lb_Specialized.Text)
                {
                    lb_Proficient.Items.Add(wp.Name);
                    lb_Specialized.Items.Remove(lb_Specialized.SelectedItem);
                    Available += wp.Cost + 1;
                    Player.NumWeaponProf = Available;
                    UpdateAvailableText();
                    return;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //save char
            this.Close();
        }

       
    }
}
