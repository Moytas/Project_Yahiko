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
        
        private DMOptions DM = new DMOptions();
        private Shinobi Thief = null;
        private Sohei Priest = null;
        private Onmyoji Mage = null;

        public WeaponPicker()
        {
            InitializeComponent();
        }
        public WeaponPicker(Onmyoji _Player)
        {
            Mage = _Player;
            InitializeComponent();
        }
        public WeaponPicker(Sohei _Player)
        {
            Priest = _Player;
            InitializeComponent();
        }
        public WeaponPicker(Shinobi _Player)
        {
            Thief = _Player;
            InitializeComponent();
        }

        private void SetUpAvailableList(int classIndex)
        {
            switch(classIndex)
            {
                case 1://Mage
                    lb_AvailableWeaponList.Items.Add("Tanto");
                    lb_AvailableWeaponList.Items.Add("Needle");
                    lb_AvailableWeaponList.Items.Add("Bo");
                    lb_AvailableWeaponList.Items.Add("Pellet Bow");
                    lb_AvailableWeaponList.Items.Add("Parang");
                    break;
                case 2://Priest
                    foreach(Weapon w in DM.WeaponsList)
                    {
                        if(w.WeaponType.Contains(Weapon.DamageType.Bludgeoning))
                        {
                            lb_AvailableWeaponList.Items.Add(w.Name);
                        }
                    }
                    break;
                case 3://Thief
                    lb_AvailableWeaponList.Items.Add("Bo");
                    lb_AvailableWeaponList.Items.Add("Hankyu");
                    lb_AvailableWeaponList.Items.Add("Cho - Ko - Nu");
                    lb_AvailableWeaponList.Items.Add("Ninja-to");
                    lb_AvailableWeaponList.Items.Add("Tanto");
                    lb_AvailableWeaponList.Items.Add("Chopsticks");
                    lb_AvailableWeaponList.Items.Add("Parang");
                    lb_AvailableWeaponList.Items.Add("Nekode");
                    lb_AvailableWeaponList.Items.Add("Kau sin ke");
                    lb_AvailableWeaponList.Items.Add("Kusarigama");
                    break;
            }
        }
        private void btn_AddNonWeaponProf_Click(object sender, EventArgs e)
        {
        }
    }
}
