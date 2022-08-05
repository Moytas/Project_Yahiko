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
    public partial class Specialization : Form
    {
        Player player = new Player();
        int pool = 60;
        int weaponProf = 4;
        string introText_NonWeaponProfs;
        string introText_Samurai, introText_Shinobi, introText_Onmyoji, introText_Sohei;
        bool showingWeaponProf = false;

        int initial_pp, initial_ol, initial_frt, initial_ms, initial_hs, initial_dn, initial_cw, initial_rl;
        DMOptions DM = new DMOptions();

        public Specialization(Player _p)
        {
            InitializeComponent();
            player = _p;
            switch (_p.CharacterClass)
            {
                case 1: // warrior
                    this.Text = "Bushi specialization";
                    tabControl1.SelectedTab = tabSamurai;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabShinobi);
                    tabControl1.TabPages.Remove(tabProficiencies);
                    PopulateOptionsWeapon();
                    ShowWarriorInfo();
                    break;
                case 2: // thief
                    this.Text = "Shinobi skills";
                    tabControl1.SelectedTab = tabShinobi;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabSamurai);
                    tabControl1.TabPages.Remove(tabProficiencies);
                    AdjustThiefSkills();
                    ShowInfoThiefSkills();
                    break;
                case 3: // priest
                    this.Text = "Sohei spells";
                    tabControl1.SelectedTab = tabMonk;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabShinobi);
                    tabControl1.TabPages.Remove(tabSamurai);
                    tabControl1.TabPages.Remove(tabProficiencies);
                    InitialConfig_Priest();
                    break;
                case 4: // mage
                    this.Text = "Onmyoji spells";
                    tabControl1.SelectedTab = tabMage;
                    tabControl1.TabPages.Remove(tabProficiencies);
                    tabControl1.TabPages.Remove(tabShinobi);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabSamurai);
                    InitialConfig_Mage();
                    break;
            }
        }

        #region Texts
        private void ShowInfoThiefSkills()
        { }
        private void ShowPriestInfo()
        {
            lb_PriestInfoText.Text = "";
            lb_PriestInfoText.Text = "Priests in Nippon ..... Walk the path blah blah... Choose spells blah blah /n";
            lb_PriestInfoText.Text += String.Format("Remaining spells: {0}", player.CharacterStats.NumMaxSpellsPerLevel - lb_PriestSpellBook.Items.Count);
        }

        private void ShowWarriorInfo()
        {
            lb_SamuraiIntroText.Text = "The formidable bushi is a true master of weapons...\n Remaining Weapon Proficiencies: " + player.NumWeaponProf;
        }

        private void ShowMageInfo()
        {
            lb_MageInfoText.Text = "";
            lb_MageInfoText.Text = "The onmyoji is a master of elements, using hand seal techniques while speaking words of power creates magic /n";
            lb_MageInfoText.Text += String.Format("Remaining spells: {0}", player.CharacterStats.NumMaxSpellsPerLevel - lb_MageSpellBook.Items.Count);
        }



        void ShowText_NonWeaponProficiencies(int numLeft)
        {
            lb_NonWeapProfsText.Text = string.Format("Remaining Non Weapon Proficiencies: {0}", numLeft);
        }
        #endregion
        void ShowProficienciesTab(Player player)
        {
            tabControl1.TabPages.Add(tabProficiencies);
            tabControl1.SelectedTab = tabProficiencies;
            foreach (TabPage t in tabControl1.TabPages)
            {
                if (t != tabProficiencies)
                {
                    tabControl1.TabPages.Remove(t);
                }
            }

            switch (player.CharacterClass)
            {
                case 1:
                    lb_NonWeapProfsText.Text = "The bushi can learn the following skills..\nAvailable Non Weapon Proficiencies: " + player.NonWeaponProf;
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.General || prof.ProfType == NonWeapProficiency.Type.Warrior)
                        {
                            lb_AvailableNonWeaponList.Items.Add(prof.Name);
                        }
                    }
                    break;
                case 2:
                    lb_NonWeapProfsText.Text = "The shinobi can learn the following skills..\nAvailable Non Weapon Proficiencies: " + player.NonWeaponProf;
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.General || prof.ProfType == NonWeapProficiency.Type.Thief)
                        {
                            lb_AvailableNonWeaponList.Items.Add(prof.Name);
                        }
                    }
                    break;
                case 3:
                    lb_NonWeapProfsText.Text = "The sohei can learn the following skills..\nAvailable Non Weapon Proficiencies: " + player.NonWeaponProf;
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.General || prof.ProfType == NonWeapProficiency.Type.Priest)
                        {
                            lb_AvailableNonWeaponList.Items.Add(prof.Name);
                        }
                    }
                    break;
                case 4:
                    lb_NonWeapProfsText.Text = "The onmyoji can learn the following skills..\nAvailable Non Weapon Proficiencies: " + player.NonWeaponProf;
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.General || prof.ProfType == NonWeapProficiency.Type.Mage)
                        {
                            lb_AvailableNonWeaponList.Items.Add(prof.Name);
                        }
                    }
                    break;
            }

        }

        void ShowWeaponProf(int _class)
        {
            Console.WriteLine("Player class = " + _class);
            switch (_class)
            {
                case 2:
                    foreach (Weapon w in DM.WeaponsList)
                    {
                        lb_AvailableList.Items.Add(w.Name);
                    }
                    break;
                case 3:
                    if (showingWeaponProf)
                    {
                        this.Text = "A Sohei's Arsenal";
                        tabControl1.TabPages[0].Text = "Sohei";
                        lb_SamuraiIntroText.Text = "A Sohei has a variety of weapons that can be chosen...";
                        foreach (Weapon w in DM.WeaponsList)
                        {
                            if (w.WeaponType.Contains(Weapon.DamageType.Bludgeoning) && w.WeaponType.Count == 1)
                            {
                                lb_AvailableList.Items.Add(w.Name);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("oops");
                    }
                    break;
                case 4:
                    if (showingWeaponProf)
                    {
                        this.Text = "An Onmyoji's Arsenal";
                        lb_MageInfoText.Text = "After you cast your last spell, my dearest onmyoji, you will need to protect yourself.. Choose how...";
                        lb_MageInfoText.Text += string.Format("Remaining Weapon Proficiencies: {0}",player.NumNonWeaponProf.ToString());
                        foreach (Weapon w in DM.WeaponsList)
                        {
                            if (w.WeaponType.Contains(Weapon.DamageType.Bludgeoning) && w.WeaponType.Count == 1)
                            {
                                lb_AvailableList.Items.Add(w.Name);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("oops");
                    }
                    break;
            }
            tabControl1.Controls.Add(tabProficiencies);
            foreach (TabPage tab in tabControl1.Controls)
            {
                if (tab != tabProficiencies)
                {
                    tabControl1.TabPages.Remove(tab);
                }
            }
            tabControl1.SelectedTab = tabProficiencies;

        }

        void ShowNonWeapProf(int _class)
        {

        }

        private void btn_LearnAvProf_Clicked(object sender, EventArgs e)
        {
            if (tabSamurai.Text == "Bushi")
            {
                if (lb_AvailableList.Text.Contains("Daikyu") || lb_AvailableList.Text.Contains("Hankyu") || lb_AvailableList.Text.Contains("Bow"))
                {

                    if (weaponProf > 0 && weaponProf - 2 >= 0)
                    {
                        weaponProf -= 2;
                        //lb_AvailablePointsValue.Text = weaponProf.ToString();
                        lb_ProficientList.Items.Add(lb_AvailableList.SelectedItem);
                        lb_AvailableList.Items.Remove(lb_AvailableList.Text);
                    }
                }
                else
                {
                    if (weaponProf > 0 && weaponProf - 1 >= 0)
                    {
                        weaponProf -= 1;
                        //lb_AvailablePointsValue.Text = weaponProf.ToString();
                        lb_ProficientList.Items.Add(lb_AvailableList.SelectedItem);
                        lb_AvailableList.Items.Remove(lb_AvailableList.Text);
                    }
                }
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
        
        private void lb_AvailableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonWeapProficiency prof = null;
            foreach(NonWeapProficiency p in DM.NonWeaponProficiencies)
            {
                if(p.Name == lb_AvailableNonWeaponList.Text)
                {
                    prof = p;
                    break;
                }
            }
            if(player.NumNonWeaponProf - prof.RequiredSlots >= 0)
            {
                player.NumNonWeaponProf -= prof.RequiredSlots;
                lb_LearnedProficienies.Items.Add(lb_AvailableNonWeaponList.Text);
                lb_AvailableList.Items.Remove(lb_AvailableList.Text);
            }
            ShowText_NonWeaponProficiencies(player.NumNonWeaponProf);
        }


        #region Warrior
        private void btn_SamuraiAccept_Click(object sender, EventArgs e)
        {
            ShowProficienciesTab(player);
        }
        void PopulateOptionsWeapon()
        {
            // Katana / Bokken * Ninja - to * No - daichi * Tetsu - to * Tanto / Yoroi - toshi * Wakizashi *
            List<string> Weapons = new List<string>();
            Weapons.Add("Katana");
            Weapons.Add("Ninja-to");
            Weapons.Add("No-daichi");
            Weapons.Add("Tetsu-to");
            Weapons.Add("Tanto");
            Weapons.Add("Yoroi-toshi");
            Weapons.Add("Wakizashi");
            Weapons.Add("Daikyu");
            Weapons.Add("Hankyu");
            lb_AvailableList.Items.Clear();
            foreach (string s in Weapons)
            {
                lb_AvailableList.Items.Add(s);
            }
        }

        private void btn_LearnProfSpec_Click(object sender, EventArgs e)
        {
            if (lb_ProficientList.Text.Contains("Daikyu") || lb_ProficientList.Text.Contains("Hankyu") || lb_ProficientList.Text.Contains("Bow"))
            {
                if (weaponProf > 0 && weaponProf - 3 >= 0)
                {
                    weaponProf -= 3;
                    //lb_AvailablePointsValue.Text = weaponProf.ToString();
                    lb_SpecializationList.Items.Add(lb_ProficientList.Text);
                    lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                }
            }
            else
            {
                if (weaponProf > 0 && weaponProf - 2 >= 0)
                {
                    weaponProf -= 2;
                   // lb_AvailablePointsValue.Text = weaponProf.ToString();
                    lb_SpecializationList.Items.Add(lb_ProficientList.Text);
                    lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                }
            }
        }

        private void btn_ForgetAvProf_Click(object sender, EventArgs e)
        {
            if (lb_ProficientList.Text.Contains("Daikyu") || lb_ProficientList.Text.Contains("Hankyu") || lb_ProficientList.Text.Contains("Bow"))
            {
                weaponProf += 3;
                //lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                lb_AvailableList.Items.Add(lb_ProficientList.Text);
            }
            else
            {
                weaponProf += 2;
               // lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                lb_AvailableList.Items.Add(lb_ProficientList.Text);
            }

        }
        private void btn_ForgetProfSpec_Click(object sender, EventArgs e)
        {
            if (lb_SpecializationList.Text.Contains("Daikyu") || lb_SpecializationList.Text.Contains("Hankyu") || lb_SpecializationList.Text.Contains("Bow"))
            {
                weaponProf += 3;
               // lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_SpecializationList.Items.Remove(lb_SpecializationList.Text);
                lb_ProficientList.Items.Add(lb_SpecializationList.Text);
            }
            else
            {
                weaponProf += 2;
                //lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_SpecializationList.Items.Remove(lb_SpecializationList.Text);
                lb_ProficientList.Items.Add(lb_SpecializationList.Text);
            }
        }
        #endregion

        #region Thief

        void AdjustThiefSkills()
        {
            switch (player.CharacterRace)
            {
                case 2://elf
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.DN, player.Skills.GetValue(ThiefSkills.Skills.DN) + 5);
                    break;
                case 3://dwarf
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.CW, player.Skills.GetValue(ThiefSkills.Skills.CW) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.RL, player.Skills.GetValue(ThiefSkills.Skills.RL) - 5);
                    break;
                case 4://gnome
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.DN, player.Skills.GetValue(ThiefSkills.Skills.DN) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.CW, player.Skills.GetValue(ThiefSkills.Skills.CW) - 15);
                    break;
                case 5://halfling
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.DN, player.Skills.GetValue(ThiefSkills.Skills.DN) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.CW, player.Skills.GetValue(ThiefSkills.Skills.CW) - 15);
                    player.Skills.SetValues(ThiefSkills.Skills.RL, player.Skills.GetValue(ThiefSkills.Skills.RL) - 5);
                    break;
                case 6://half-elf
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    break;

            }

            switch (player.CharacterStats.Initial_Dex)
            {
                case 9:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) - 15);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 20);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) - 10);
                    break;
                case 10:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 15);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) - 5);
                    break;
                case 11:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) - 5);
                    break;
                case 12:
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 5);
                    break;
                case 16:
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    break;
                case 17:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    break;
                case 18:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 10);
                    break;
                case 19:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 20);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 15);
                    break;
            }
            initial_cw = player.Skills.GetValue(ThiefSkills.Skills.CW);
            initial_dn = player.Skills.GetValue(ThiefSkills.Skills.DN);
            initial_frt = player.Skills.GetValue(ThiefSkills.Skills.FRT);
            initial_hs = player.Skills.GetValue(ThiefSkills.Skills.HS);
            initial_ms = player.Skills.GetValue(ThiefSkills.Skills.MS);
            initial_ol = player.Skills.GetValue(ThiefSkills.Skills.OL);
            initial_pp = player.Skills.GetValue(ThiefSkills.Skills.PP);
            initial_rl = player.Skills.GetValue(ThiefSkills.Skills.RL);

            ud_CW.Value = initial_cw;
            ud_CW.Maximum = initial_cw + 30;
            ud_CW.Minimum = initial_cw;

            ud_DN.Value = initial_dn;
            ud_DN.Maximum = initial_dn + 30;
            ud_DN.Minimum = initial_dn;

            ud_FRT.Value = initial_frt;
            ud_FRT.Maximum = initial_frt + 30;
            ud_FRT.Minimum = initial_frt;

            ud_HS.Value = initial_hs;
            ud_HS.Maximum = initial_hs + 30;
            ud_HS.Minimum = initial_hs;

            ud_MS.Value = initial_ms;
            ud_MS.Maximum = initial_ms + 30;
            ud_MS.Minimum = initial_ms;

            ud_OL.Value = initial_ol;
            ud_OL.Maximum = initial_ol + 30;
            ud_OL.Minimum = initial_ol;

            ud_PP.Value = initial_pp;
            ud_PP.Maximum = initial_pp + 30;
            ud_PP.Minimum = initial_pp;

            ud_RL.Value = initial_rl;
            ud_RL.Maximum = initial_rl + 30;
            ud_RL.Minimum = initial_rl;
        }
        private void btn_reset_Clicked(object sender, EventArgs e)
        {
            ud_CW.Value = initial_cw;
            ud_CW.Maximum = initial_cw + 30;
            ud_CW.Minimum = initial_cw;

            ud_DN.Value = initial_dn;
            ud_DN.Maximum = initial_dn + 30;
            ud_DN.Minimum = initial_dn;

            ud_FRT.Value = initial_frt;
            ud_FRT.Maximum = initial_frt + 30;
            ud_FRT.Minimum = initial_frt;

            ud_HS.Value = initial_hs;
            ud_HS.Maximum = initial_hs + 30;
            ud_HS.Minimum = initial_hs;

            ud_MS.Value = initial_ms;
            ud_MS.Maximum = initial_ms + 30;
            ud_MS.Minimum = initial_ms;

            ud_OL.Value = initial_ol;
            ud_OL.Maximum = initial_ol + 30;
            ud_OL.Minimum = initial_ol;

            ud_PP.Value = initial_pp;
            ud_PP.Maximum = initial_pp + 30;
            ud_PP.Minimum = initial_pp;

            ud_RL.Value = initial_rl;
            ud_RL.Maximum = initial_rl + 30;
            ud_RL.Minimum = initial_rl;

            pool = 60;
            lb_PointsPool.Text = pool.ToString();

            player.Skills.SetValues(ThiefSkills.Skills.OL, initial_ol);
            player.Skills.SetValues(ThiefSkills.Skills.HS, initial_hs);
            player.Skills.SetValues(ThiefSkills.Skills.CW, initial_cw);
            player.Skills.SetValues(ThiefSkills.Skills.MS, initial_ms);
            player.Skills.SetValues(ThiefSkills.Skills.PP, initial_pp);
            player.Skills.SetValues(ThiefSkills.Skills.RL, initial_rl);
            player.Skills.SetValues(ThiefSkills.Skills.FRT, initial_frt);
            player.Skills.SetValues(ThiefSkills.Skills.DN, initial_dn);
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            showingWeaponProf = true;
            ShowWeaponProf(player.CharacterClass);
        }

        private void ud_PP_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_PP.Value - player.Skills.GetValue(ThiefSkills.Skills.PP) > 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_PP.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_PP.Value);
                }
            }
        }

        private void ud_OL_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_OL.Value - player.Skills.GetValue(ThiefSkills.Skills.OL) > 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.OL, (int)ud_OL.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_OL.Value);
                }
            }
        }

        private void ud_DN_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_DN.Value - player.Skills.GetValue(ThiefSkills.Skills.DN) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_DN.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_DN.Value);
                }
            }
        }

        private void ud_CW_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_CW.Value - player.Skills.GetValue(ThiefSkills.Skills.CW) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.CW, (int)ud_CW.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.CW, (int)ud_CW.Value);
                }
            }

        }

        private void ud_RL_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_RL.Value - player.Skills.GetValue(ThiefSkills.Skills.RL) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.RL, (int)ud_RL.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_RL.Value);
                }
            }
        }

        private void ud_HS_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_HS.Value - player.Skills.GetValue(ThiefSkills.Skills.HS) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.HS, (int)ud_HS.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_HS.Value);
                }
            }

        }

        private void ud_MS_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_MS.Value - player.Skills.GetValue(ThiefSkills.Skills.MS) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.MS, (int)ud_MS.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_MS.Value);
                }
            }
        }

        private void ud_FRT_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_FRT.Value - player.Skills.GetValue(ThiefSkills.Skills.FRT) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, (int)ud_FRT.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_FRT.Value);
                }
            }

        }

       
        #endregion

        #region Priest
        void InitialConfig_Priest()
        {
            ShowPriestInfo();

            foreach (Spell s in DM.AvailableSpells_Priest)
            {
                lb_AvailablePriestSpells.Items.Add(s.Name);
            }
        }
        private void btn_AddSpellP_Click(object sender, EventArgs e)
        {
            if (player.CharacterStats.NumMaxSpellsPerLevel > lb_PriestSpellBook.Items.Count)
            {
                try
                {
                    lb_PriestSpellBook.Items.Add(lb_AvailablePriestSpells.SelectedItem);
                    lb_AvailablePriestSpells.Items.Remove(lb_AvailablePriestSpells.Text);
                    ShowPriestInfo();
                }
                catch
                {
                    lb_PriestInfoText.Text = "No spell selected";
                }
            }

        }

        private void btn_ConfirmProf_Click(object sender, EventArgs e)
        {
            if(showingWeaponProf)
            {
                showingWeaponProf = false;
                ShowNonWeapProf(player.CharacterClass);
            }
            else
            {
                //continue game
            }
        }

        private void btn_RemoveSpellP_Click(object sender, EventArgs e)
        {
            try
            {
                lb_AvailablePriestSpells.Items.Add(lb_PriestSpellBook.SelectedItem);
                lb_PriestSpellBook.Items.Remove(lb_PriestSpellBook.SelectedItem);
                ShowPriestInfo();
            }
            catch
            {
                lb_PriestInfoText.Text = "No spell selected";
            }
        }
        private void btn_confirmPriest_Click(object sender, EventArgs e)
        {
            showingWeaponProf = true;
            ShowWeaponProf(player.CharacterClass);
        }

        private void lb_AvailablePriestSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("player first name = " + player.FirstName);
            foreach (Spell s in DM.AvailableSpells_Priest)
            {
                if (s.Name == lb_AvailablePriestSpells.Text)
                {
                    lb_SelectedSpellDescription.Text = "";
                    lb_SelectedSpellDescription.Text = String.Format("Spell Description: {0}", s.Description);
                    break;
                }
            }

            if (player.CharacterStats.NumMaxSpellsPerLevel == lb_PriestSpellBook.Items.Count)
            {
                btn_confirmPriest.Enabled = true;
                btn_AddSpellP.Enabled = false;
            }
            else
            {
                btn_confirmPriest.Enabled = false;
                btn_AddSpellP.Enabled = true;
            }
        }

        private void lb_PriestSpellBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Spell s in DM.AvailableSpells_Priest)
            {
                if (s.Name == lb_PriestSpellBook.Text)
                {
                    lb_SelectedSpellDescSpellbook.Text = "";
                    lb_SelectedSpellDescSpellbook.Text = String.Format("Spell Description: {0}", s.Description);
                    break;
                }
            }
        }

        #endregion

        #region Mage
        void InitialConfig_Mage()
        {
            lb_MageInfoText.Text = "Select spells.. blah blah" + "\n Remaining slots: " + player.CharacterStats.NumMaxSpellsPerLevel;
            for(int i = 0; i < DM.AvailableSpells_Mage.Count; i++)
            {
                lb_AvailableSpells.Items.Add(DM.AvailableSpells_Mage[i].Name);
            }
        }
        private void btn_ConfirmMage_Click(object sender, EventArgs e)
        {
            showingWeaponProf = true;
            ShowWeaponProf(player.CharacterClass);
        }
        private void btn_RemoveSpellM_Click(object sender, EventArgs e)
        {
            try
            {
                lb_AvailableSpells.Items.Add(lb_MageSpellBook.SelectedItem);
                lb_MageSpellBook.Items.Remove(lb_MageSpellBook.SelectedItem);
                ShowMageInfo();
            }
            catch
            {
                lb_MageInfoText.Text = "No spell selected";
            }
        }

        private void btn_AddSpellM_Click(object sender, EventArgs e)
        {
            if (player.CharacterStats.NumMaxSpellsPerLevel > lb_MageSpellBook.Items.Count)
            {
                try
                {
                    lb_MageSpellBook.Items.Add(lb_AvailableSpells.SelectedItem);
                    lb_AvailableSpells.Items.Remove(lb_AvailableSpells.Text);
                    ShowMageInfo();
                }
                catch
                {
                    lb_MageInfoText.Text = "No spell selected";
                }
            }
        }

        private void lb_AvailableSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_MageSpellBook.Items.Count >= player.CharacterStats.NumMaxSpellsPerLevel)
            {
                btn_ConfirmMage.Enabled = true;
                btn_AddSpellM.Enabled = false;
            }
            else
            {
                foreach (Spell s in DM.AvailableSpells_Mage)
                {
                    if (s.Name == lb_AvailableSpells.Text)
                    {
                        lb_MageSelectedAvailableSpell.Text = "";
                        lb_MageSelectedAvailableSpell.Text = String.Format("Spell Description: {0}", s.Description);
                        break;
                    }
                }
            }
        }

        private void lb_MageSpellBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("player first name = " + player.FirstName);
            if (lb_MageSpellBook.Items.Count >= player.CharacterStats.NumMaxSpellsPerLevel)
            {
                btn_ConfirmMage.Enabled = true;
                btn_AddSpellM.Enabled = false;
            }
            else
            {
                foreach (Spell s in DM.AvailableSpells_Mage)
                {
                    if (s.Name == lb_MageSpellBook.Text)
                    {
                        lb_MageSelectedSpellBookSpell.Text = "";
                        lb_MageSelectedSpellBookSpell.Text = String.Format("Spell Description: {0}", s.Description);
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
