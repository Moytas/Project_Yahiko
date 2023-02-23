using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class TABLE_PriestSpells
    {
        public List<Spell> AvailableSpells_Priest = new List<Spell>();
        public TABLE_PriestSpells()
        {
            CreateSpells_Priest();
        }

        void CreateSpells_Priest()
        {
            List<Items> spellComponents = new List<Items>();
            AvailableSpells_Priest.Add(new Spell("Animal Friendship", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Bless", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Combine", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Command", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Create Water", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Cure Light Wounds", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Detect Evil", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Detect Magic", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Detect Snares & Pits", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Endure Cold/Heat", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Entagle", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Fairie Fire", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Invisibility to Undead", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Invisibility to Animals", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
            AvailableSpells_Priest.Add(new Spell("Light", 1, true, true, true, spellComponents, 1, Spell.SavingThrowEffect.None, "Blah Blah Blah"));
        }
    }
}
