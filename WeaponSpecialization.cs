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

        private void lb_Available_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Weapon w in DM.WeaponsList)
            {
                if(lb_Available.Text == w.Name)
                {
                    lbl_Description.Text = string.Format("Description:{0}", w.Description);
                    break;
                }
            }

            
        }
    }
}
