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
        private int remainingPoints;

        #region Constructors
        public WeaponPicker()
        {
            InitializeComponent();
        }
        public WeaponPicker(Onmyoji _Player)
        {
            Mage = _Player;
            InitializeComponent();
            remainingPoints = Mage.NumWeaponProf;
            SetUpAvailableList(1);
            ShowRemainingPoints();
            ShowMessageToPlayer(3);
        }
        public WeaponPicker(Sohei _Player)
        {
            Priest = _Player;
            InitializeComponent();
            remainingPoints = Priest.NumWeaponProf;
            SetUpAvailableList(2);
            ShowMessageToPlayer(2);
            ShowRemainingPoints();
        }
        public WeaponPicker(Shinobi _Player)
        {
            Thief = _Player;
            InitializeComponent();
            remainingPoints = Thief.NumWeaponProf;            
            SetUpAvailableList(3);
            ShowMessageToPlayer(3);
            ShowRemainingPoints();
        }
        #endregion

        #region Buttons
        private void btn_AddWeaponProf_Click(object sender, EventArgs e)
        {
            if (lb_AvailableWeaponList.Text != "" && remainingPoints > 0)
            {
                lb_LearnedProficienies.Items.Add(lb_AvailableWeaponList.Text);
                lb_AvailableWeaponList.Items.Remove(lb_AvailableWeaponList.Text);
                remainingPoints--;
                //if (Thief != null)
                //{
                //    if (Thief.NumWeaponProf > 0)
                //    {
                //        Thief.NumWeaponProf--;
                //    }
                //}
                //if (Priest != null)
                //{
                //    if (Priest.NumWeaponProf > 0)
                //    {
                //        Priest.NumWeaponProf--;
                //    }
                //}
                //if (Mage != null)
                //{
                //    if (Mage.NumWeaponProf > 0)
                //    {
                //        Mage.NumWeaponProf--;
                //    }
                //}

                ShowRemainingPoints();
            }
        }
        private void btn_RemoveWeaponProficiency_Click(object sender, EventArgs e)
        {
            if (lb_LearnedProficienies.Text != "")
            {
                lb_AvailableWeaponList.Items.Add(lb_LearnedProficienies.Text);
                lb_LearnedProficienies.Items.Remove(lb_LearnedProficienies.Text);
                remainingPoints++;
                //if (Thief != null)
                //{
                //    Thief.NumWeaponProf++;
                //}

                //if (Priest != null)
                //{
                //    Priest.NumWeaponProf++;
                //}

                //if (Mage != null)
                //{
                //    Mage.NumWeaponProf++;
                //}
                ShowRemainingPoints();
            }
        }
        private void btn_ConfirmProf_Click(object sender, EventArgs e)
        {
            if (Thief != null)
            {
                foreach (string i in lb_AvailableWeaponList.Items)
                {
                    Thief.WeaponProf.Add(new WeaponProficiency(i, GetDescription(i)));
                    Thief.NumWeaponProf = remainingPoints;
                }
                NonWeapProfPicker nextForm = new NonWeapProfPicker(Thief);
                nextForm.Show();
                this.Close();
            }

            if (Priest != null)
            {
                foreach (string i in lb_AvailableWeaponList.Items)
                {
                    Priest.WeaponProf.Add(new WeaponProficiency(i, GetDescription(i)));
                    Priest.NumWeaponProf = remainingPoints;
                }
                NonWeapProfPicker nextForm = new NonWeapProfPicker(Priest);
                nextForm.Show();
                this.Close();
            }

            if (Mage != null)
            {
                foreach (string i in lb_AvailableWeaponList.Items)
                {
                    Mage.WeaponProf.Add(new WeaponProficiency(i, GetDescription(i)));
                    Mage.NumWeaponProf = remainingPoints;
                }
                NonWeapProfPicker nextForm = new NonWeapProfPicker(Mage);
                nextForm.Show();
                this.Close();
            }


        }

        #endregion

        #region ListBoxes
        private void SetUpAvailableList(int classIndex)
        {
            switch (classIndex)
            {
                case 1://Mage
                    lb_AvailableWeaponList.Items.Add("Tanto");
                    lb_AvailableWeaponList.Items.Add("Needle");
                    lb_AvailableWeaponList.Items.Add("Bo");
                    lb_AvailableWeaponList.Items.Add("Pellet Bow");
                    lb_AvailableWeaponList.Items.Add("Parang");
                    break;
                case 2://Priest
                    foreach (Weapon w in DM.WeaponsList)
                    {
                        if (w.WeaponType.Contains(Weapon.DamageType.Bludgeoning))
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
        private void lb_AvailableWeaponList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Weapon w in DM.WeaponsList)
            {
                if(lb_AvailableWeaponList.Text == w.Name)
                {
                    ShowDescription_L(w.Description);
                    return;
                }
            }
        }
        private void lb_LearnedProficienies_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Weapon w in DM.WeaponsList)
            {
                if (lb_LearnedProficienies.Text == w.Name)
                {
                    ShowDescription_R(w.Description);
                    return;
                }
            }
        }
        #endregion

        #region Labels
        private void ShowMessageToPlayer(int playerClass)
        {
            switch (playerClass)
            {
                case 1://Mage/Onmyoji
                    lb_WeapProfsText.Text = string.Format("{0} pick which weapons you are familiar with:", Mage.FirstName);
                    break;
                case 2://Priest/Sohei
                    lb_WeapProfsText.Text = string.Format("{0} pick which weapons you are familiar with:", Priest.FirstName);
                    break;
                case 3://Thief/Shinobi
                    lb_WeapProfsText.Text = string.Format("{0} pick which weapons you are familiar with:", Thief.FirstName);
                    break;
            }
        }

        private void ShowRemainingPoints()
        {
            lbl_AvailablePoints.Text = string.Format("Remaining points: {0}", remainingPoints);
            //if (Thief != null)
            //{
            //    lbl_AvailablePoints.Text = string.Format("Remaining points: {0}", Thief.NumWeaponProf);
            //}

            //if (Priest != null)
            //{
            //    lbl_AvailablePoints.Text = string.Format("Remaining points: {0}", Priest.NumWeaponProf);
            //}

            //if (Mage != null)
            //{
            //    lbl_AvailablePoints.Text = string.Format("Remaining points: {0}", Mage.NumWeaponProf);
            //}
        }

        private void ShowDescription_L(string description)
        {
            lb_SelectedProfDescription_L.Text = String.Format("Description:\n{0}", description);
        }

        private void ShowDescription_R(string description)
        {
            lb_SelectedProfDescription_R.Text = String.Format("Description:\n{0}", description);
        }

        #endregion







        private string GetDescription(string name)
        {
            foreach(Weapon w in DM.WeaponsList)
            {
                if(w.Name == name)
                {
                    return w.Description;
                }
            }

            return string.Empty;
        }

        
    }
}
