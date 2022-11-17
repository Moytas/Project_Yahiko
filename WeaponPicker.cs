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
    public partial class WeaponPicker : Form
    {
        /*
        private DMOptions DM = new DMOptions();

        public WeaponPicker()
        {
            InitializeComponent();
        }

        private void btn_AddNonWeaponProf_Click(object sender, EventArgs e)
        {
            foreach (Weapon w in DM.WeaponsList)
            {
                if (w.Name == lb_AvailableWeaponList.SelectedItem)
                {
                    if (Thief.FirstName != null)
                    {
                        if (Thief.NumWeaponProf > 0)
                        {
                            Thief.NumWeaponProf -= 1;
                            lb_LearnedProficienies.Items.Add(lb_AvailableNonWeaponList.SelectedItem);
                            lb_AvailableNonWeaponList.Items.Remove(lb_AvailableNonWeaponList.SelectedItem);
                        }
                        else if (player.NumWeaponProf == 0)
                        {
                            btn_ConfirmProf.Enabled = true;
                            showingWeaponProf = false;
                        }
                    }
                    else if (Priest.FirstName != null)
                    {
                        if (Priest.NumWeaponProf > 0)
                        {
                            Priest.NumWeaponProf -= 1;
                            Console.WriteLine(Priest.NumNonWeaponProf);
                            lb_LearnedProficienies.Items.Add(lb_AvailableNonWeaponList.SelectedItem);
                            lb_AvailableNonWeaponList.Items.Remove(lb_AvailableNonWeaponList.SelectedItem);
                        }
                        else if (player.NumWeaponProf == 0)
                        {
                            btn_ConfirmProf.Enabled = true;
                            showingWeaponProf = false;
                        }
                    }
                    else if (Mage.FirstName != null)
                    {
                        if (Mage.NumWeaponProf > 0)
                        {
                            Mage.NumWeaponProf -= 1;
                            lb_LearnedProficienies.Items.Add(lb_AvailableNonWeaponList.SelectedItem);
                            lb_AvailableNonWeaponList.Items.Remove(lb_AvailableNonWeaponList.SelectedItem);
                        }
                        else if (player.NumWeaponProf == 0)
                        {
                            btn_ConfirmProf.Enabled = true;
                            showingWeaponProf = false;
                        }
                    }

                    ShowRemainingWeaponProf();
                }
            }
        }
        */
    }
}
