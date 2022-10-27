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
        DMOptions DM = new DMOptions();

        int available;
        string introText;
        string availableText;

        public NonWeapProfPicker(Player player)
        {
            InitializeComponent();
            available = player.NumNonWeaponProf;
            switch(player.CharacterClass)
            {
                default:
                    introText = "Blah blah \n";
                    break;
            }
            availableText = string.Format("Remaining: {0}", available);
            lbl_NonWeapProfsText.Text = introText + availableText;
            PopulateGeneralList();
            PopulateClassList(player.CharacterClass);
        }

        void PopulateGeneralList()
        {
            lb_AvailableNonWeaponGeneral.Items.Clear();
            string proficiencyText;
            foreach(NonWeapProficiency prof in DM.NonWeaponProficiencies)
            {
                if(prof.ProfType == NonWeapProficiency.Type.General)
                {
                    proficiencyText = prof.Modifier >= 0 ? string.Format("{0} {1}+{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier,prof.Cost) : string.Format("{0} {1}{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier,prof.Cost);
                    lb_AvailableNonWeaponGeneral.Items.Add(proficiencyText);
                }
            }
        }

        void PopulateClassList(int charClass)
        {
            lb_AvailableNonWeaponClass.Items.Clear();
            string proficiencyText;
            switch (charClass)
            {
                case 1:
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.Warrior)
                        {
                            proficiencyText = prof.Modifier >= 0 ? string.Format("{0} {1}+{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost) : string.Format("{0} {1}{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost);
                            lb_AvailableNonWeaponClass.Items.Add(proficiencyText);
                        }
                    }
                    break;
                case 2:
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.Thief)
                        {
                            proficiencyText = prof.Modifier >= 0 ? string.Format("{0} {1}+{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost) : string.Format("{0} {1}{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost);
                            lb_AvailableNonWeaponClass.Items.Add(proficiencyText);
                        }
                    }
                    break;
                case 3:
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.Priest)
                        {
                            proficiencyText = prof.Modifier >= 0 ? string.Format("{0} {1}+{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost) : string.Format("{0} {1}{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost);
                            lb_AvailableNonWeaponClass.Items.Add(proficiencyText);
                        }
                    }
                    break;
                case 4:
                    foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
                    {
                        if (prof.ProfType == NonWeapProficiency.Type.Mage)
                        {
                            proficiencyText = prof.Modifier >= 0 ? string.Format("{0} {1}+{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost) : string.Format("{0} {1}{2} Cost:{3}", prof.Name, prof.Ability, prof.Modifier, prof.Cost);
                            lb_AvailableNonWeaponClass.Items.Add(proficiencyText);
                        }
                    }
                    break;
            }
        }

        void UpdateDescription(string desc)
        {
            lbl_Description.Text = "Description: " + desc;
        }

        private void lb_AvailableNonWeaponGeneral_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(NonWeapProficiency prof in DM.NonWeaponProficiencies)
            {
                if(lb_AvailableNonWeaponGeneral.Text.Contains(prof.Name))
                {
                    UpdateDescription(prof.Description);
                    return;
                }
            }
        }

        private void lb_AvailableNonWeaponClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NonWeapProficiency prof in DM.NonWeaponProficiencies)
            {
                if (lb_AvailableNonWeaponClass.Text.Contains(prof.Name))
                {
                    UpdateDescription(prof.Description);
                    return;
                }
            }
        }

        private void btn_AddNonWeaponProf_Click(object sender, EventArgs e)
        {

        }

        private void btn_RemoveLearnedProficiency_Click(object sender, EventArgs e)
        {

        }
    }
}
