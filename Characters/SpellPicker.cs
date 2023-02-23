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
    public partial class SpellPicker : Form
    {
        TABLE_PriestSpells PriestSpells;
        TABLE_WizardSpells WizardSpells;

        int NumOfSpellLeft = 1;

        #region Constructors
        public SpellPicker(Sohei player)
        {
            NumOfSpellLeft = player.CharacterStats.NumMaxSpellsPerLevel;
            InitializeComponent();
            PriestSpells = new TABLE_PriestSpells();
            PopulateSpellList(2);
            ShowRemainingSpellSlots();
        }


        public SpellPicker(Onmyoji player)
        {
            NumOfSpellLeft = player.CharacterStats.NumMaxSpellsPerLevel;
            InitializeComponent();
            WizardSpells = new TABLE_WizardSpells();
            PopulateSpellList(1);
            ShowRemainingSpellSlots();
        }
        #endregion

        #region List
        void PopulateSpellList(int index)
        {
            switch(index)
            {
                case 1: //Wizard
                    foreach(Spell s in WizardSpells.AvailableSpells_Mage)
                    {
                        if(s.Level == 1)
                        {
                            lb_AvailableSpells.Items.Add(s.Name);
                        }
                    }
                    break;
                case 2: //Priest
                    foreach(Spell s in PriestSpells.AvailableSpells_Priest)
                    {
                        if(s.Level == 1)
                        {
                            lb_AvailableSpells.Items.Add(s.Name);
                        }
                    }
                    break;
            }
        }

        private void lb_AvailableSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PriestSpells != null)
            {
                foreach(Spell s in PriestSpells.AvailableSpells_Priest)
                {
                    if(s.Name == lb_AvailableSpells.Text)
                    {
                        lb_SelectedSpellDescription.Text = string.Format("Spell Description: {0}", s.Description);
                        return;
                    }
                }
            }

            if(WizardSpells != null)
            {
                foreach(Spell s in WizardSpells.AvailableSpells_Mage)
                {
                    if(s.Name == lb_AvailableSpells.Text)
                    {
                        lb_SelectedSpellDescription.Text = string.Format("Spell Description: {0}", s.Description);
                        return;
                    }
                }
            }
        }
        #endregion

        #region Labels

        void ShowRemainingSpellSlots()
        {
            lbl_InfoText.Text = string.Format("Remaining spells to learn : {0}", NumOfSpellLeft);
        }


        #endregion
        
        #region Buttons
        private void btn_AddSpellP_Click(object sender, EventArgs e)
        {
            if (NumOfSpellLeft > 0)
            {
                NumOfSpellLeft--;
                lb_SpellBook.Items.Add(lb_AvailableSpells.Text);
                lb_AvailableSpells.Items.Remove(lb_AvailableSpells.Text);
                ShowRemainingSpellSlots();
                if(!btn_Confirm.Enabled)
                {
                    btn_Confirm.Enabled = true;
                }    
            }
        }

        private void btn_RemoveSpellP_Click(object sender, EventArgs e)
        {
            if (lb_SpellBook.Text != "")
            {
                NumOfSpellLeft++;
                lb_AvailableSpells.Items.Add(lb_SpellBook.Text);
                lb_SpellBook.Items.Remove(lb_SpellBook.Text);
                ShowRemainingSpellSlots();
            }
        }
        #endregion
    }
}
