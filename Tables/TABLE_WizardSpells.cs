using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class TABLE_WizardSpells
    {
        public List<Spell> AvailableSpells_Mage = new List<Spell>();
        public TABLE_WizardSpells()
        {
            CreateSpells_Mage();
        }
        void CreateSpells_Mage()
        {
            List<Items> spellComponents = new List<Items>();

            AvailableSpells_Mage.Add(new Spell("Affect Normal Fires", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Armor", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Audible Glamer", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Burning Hands", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Cantrip", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Change Self", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Charm Person", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Chill Touch", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Color Spray", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Comprehend Languages", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Dancing Lights", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Detect Magic", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Detect Undead", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Enlarge", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Erase", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Feather Fall", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Find Familiar", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Friends", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Gaze Reflection", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Grease", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Hold Portal", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Hypnotism", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Identify", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Jump", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Light", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Magic Missile", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Mending", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Message", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Mount", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Nystul's Magical Aura", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Phantasmal Force", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Protection From Evil", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Read Magic", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Shield", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Shocking Grasp", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Sleep", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Spider Climb", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Spook", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Taunt", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Floating Disc", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Mage.Add(new Spell("Unseen Servant", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
        }

    }
}
