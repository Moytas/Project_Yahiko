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
        Bushi Warrior = new Bushi();
        Shinobi Thief = new Shinobi();
        Sohei Priest = new Sohei();
        Onmyoji Mage = new Onmyoji();

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
        
            introText_Samurai = "The formidable bushi is a true master of weapons...\n";
            introText_Sohei = "Priests in Nippon ..... Walk the path blah blah... Choose spells blah blah\n";
            introText_Shinobi = "A master of shadows, a shinobi's true power is the skills they utilize\n";
            introText_Onmyoji = "The onmyoji is a master of elements, using hand seal techniques while speaking words of power creates magic \n";

            switch (_p.CharacterClass)
            {
                case 1: // warrior
                    try
                    {
                        Warrior = new Bushi(player);
                    }
                    catch
                    {
                        Console.WriteLine("not ok! ");
                    }
                    this.Text = "Bushi specialization";
                    //tabControl1.SelectedTab = tabSamurai;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabShinobi);
                    tabControl1.TabPages.Remove(tabProficiencies);
                    //btn_SamuraiAccept.Enabled = false;
                    PopulateOptionsWeapon();
                    ShowWarriorInfo();
                    break;
                case 2: // thief
                    try
                    {
                        Thief = new Shinobi(player);
                    }
                    catch
                    {
                    }
                    this.Text = "Shinobi skills";
                    tabControl1.SelectedTab = tabShinobi;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                   // tabControl1.TabPages.Remove(tabSamurai);
                    tabControl1.TabPages.Remove(tabProficiencies);
                    AdjustThiefSkills();
                    ShowInfoThiefSkills();
                    break;
                case 3: // priest
                    this.Text = "Sohei spells";
                    try
                    {
                        Priest = new Sohei(player);
                    }
                    catch
                    {
                    }
                    tabControl1.SelectedTab = tabMonk;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabShinobi);
                    //tabControl1.TabPages.Remove(tabSamurai);
                    tabControl1.TabPages.Remove(tabProficiencies);
                    InitialConfig_Priest();
                    break;
                case 4: // mage
                    this.Text = "Onmyoji spells";
                    try
                    {
                        Mage = new Onmyoji(player);
                    }
                    catch
                    {
                    }
                    tabControl1.SelectedTab = tabMage;
                    tabControl1.TabPages.Remove(tabProficiencies);
                    tabControl1.TabPages.Remove(tabShinobi);
                    tabControl1.TabPages.Remove(tabMonk);
                    //tabControl1.TabPages.Remove(tabSamurai);
                    InitialConfig_Mage();
                    break;
            }
        } //CONSTRUCTOR

        #region Texts
        private void ShowInfoThiefSkills()
        {
            lb_ShinobiIntroText.Text = introText_Shinobi;
            lb_PointsPool.Text = "60";
            btn_ThiefAccept.Enabled = false;
        }
        private void ShowPriestInfo()
        {
            lb_PriestInfoText.Text = "";
            if (Priest.CharacterStats.NumMaxSpellsPerLevel != 100)
            {
                if(Priest.CharacterStats.NumMaxSpellsPerLevel == 0)
                {
                    Priest.CharacterStats.NumMaxSpellsPerLevel = 1;
                }
                lb_PriestInfoText.Text = introText_Sohei + String.Format("Remaining spells: {0}", Priest.CharacterStats.NumMaxSpellsPerLevel - lb_PriestSpellBook.Items.Count);
            }
            else
            {
                lb_PriestInfoText.Text = introText_Sohei + String.Format("Remaining spells: {0}", lb_AvailablePriestSpells.Items.Count);
            }
        }

        private void ShowWarriorInfo()
        {
            //lb_SamuraiIntroText.Text = introText_Samurai + "Remaining Weapon Proficiencies: " + player.NumWeaponProf;
        }

        private void ShowMageInfo()
        {
            lb_MageInfoText.Text = "";
            lb_MageInfoText.Text = introText_Onmyoji + String.Format("Remaining spells: {0}", player.CharacterStats.NumMaxSpellsPerLevel - lb_MageSpellBook.Items.Count);
        }

        void ShowRemainingWeaponProf()
        {
            lb_NonWeapProfsText.Text = string.Format("Remaining Weapon Proficiencies: {0}", player.NumWeaponProf);
        }

        void ShowText_NonWeaponProficiencies()
        {
            lb_NonWeapProfsText.Text = string.Format("Remaining Non Weapon Proficiencies: {0}", player.NumNonWeaponProf);
        }
        #endregion

        #region Proficiencies
        void ShowProficienciesTab()
        {
            if (!tabControl1.Controls.Contains(tabProficiencies))
            {
                tabControl1.TabPages.Add(tabProficiencies);
            }

            tabControl1.SelectedTab = tabProficiencies;
            
            foreach (TabPage t in tabControl1.TabPages)
            {
                if (t != tabProficiencies)
                {
                    tabControl1.TabPages.Remove(t);
                }
            }
            if (lb_AvailableNonWeaponList.Items.Count > 0)
            {
                lb_AvailableNonWeaponList.Items.Clear();
            }

            if(lb_LearnedProficienies.Items.Count > 0)
            {
                lb_LearnedProficienies.Items.Clear();
            }

            switch (player.CharacterClass)
            {
                case 1:
                    lb_NonWeapProfsText.Text = "The bushi can learn the following skills..\nAvailable Non Weapon Proficiencies: " + player.NumNonWeaponProf;
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.General || prof.ProfType == NonWeapProficiency.Type.Warrior)
                        {
                            lb_AvailableNonWeaponList.Items.Add(prof.Name);
                        }
                    }
                    break;
                case 2:
                    lb_NonWeapProfsText.Text = "The shinobi can learn the following skills..\nAvailable Non Weapon Proficiencies: " + player.NumNonWeaponProf;
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
                    if (showingWeaponProf)
                    {
                        this.Text = "A Shinobi's Arsenal";
                        tabControl1.TabPages[0].Text = "Shinobi";
                        lb_NonWeapProfsText.Text = "A Shinobi has a variety of weapons that can be chosen...";
                        foreach (Weapon w in DM.WeaponsList)
                        {
                            lb_AvailableNonWeaponList.Items.Add(w.Name);
                        }

                    }
                    break;
                case 3:
                    if (showingWeaponProf)
                    {
                        this.Text = "A Sohei's Arsenal";
                        tabControl1.TabPages[0].Text = "Sohei";
                        lb_NonWeapProfsText.Text = "A Sohei has a variety of weapons that can be chosen...";
                        foreach (Weapon w in DM.WeaponsList)
                        {
                            if (w.WeaponType.Contains(Weapon.DamageType.Bludgeoning) && w.WeaponType.Count >= 1)
                            {
                                lb_AvailableNonWeaponList.Items.Add(w.Name);
                            }
                        }
                        btn_RemoveLearnedProficiency.Enabled = false;
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
                                lb_AvailableNonWeaponList.Items.Add(w.Name);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("oops");
                    }
                    break;
            }
            if (!tabControl1.Controls.Contains(tabProficiencies))
            {
                tabControl1.Controls.Add(tabProficiencies);
            }
            foreach (TabPage tab in tabControl1.Controls)
            {
                if (tab != tabProficiencies)
                {
                    tabControl1.TabPages.Remove(tab);
                }
            }
            tabControl1.SelectedTab = tabProficiencies;

        }

        private void btn_RemoveLearnedProficiency_Click(object sender, EventArgs e)
        {
            btn_AddNonWeaponProf.Enabled = true;
        }

        private void lb_AvailableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddNonWeaponProf_Click(object sender, EventArgs e)
        {
            if (showingWeaponProf)
            {
                foreach (Weapon w in DM.WeaponsList)
                {
                    if (w.Name == lb_AvailableNonWeaponList.SelectedItem)
                    {
                        if(Thief.FirstName != null)
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
            else
            {
                foreach (NonWeapProficiency p in DM.NonWeaponProficiencies)
                {
                    if (p.Name == lb_AvailableNonWeaponList.Text)
                    {
                        if (player.NumNonWeaponProf - p.Cost >= 0)
                        {
                            player.NumNonWeaponProf -= p.Cost;
                            lb_LearnedProficienies.Items.Add(lb_AvailableNonWeaponList.Text);
                            lb_AvailableNonWeaponList.Items.Remove(lb_AvailableNonWeaponList.SelectedItem);
                            if(player.NumNonWeaponProf == 0)
                            {
                                btn_ConfirmProf.Enabled = true;
                                btn_AddNonWeaponProf.Enabled = false;
                            }
                        }
                    }
                }

                ShowText_NonWeaponProficiencies();
            }
        }
        private void lb_AvailableNonWeaponList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NonWeapProficiency p in DM.NonWeaponProficiencies)
            {
                if (p.Name == lb_AvailableNonWeaponList.Text)
                {
                    lb_SelectedProfDescription_L.Text = "Description: " + p.Description;
                }
            }
        }

        private void btn_ConfirmProf_Click(object sender, EventArgs e)
        {
            if (showingWeaponProf)
            {
                showingWeaponProf = false;
                if (Thief.FirstName == player.FirstName)
                {
                    for (int i = 0; i < lb_LearnedProficienies.Items.Count; i++)
                    {
                        //Thief.WeaponProf.Add(new WeaponProficiency(lb_LearnedProficienies.Items[i].ToString()));
                    }
                }
                else if (Warrior.FirstName == player.FirstName)
                {
                    for (int i = 0; i < lb_LearnedProficienies.Items.Count; i++)
                    {
                       // Warrior.WeaponProf.Add(new WeaponProficiency(lb_LearnedProficienies.Items[i].ToString()));
                    }
                }
                else if (Mage.FirstName == player.FirstName)
                {
                    for (int i = 0; i < lb_LearnedProficienies.Items.Count; i++)
                    {
                       // Mage.WeaponProf.Add(new WeaponProficiency(lb_LearnedProficienies.Items[i].ToString()));
                    }
                }
                else if (Priest.FirstName == player.FirstName)
                {
                    for (int i = 0; i < lb_LearnedProficienies.Items.Count; i++)
                    {
                        //Priest.WeaponProf.Add(new WeaponProficiency(lb_LearnedProficienies.Items[i].ToString()));
                    }
                }
                ShowProficienciesTab();
                btn_ConfirmProf.Enabled = false;
            }
            else
            {
                if(Warrior.FirstName == player.FirstName)
                {
                    for(int i = 0; i < lb_LearnedProficienies.Items.Count; i++)
                    {
                        foreach(NonWeapProficiency prof in DM.NonWeaponProficiencies)
                        {
                            if(prof.Name == lb_LearnedProficienies.Items[i].ToString())
                            {
                                Warrior.NonWeaponProf.Add(prof);
                                break;
                            }
                        }
                    }
                }
                else if (Thief.FirstName == player.FirstName)
                {
                    for (int i = 0; i < lb_LearnedProficienies.Items.Count; i++)
                    {
                        foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                        {
                            if (prof.Name == lb_LearnedProficienies.Items[i].ToString())
                            {
                                Thief.NonWeaponProf.Add(prof);
                                break;
                            }
                        }
                    }
                }
                else if (Priest.FirstName == player.FirstName)
                {

                }
                else if (Mage.FirstName == player.FirstName)
                {

                }

                //continue game
                Console.WriteLine("Continue game?");
            }
        }
        #endregion

        #region Warrior
        private void ShowWeaponText() //Updates/shows the remaining weapon proficiencies for warrior
        {
            //lb_SamuraiIntroText.Text = introText_Samurai + "Remaining proficiencies: " + player.NumWeaponProf;
        }
        private void btn_SamuraiAccept_Click(object sender, EventArgs e)
        {
            /*
            if(lb_SpecializationList.Items.Count > 0)
            {
                foreach(Weapon w in DM.WeaponsList)
                {
                    if(w.Name == lb_SpecializationList.Items[0].ToString())
                    {
                        Warrior.WeaponSpecialization = new WeaponProficiency(w.Name);
                        break;
                    }
                }
            }

            for(int i =0; i < lb_ProficientList.Items.Count; i++)
            {
                Warrior.WeaponProf.Add(new WeaponProficiency(lb_ProficientList.Items[i].ToString()));
            }
            */
            showingWeaponProf = false;
            ShowProficienciesTab();
        }
        void PopulateOptionsWeapon()
        {
            // Katana / Bokken * Ninja - to * No - daichi * Tetsu - to * Tanto / Yoroi - toshi * Wakizashi *
           foreach(Weapon w in DM.WeaponsList)
            {
                //lb_AvailableList.Items.Add(w.Name);
            }
        }
        private void btn_LearnAvProf_Clicked(object sender, EventArgs e) //add from available weapon list to specialized
        {
            /*
            if (lb_AvailableList.Text.Contains("Daikyu") || lb_AvailableList.Text.Contains("Hankyu") || lb_AvailableList.Text.Contains("Bow"))
            {

                if (player.NumWeaponProf > 0 && player.NumWeaponProf - 2 >= 0)
                {
                    player.NumWeaponProf -= 2;
                    lb_SamuraiIntroText.Text = weaponProf.ToString();
                    lb_ProficientList.Items.Add(lb_AvailableList.SelectedItem);
                    lb_AvailableList.Items.Remove(lb_AvailableList.Text);
                }
            }
            else
            {
                if (player.NumWeaponProf > 0 && player.NumWeaponProf - 1 >= 0)
                {
                    player.NumWeaponProf -= 1;
                    lb_SamuraiIntroText.Text = weaponProf.ToString();
                    lb_ProficientList.Items.Add(lb_AvailableList.SelectedItem);
                    lb_AvailableList.Items.Remove(lb_AvailableList.Text);
                }
            }
            if(player.NumWeaponProf == 0)
            {
                //btn_SamuraiAccept.Enabled = true;
               // btn_LearnProfSpec.Enabled = false;
              //  btn_LearnAvProf.Enabled = false;
            }
            */
            ShowWeaponText();
        }
        private void btn_LearnProfSpec_Click(object sender, EventArgs e)
        {
            /*
            if (lb_ProficientList.Text.Contains("Daikyu") || lb_ProficientList.Text.Contains("Hankyu") || lb_ProficientList.Text.Contains("Bow"))
            {
                if (player.NumWeaponProf > 0 && player.NumWeaponProf - 3 >= 0)
                {
                    player.NumWeaponProf -= 3;
                    //lb_AvailablePointsValue.Text = weaponProf.ToString();
                    lb_SpecializationList.Items.Add(lb_ProficientList.Text);
                    lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                }
            }
            else
            {
                if (player.NumWeaponProf > 0 && player.NumWeaponProf - 2 >= 0)
                {
                    player.NumWeaponProf -= 2;
                   // lb_AvailablePointsValue.Text = weaponProf.ToString();
                    lb_SpecializationList.Items.Add(lb_ProficientList.Text);
                    lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                }
            }
            if (player.NumWeaponProf == 0)
            {
                btn_SamuraiAccept.Enabled = true;
                btn_LearnAvProf.Enabled = false;
                btn_LearnProfSpec.Enabled = false;
            }
            */
            ShowWeaponText();
        }

        private void btn_ForgetAvProf_Click(object sender, EventArgs e) // Unlearn from specialized add to available weapon
        {
            /*
            if (lb_ProficientList.Text.Contains("Daikyu") || lb_ProficientList.Text.Contains("Hankyu") || lb_ProficientList.Text.Contains("Bow"))
            {
                player.NumWeaponProf += 3;
                //lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                lb_AvailableList.Items.Add(lb_ProficientList.Text);
            }
            else
            {
                player.NumWeaponProf += 2;
               // lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_ProficientList.Items.Remove(lb_ProficientList.Text);
                lb_AvailableList.Items.Add(lb_ProficientList.Text);
            }

            if(player.NumWeaponProf > 0)
            {
                btn_LearnAvProf.Enabled = true;
                btn_LearnProfSpec.Enabled = true;
                btn_SamuraiAccept.Enabled = false;
            }
            */
            ShowWeaponText();
        }

       

        private void lb_LearnedProficienies_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NonWeapProficiency p in DM.NonWeaponProficiencies)
            {
                if (p.Name == lb_LearnedProficienies.Text)
                {
                    lb_SelectedProfDescription_R.Text = "Description: " + p.Description;
                }
            }

        }

        private void btn_ForgetProfSpec_Click(object sender, EventArgs e)
        {
            /*
            if (lb_SpecializationList.Text.Contains("Daikyu") || lb_SpecializationList.Text.Contains("Hankyu") || lb_SpecializationList.Text.Contains("Bow"))
            {
                player.NumWeaponProf += 3;
               // lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_SpecializationList.Items.Remove(lb_SpecializationList.Text);
                lb_ProficientList.Items.Add(lb_SpecializationList.Text);
            }
            else
            {
                player.NumWeaponProf += 2;
                //lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_SpecializationList.Items.Remove(lb_SpecializationList.Text);
                lb_ProficientList.Items.Add(lb_SpecializationList.Text);
            }
            if (player.NumWeaponProf > 0)
            {
                btn_LearnAvProf.Enabled = true;
                btn_LearnProfSpec.Enabled = true;
                btn_SamuraiAccept.Enabled = false;
            }
            */
            ShowWeaponText();
        }
        #endregion

        #region Thief

        void AdjustThiefSkills()
        {
            switch (player.CharacterRace)
            {
                case 2://elf
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) - 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, Thief.Skills.GetValue(ThiefSkills.Skills.DN) + 5);
                    break;
                case 3://dwarf
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) + 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.CW, Thief.Skills.GetValue(ThiefSkills.Skills.CW) - 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.RL, Thief.Skills.GetValue(ThiefSkills.Skills.RL) - 5);
                    break;
                case 4://gnome
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, Thief.Skills.GetValue(ThiefSkills.Skills.DN) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.CW, Thief.Skills.GetValue(ThiefSkills.Skills.CW) - 15);
                    break;
                case 5://halfling
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, Thief.Skills.GetValue(ThiefSkills.Skills.DN) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.CW, Thief.Skills.GetValue(ThiefSkills.Skills.CW) - 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.RL, Thief.Skills.GetValue(ThiefSkills.Skills.RL) - 5);
                    break;
                case 6://half-elf
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    break;

            }

            switch (player.CharacterStats.Initial_Dex)
            {
                case 9:
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) - 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) - 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) - 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) - 20);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) - 10);
                    break;
                case 10:
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) - 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) - 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) - 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) - 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) - 5);
                    break;
                case 11:
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) - 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) - 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) - 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) - 5);
                    break;
                case 12:
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) - 5);
                    break;
                case 16:
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    break;
                case 17:
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    break;
                case 18:
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) + 5);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 10);
                    break;
                case 19:
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, Thief.Skills.GetValue(ThiefSkills.Skills.PP) + 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, Thief.Skills.GetValue(ThiefSkills.Skills.OL) + 20);
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, Thief.Skills.GetValue(ThiefSkills.Skills.FRT) + 10);
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, Thief.Skills.GetValue(ThiefSkills.Skills.MS) + 15);
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, Thief.Skills.GetValue(ThiefSkills.Skills.HS) + 15);
                    break;
            }
            initial_cw = Thief.Skills.GetValue(ThiefSkills.Skills.CW);
            initial_dn = Thief.Skills.GetValue(ThiefSkills.Skills.DN);
            initial_frt = Thief.Skills.GetValue(ThiefSkills.Skills.FRT);
            initial_hs = Thief.Skills.GetValue(ThiefSkills.Skills.HS);
            initial_ms = Thief.Skills.GetValue(ThiefSkills.Skills.MS);
            initial_ol = Thief.Skills.GetValue(ThiefSkills.Skills.OL);
            initial_pp = Thief.Skills.GetValue(ThiefSkills.Skills.PP);
            initial_rl = Thief.Skills.GetValue(ThiefSkills.Skills.RL);

            ud_CW.Value = initial_cw;
            ud_CW.Maximum = ud_CW.Value + 30;
            ud_CW.Minimum = ud_CW.Value;

            ud_DN.Value = initial_dn;
            ud_DN.Maximum = ud_DN.Value + 30;
            ud_DN.Minimum = ud_DN.Value;

            ud_FRT.Value = initial_frt;
            ud_FRT.Maximum = ud_FRT.Value + 30;
            ud_FRT.Minimum = ud_FRT.Value;

            ud_HS.Value = initial_hs;
            ud_HS.Maximum = ud_HS.Value + 30;
            ud_HS.Minimum = ud_HS.Value;

            ud_MS.Value = initial_ms;
            ud_MS.Maximum = ud_MS.Value + 30;
            ud_MS.Minimum = ud_MS.Value;

            ud_OL.Value = initial_ol;
            ud_OL.Maximum = ud_OL.Value + 30;
            ud_OL.Minimum = ud_OL.Value;

            ud_PP.Value = initial_pp;
            ud_PP.Maximum = ud_PP.Value + 30;
            ud_PP.Minimum = ud_PP.Value;

            ud_RL.Value = initial_rl;
            ud_RL.Maximum = ud_RL.Value + 30;
            ud_RL.Minimum = ud_RL.Value;
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

            Thief.Skills.SetValues(ThiefSkills.Skills.OL, initial_ol);
            Thief.Skills.SetValues(ThiefSkills.Skills.HS, initial_hs);
            Thief.Skills.SetValues(ThiefSkills.Skills.CW, initial_cw);
            Thief.Skills.SetValues(ThiefSkills.Skills.MS, initial_ms);
            Thief.Skills.SetValues(ThiefSkills.Skills.PP, initial_pp);
            Thief.Skills.SetValues(ThiefSkills.Skills.RL, initial_rl);
            Thief.Skills.SetValues(ThiefSkills.Skills.FRT, initial_frt);
            Thief.Skills.SetValues(ThiefSkills.Skills.DN, initial_dn);
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            showingWeaponProf = true;
            ShowWeaponProf(player.CharacterClass);
        }

        private void ud_PP_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
            if (pool - 1 > 0)
            {
                if (ud_PP.Value - Thief.Skills.GetValue(ThiefSkills.Skills.PP) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_PP.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_PP.Value);
                }
            }
            else
            {
                lb_PointsPool.Text = "0";
                ud_PP.Maximum = ud_PP.Value;
                btn_ThiefAccept.Enabled = true;
            }
        }

        private void ud_OL_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
           
            if (pool - 1 > 0)
            {
                if (ud_OL.Value - Thief.Skills.GetValue(ThiefSkills.Skills.OL) > 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.OL, (int)ud_OL.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_OL.Value);
                }
            }
            else
            {
                lb_PointsPool.Text = "0";
                ud_OL.Maximum = ud_OL.Value;
                btn_ThiefAccept.Enabled = true;
            }
        }

        private void ud_DN_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
           
            if (pool - 1 > 0)
            {
                if (ud_DN.Value - Thief.Skills.GetValue(ThiefSkills.Skills.DN) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_DN.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_DN.Value);
                }
            }
            else
            {
                ud_DN.Maximum = ud_DN.Value;
                btn_ThiefAccept.Enabled = true;
            }
        }

        private void ud_CW_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
            
            if (pool - 1 > 0)
            {
                if (ud_CW.Value - Thief.Skills.GetValue(ThiefSkills.Skills.CW) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.CW, (int)ud_CW.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.CW, (int)ud_CW.Value);
                }
            }
            else
            {
                ud_CW.Maximum = ud_CW.Value;
                btn_ThiefAccept.Enabled = true;
            }

        }

        private void ud_RL_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
            
            if (pool - 1 > 0)
            {
                if (ud_RL.Value - Thief.Skills.GetValue(ThiefSkills.Skills.RL) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.RL, (int)ud_RL.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_RL.Value);
                }
            }
            else
            {
                ud_RL.Maximum = ud_RL.Value;
                btn_ThiefAccept.Enabled = true;
            }
        }

        private void ud_HS_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
            
            if (pool - 1 > 0)
            {
                if (ud_HS.Value - Thief.Skills.GetValue(ThiefSkills.Skills.HS) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.HS, (int)ud_HS.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_HS.Value);
                }
            }
            else
            {
                ud_HS.Maximum = ud_HS.Value;
                btn_ThiefAccept.Enabled = true;
            }

        }

        private void ud_MS_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
            

            if (pool - 1 > 0)
            {
                if (ud_MS.Value - Thief.Skills.GetValue(ThiefSkills.Skills.MS) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.MS, (int)ud_MS.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_MS.Value);
                }
            }
            else
            {
                ud_MS.Maximum = ud_MS.Value;
                btn_ThiefAccept.Enabled = true;
            }
        }

        private void ud_FRT_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(lb_PointsPool.Text, out pool);
            
            if (pool - 1 > 0)
            {
                if (ud_FRT.Value - Thief.Skills.GetValue(ThiefSkills.Skills.FRT) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.FRT, (int)ud_FRT.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    Thief.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_FRT.Value);
                }
            }
            else
            {
                ud_FRT.Maximum = ud_FRT.Value;
                btn_ThiefAccept.Enabled = true;
            }

        }

       
        #endregion

        #region Priest
        void InitialConfig_Priest()
        {
            ShowPriestInfo();
            btn_RemoveSpellP.Enabled = false;
            foreach (Spell s in DM.AvailableSpells_Priest)
            {
                lb_AvailablePriestSpells.Items.Add(s.Name);
            }
        }
        private void btn_AddSpellP_Click(object sender, EventArgs e)
        {
            if (Priest.CharacterStats.NumMaxSpellsPerLevel > lb_PriestSpellBook.Items.Count && lb_AvailablePriestSpells.Items.Count > 0)
            {
                if(lb_PriestSpellBook.Items.Count > 0)
                {
                    btn_RemoveSpellP.Enabled = true;
                }
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
            else 
            {
                if (Priest.CharacterStats.NumMaxSpellsPerLevel == lb_PriestSpellBook.Items.Count || lb_AvailablePriestSpells.Items.Count == 0)
                {
                    btn_AddSpellP.Enabled = false;
                    btn_RemoveSpellP.Enabled = true;
                    btn_confirmPriest.Enabled = true;
                }
            }

        }

        private void lb_FRT_Click(object sender, EventArgs e)
        {

        }

        private void lb_ShinobiIntroText_Click(object sender, EventArgs e)
        {

        }

        private void lb_RL_Click(object sender, EventArgs e)
        {

        }

        private void lb_HS_Click(object sender, EventArgs e)
        {

        }

        private void lb_PointsPool_Click(object sender, EventArgs e)
        {

        }

        private void lb_PP_Click(object sender, EventArgs e)
        {

        }

        private void lb_CW_Click(object sender, EventArgs e)
        {

        }

        private void lb_DN_Click(object sender, EventArgs e)
        {

        }

        private void lb_MS_Click(object sender, EventArgs e)
        {

        }

        private void lb_OL_Click(object sender, EventArgs e)
        {

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
            btn_confirmPriest.Enabled = true;
            showingWeaponProf = true;
            ShowWeaponProf(Priest.CharacterClass);
        }

        private void lb_AvailablePriestSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
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
