using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class DMOptions
    {

        public DMOptions()
        {
            CreateLastNames();
            CreateNames_Female();
            CreateNames_Male();
            CreateSpells_Mage();
            CreateSpells_Priest();
            PopulateNonWeaponProfLists();
            PopulateWeaponList();
            PopulateWeaponProfList();
        }

        public enum Clans
        {
            Oda,
            Tokugawa,
            Mori,
            Clan1,
            Clan2
        };
        public List<String> ClanNames;

        public void PopulateClanNames()
        {
            ClanNames = new List<string>();
            ClanNames.Add("Oda / Human");
            ClanNames.Add("Tokugawa / Elf");
            ClanNames.Add("Mori / Dwarf");
            ClanNames.Add("Ogami / Gnome");
            ClanNames.Add("Yagyu / Halfling");
            ClanNames.Add("Clanless / Half-Elf");
        }

        public enum PlayableRaces
        {
            Human,
            Elf,
            Dwarf,
            Gnome,
            Halfling,
            Orc
        };

        public enum MonsterRaces
        {
            Orc,
            Human,
            Elf,
            Dwarf,
            Gnome,
            Halfling,
            Dragon,
            Undead
        };

        public int GetXPToNext(int playerClass, int playerLevel)
        {
            int returnValue = 0;
            switch (playerClass)
            {
                case 1:// warrior
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 2000;
                            break;
                        case 2:
                            returnValue = 4000;
                            break;
                        case 3:
                            returnValue = 8000;
                            break;
                        case 4:
                            returnValue = 16000;
                            break;
                        case 5:
                            returnValue = 32000;
                            break;
                        case 6:
                            returnValue = 64000;
                            break;
                        case 7:
                            returnValue = 125000;
                            break;
                        case 8:
                            returnValue = 250000;
                            break;
                        case 9:
                            returnValue = 500000;
                            break;
                        case 10:
                            returnValue = 750000;
                            break;
                        case 11:
                            returnValue = 1000000;
                            break;
                        case 12:
                            returnValue = 1250000;
                            break;
                        case 13:
                            returnValue = 1500000;
                            break;
                        case 14:
                            returnValue = 1750000;
                            break;
                        case 15:
                            returnValue = 2000000;
                            break;
                        case 16:
                            returnValue = 2250000;
                            break;
                        case 17:
                            returnValue = 2500000;
                            break;
                        case 18:
                            returnValue = 2750000;
                            break;
                        case 19:
                            returnValue = 3000000;
                            break;
                    }
                    break;
                case 2:// rogue
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 1250;
                            break;
                        case 2:
                            returnValue = 2500;
                            break;
                        case 3:
                            returnValue = 5000;
                            break;
                        case 4:
                            returnValue = 10000;
                            break;
                        case 5:
                            returnValue = 20000;
                            break;
                        case 6:
                            returnValue = 40000;
                            break;
                        case 7:
                            returnValue = 70000;
                            break;
                        case 8:
                            returnValue = 110000;
                            break;
                        case 9:
                            returnValue = 160000;
                            break;
                        case 10:
                            returnValue = 220000;
                            break;
                        case 11:
                            returnValue = 440000;
                            break;
                        case 12:
                            returnValue = 660000;
                            break;
                        case 13:
                            returnValue = 880000;
                            break;
                        case 14:
                            returnValue = 1100000;
                            break;
                        case 15:
                            returnValue = 1320000;
                            break;
                        case 16:
                            returnValue = 1540000;
                            break;
                        case 17:
                            returnValue = 1760000;
                            break;
                        case 18:
                            returnValue = 1980000;
                            break;
                        case 19:
                            returnValue = 2200000;
                            break;
                    }
                    break;
                case 3:// priest
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 1500;
                            break;
                        case 2:
                            returnValue = 3000;
                            break;
                        case 3:
                            returnValue = 6000;
                            break;
                        case 4:
                            returnValue = 13000;
                            break;
                        case 5:
                            returnValue = 27500;
                            break;
                        case 6:
                            returnValue = 55000;
                            break;
                        case 7:
                            returnValue = 110000;
                            break;
                        case 8:
                            returnValue = 225000;
                            break;
                        case 9:
                            returnValue = 450000;
                            break;
                        case 10:
                            returnValue = 675000;
                            break;
                        case 11:
                            returnValue = 900000;
                            break;
                        case 12:
                            returnValue = 1125000;
                            break;
                        case 13:
                            returnValue = 1350000;
                            break;
                        case 14:
                            returnValue = 1575000;
                            break;
                        case 15:
                            returnValue = 1800000;
                            break;
                        case 16:
                            returnValue = 2025000;
                            break;
                        case 17:
                            returnValue = 2250000;
                            break;
                        case 18:
                            returnValue = 2475000;
                            break;
                        case 19:
                            returnValue = 2700000;
                            break;
                    }
                    break;
                case 4:// mage
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 2500;
                            break;
                        case 2:
                            returnValue = 5000;
                            break;
                        case 3:
                            returnValue = 10000;
                            break;
                        case 4:
                            returnValue = 20000;
                            break;
                        case 5:
                            returnValue = 40000;
                            break;
                        case 6:
                            returnValue = 60000;
                            break;
                        case 7:
                            returnValue = 90000;
                            break;
                        case 8:
                            returnValue = 135000;
                            break;
                        case 9:
                            returnValue = 250000;
                            break;
                        case 10:
                            returnValue = 375000;
                            break;
                        case 11:
                            returnValue = 750000;
                            break;
                        case 12:
                            returnValue = 1125000;
                            break;
                        case 13:
                            returnValue = 1500000;
                            break;
                        case 14:
                            returnValue = 1875000;
                            break;
                        case 15:
                            returnValue = 2250000;
                            break;
                        case 16:
                            returnValue = 2625000;
                            break;
                        case 17:
                            returnValue = 3000000;
                            break;
                        case 18:
                            returnValue = 3375000;
                            break;
                        case 19:
                            returnValue = 3750000;
                            break;
                    }
                    break;
            }
            return returnValue;
        }


        #region  Names
        public List<string> FirstNames_Male = new List<string>();
        public List<string> FirstNames_Female = new List<string>();
        public List<string> LastNames = new List<string>();
        public void CreateNames_Male()
        {
            FirstNames_Male.Add("Hatori");
            FirstNames_Male.Add("Sasuke");
            FirstNames_Male.Add("Akira");
            FirstNames_Male.Add("Jubei");
            FirstNames_Male.Add("Saitama");
            FirstNames_Male.Add("Hirako");
            FirstNames_Male.Add("Tobi");
            FirstNames_Male.Add("Hatori");
        }

        public void CreateNames_Female()
        {
            FirstNames_Female.Add("Sakura");
        }

        public void CreateLastNames()
        {
            LastNames.Add("");
        }
        #endregion
        #region Spells&Magic
        public List<Spell> AvailableSpells_Mage = new List<Spell>();
        public List<Spell> AvailableSpells_Priest = new List<Spell>();
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

        public int GetNumOfSpellSlotForLevel(int playerLvl, int playerClass,int spellLvl)
        {
            int returnValue = 0;
            switch(playerClass)
            {
                case 3: // Priest
                    switch(playerLvl)
                    {
                        case 1:
                            break;
                    }
                    break;
                case 4: // mage
                    break;
            }
            return returnValue;
        }
        #endregion
        #region Proficiencies
        List<NonWeapProficiency> NonWeaponProficiencies = new List<NonWeapProficiency>();
        List<WeaponProficiency> WeaponProficiencies = new List<WeaponProficiency>();

        void PopulateNonWeaponProfLists()
        {
            NonWeaponProficiencies.Add(new NonWeapProficiency("Agriculture", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Animal Handling", "", NonWeapProficiency.Type.General, 1, "WIS", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Artistic Ability", "", NonWeapProficiency.Type.General, 1, "WIS", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Animal Training", "", NonWeapProficiency.Type.General, 1, "WIS", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Blacksmithing", "", NonWeapProficiency.Type.General, 1, "STR", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Brewing", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Carpentry", "", NonWeapProficiency.Type.General, 1, "STR", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Cobbling", "", NonWeapProficiency.Type.General, 1, "DEX", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Cooking", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Dancing", "", NonWeapProficiency.Type.General, 1, "DEX", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Direction Sense", "", NonWeapProficiency.Type.General, 1, "WIS", 1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Etiquette", "", NonWeapProficiency.Type.General, 1, "CHA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Fire Building", "", NonWeapProficiency.Type.General, 1, "WIS", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Fishing", "", NonWeapProficiency.Type.General, 1, "WIS", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Herardry", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Languages, Modern", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Leatherworking", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Minning", "", NonWeapProficiency.Type.General, 2, "WIS", -3));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Pottery", "", NonWeapProficiency.Type.General, 1, "DEX", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Leatherworking", "", NonWeapProficiency.Type.General, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Riding, Airborne", "", NonWeapProficiency.Type.General, 2, "WIS", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Riding, Land-based", "", NonWeapProficiency.Type.General, 1, "WIS", 3));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Riding, Land-based", "", NonWeapProficiency.Type.General, 1, "WIS", 3));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Rope Use", "", NonWeapProficiency.Type.General, 1, "DEX", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Seamanship", "", NonWeapProficiency.Type.General, 1, "DEX", 1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Seamstress/Tailor", "", NonWeapProficiency.Type.General, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Singing", "", NonWeapProficiency.Type.General, 1, "CHA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Stonemasonry", "", NonWeapProficiency.Type.General, 1, "STR", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Swimming", "", NonWeapProficiency.Type.General, 1, "STR", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Weather Sense", "", NonWeapProficiency.Type.General, 1, "WIS", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Weaving", "", NonWeapProficiency.Type.General, 1, "INT", -1));

            NonWeaponProficiencies.Add(new NonWeapProficiency("Ancient History", "", NonWeapProficiency.Type.Priest, 1, "INT", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Astrology", "", NonWeapProficiency.Type.Priest, 2, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Engineering", "", NonWeapProficiency.Type.Priest, 2, "INT", -3));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Healing", "", NonWeapProficiency.Type.Priest, 2, "WIS", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Herbalism", "", NonWeapProficiency.Type.Priest, 2, "INT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Languages, Ancient", "", NonWeapProficiency.Type.Priest, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Local History", "", NonWeapProficiency.Type.Priest, 1, "CHA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Musical Instrument", "", NonWeapProficiency.Type.Priest, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Navigation", "", NonWeapProficiency.Type.Priest, 1, "INT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Reading/Writing", "", NonWeapProficiency.Type.Priest, 1, "INT", +1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Religion", "", NonWeapProficiency.Type.Priest, 1, "WIS", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Spellcraft", "", NonWeapProficiency.Type.Priest, 1, "INT", -2));

            NonWeaponProficiencies.Add(new NonWeapProficiency("Ancient History", "", NonWeapProficiency.Type.Thief, 1, "INT", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Appraising", "", NonWeapProficiency.Type.Thief, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Blind-fighting", "", NonWeapProficiency.Type.Thief, 2, "NA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Disguise", "", NonWeapProficiency.Type.Thief, 1, "CHA", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Forgery", "", NonWeapProficiency.Type.Thief, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Gaming", "", NonWeapProficiency.Type.Thief, 1, "CHA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Gem Cutting", "", NonWeapProficiency.Type.Thief, 2, "DEXT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Juggling", "", NonWeapProficiency.Type.Thief, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Jumping", "", NonWeapProficiency.Type.Thief, 1, "STR", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Local History", "", NonWeapProficiency.Type.Thief, 1, "CHA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Musical Instrument", "", NonWeapProficiency.Type.Thief, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Reading Lips", "", NonWeapProficiency.Type.Thief, 2, "INT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Set Snares", "", NonWeapProficiency.Type.Thief, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Tightrope Walking", "", NonWeapProficiency.Type.Thief, 1, "DEX", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Tumbling", "", NonWeapProficiency.Type.Thief, 1, "DEX", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Ventriloquism", "", NonWeapProficiency.Type.Thief, 1, "INT", -2));

            NonWeaponProficiencies.Add(new NonWeapProficiency("Animal Lore", "", NonWeapProficiency.Type.Warrior, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Armorer", "", NonWeapProficiency.Type.Warrior, 2, "INT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Blind-fighting", "", NonWeapProficiency.Type.Warrior, 2, "NA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Bowyer/Fletcher", "", NonWeapProficiency.Type.Warrior, 1, "DEX", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Endurance", "", NonWeapProficiency.Type.Warrior, 2, "CON", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Hunting", "", NonWeapProficiency.Type.Warrior, 1, "WIS", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Mountaineering", "", NonWeapProficiency.Type.Warrior, 1, "NA", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Navigation", "", NonWeapProficiency.Type.Warrior, 1, "INT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Running", "", NonWeapProficiency.Type.Warrior, 1, "CON", -6));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Set Snares", "", NonWeapProficiency.Type.Warrior, 1, "INT", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Survival", "", NonWeapProficiency.Type.Warrior, 2, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Tracking", "", NonWeapProficiency.Type.Warrior, 2, "WIS", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Weaponsmithing", "", NonWeapProficiency.Type.Warrior, 3, "INT", -3));

            NonWeaponProficiencies.Add(new NonWeapProficiency("Ancient History", "", NonWeapProficiency.Type.Mage, 1, "INT", -1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Astrology", "", NonWeapProficiency.Type.Mage, 2, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Engineering", "", NonWeapProficiency.Type.Mage, 2, "INT", -3));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Gem Cutting", "", NonWeapProficiency.Type.Mage, 2, "DEX", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Herbalism", "", NonWeapProficiency.Type.Mage, 2, "INT", -2));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Languages, Ancient", "", NonWeapProficiency.Type.Mage, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Navigation", "", NonWeapProficiency.Type.Mage, 1, "INT", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Reading/Writing", "", NonWeapProficiency.Type.Mage, 1, "INT", 1));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Religion", "", NonWeapProficiency.Type.Mage, 1, "WIS", 0));
            NonWeaponProficiencies.Add(new NonWeapProficiency("Spellcraft", "", NonWeapProficiency.Type.Mage, 1, "INT", -2));

        }
        void PopulateWeaponProfLists()
        {
            WeaponProficiencies.Add(new WeaponProficiency("Daikyu"));
            WeaponProficiencies.Add(new WeaponProficiency("Hankyu"));
            WeaponProficiencies.Add(new WeaponProficiency("Pellet Bow"));
            WeaponProficiencies.Add(new WeaponProficiency("Cho-Ko-Nu"));
            WeaponProficiencies.Add(new WeaponProficiency("No-Daichi"));
            WeaponProficiencies.Add(new WeaponProficiency("Tetsu-to"));
            WeaponProficiencies.Add(new WeaponProficiency("Katana/Bokken"));
            WeaponProficiencies.Add(new WeaponProficiency("Long Sword"));
            WeaponProficiencies.Add(new WeaponProficiency("Ninja-to"));
            WeaponProficiencies.Add(new WeaponProficiency("Tanto"));
            WeaponProficiencies.Add(new WeaponProficiency("Wakizashi"));
            WeaponProficiencies.Add(new WeaponProficiency("Chopsticks"));
            WeaponProficiencies.Add(new WeaponProficiency("Parang"));
            WeaponProficiencies.Add(new WeaponProficiency("Nekode"));
            WeaponProficiencies.Add(new WeaponProficiency("Kau sin ke"));
            WeaponProficiencies.Add(new WeaponProficiency("Kusarigama"));
            WeaponProficiencies.Add(new WeaponProficiency("Manriki-gusari"));
            WeaponProficiencies.Add(new WeaponProficiency("Three-section staff"));
            WeaponProficiencies.Add(new WeaponProficiency("Whip"));
            WeaponProficiencies.Add(new WeaponProficiency("Kawanaga"));
            WeaponProficiencies.Add(new WeaponProficiency("Kyogetsu-shogi"));
            WeaponProficiencies.Add(new WeaponProficiency("Battle Axe"));
            WeaponProficiencies.Add(new WeaponProficiency("Hand/Throwing Axe"));
            WeaponProficiencies.Add(new WeaponProficiency("Hanbo"));
            WeaponProficiencies.Add(new WeaponProficiency("Jo"));
            WeaponProficiencies.Add(new WeaponProficiency("Kiseru"));
            WeaponProficiencies.Add(new WeaponProficiency("Tonfa"));
            WeaponProficiencies.Add(new WeaponProficiency("Kama"));
            WeaponProficiencies.Add(new WeaponProficiency("Kumade"));
            WeaponProficiencies.Add(new WeaponProficiency("Lajatang"));
            WeaponProficiencies.Add(new WeaponProficiency("Bo"));
            WeaponProficiencies.Add(new WeaponProficiency("Tetsu-bo"));
            WeaponProficiencies.Add(new WeaponProficiency("Gunsen"));
            WeaponProficiencies.Add(new WeaponProficiency("Halberd"));
            WeaponProficiencies.Add(new WeaponProficiency("Man catcher"));
            WeaponProficiencies.Add(new WeaponProficiency("Nagimaki"));
            WeaponProficiencies.Add(new WeaponProficiency("Naginata"));
            WeaponProficiencies.Add(new WeaponProficiency("Sang kauw"));
            WeaponProficiencies.Add(new WeaponProficiency("Sode garami"));
            WeaponProficiencies.Add(new WeaponProficiency("Trident"));
            WeaponProficiencies.Add(new WeaponProficiency("Chijiriki"));
            WeaponProficiencies.Add(new WeaponProficiency("Shakujo yari"));
            WeaponProficiencies.Add(new WeaponProficiency("Uchi-ne"));
            WeaponProficiencies.Add(new WeaponProficiency("Eggshel grenades"));
            WeaponProficiencies.Add(new WeaponProficiency("Nage teppo"));
            WeaponProficiencies.Add(new WeaponProficiency("Shuriken, Bo"));
            WeaponProficiencies.Add(new WeaponProficiency("Shuriken, Small"));
            WeaponProficiencies.Add(new WeaponProficiency("Shuriken, Large"));
            WeaponProficiencies.Add(new WeaponProficiency("Dart"));
            WeaponProficiencies.Add(new WeaponProficiency("Tetsu-bishi"));
            WeaponProficiencies.Add(new WeaponProficiency("Blowgun"));
            WeaponProficiencies.Add(new WeaponProficiency("Fukimi-bari"));
            WeaponProficiencies.Add(new WeaponProficiency("Metsubishi"));
            WeaponProficiencies.Add(new WeaponProficiency("Needle"));


        }
        #endregion
        #region Weapons
        public List<Weapon> WeaponsList = new List<Weapon>();

        void PopulateWeaponList()
        {
            WeaponsList.Add(new Weapon("Battle Axe", 1, 8, 1, 8, 7, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning}, 0, 0, 5));
            WeaponsList.Add(new Weapon("Hand Axe", 1, 6, 1, 4, 4, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning }, 0, 0, 1));
            WeaponsList.Add(new Weapon("Bo", 1, 6, 1, 6, 4, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning }, 5, 0, 0));
            WeaponsList.Add(new Weapon("Gunsen", 1, 3, 1, 2, 5, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning }, 0, 0, 5));
            WeaponsList.Add(new Weapon("Jitte", 1, 4, 1, 2, 3, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning }, 0, 0, 2));
            WeaponsList.Add(new Weapon("Jo", 1, 6, 1, 3, 4, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning }, 0, 4, 0));
            WeaponsList.Add(new Weapon("Kama", 1, 6, 1, 4, 3, new List<Weapon.DamageType>() { Weapon.DamageType.Slashing }, 0, 0, 2));
            WeaponsList.Add(new Weapon("Kusarigama", 1, 6, 1, 4, 6, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning, Weapon.DamageType.Slashing }, 0, 0, 3));
            WeaponsList.Add(new Weapon("Kyogetsu-shogi", 1, 4, 1, 4, 6, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning, Weapon.DamageType.Slashing }, 0, 0, 2));
            WeaponsList.Add(new Weapon("Nagimaki", 1, 6, 1, 8, 6, new List<Weapon.DamageType>() { Weapon.DamageType.Piercing, Weapon.DamageType.Slashing }, 0, 0, 5));
            WeaponsList.Add(new Weapon("Naginata", 1, 6, 1, 10, 8, new List<Weapon.DamageType>() { Weapon.DamageType.Piercing, Weapon.DamageType.Slashing }, 0, 0, 8));
            WeaponsList.Add(new Weapon("Katana", 1, 10, 1, 12,2,6,2,6, 4,7, new List<Weapon.DamageType>() { Weapon.DamageType.Piercing, Weapon.DamageType.Slashing }, 0, 0, 100));
            WeaponsList.Add(new Weapon("Bokken", 1, 4, 1, 2, 1, 6, 1, 3, 4, 7, new List<Weapon.DamageType>() { Weapon.DamageType.Bludgeoning }, 1, 0, 0));
            WeaponsList.Add(new Weapon("Ninja-To", 1, 8, 1, 6, 4, new List<Weapon.DamageType>() { Weapon.DamageType.Piercing, Weapon.DamageType.Slashing }, 0, 0, 12));
            WeaponsList.Add(new Weapon("Tanto", 1, 4, 1, 3, 2, new List<Weapon.DamageType>() { Weapon.DamageType.Piercing, Weapon.DamageType.Slashing }, 0, 0, 3));
            WeaponsList.Add(new Weapon("Wakizashi", 1, 8, 1, 8, 3, new List<Weapon.DamageType>() { Weapon.DamageType.Piercing, Weapon.DamageType.Slashing, Weapon.DamageType.Slashing }, 0, 0, 50));
        }
        #endregion
        #region THAC0
        public int GetThaco(int playerClass,int playerLevel)
        {
            int returnValue = 2;
            switch(playerClass)
            {
                case 1://warrior
                    switch(playerLevel)
                    {
                        case 1:
                            returnValue = 20;
                            break;
                        case 2:
                            returnValue = 19;
                            break;
                        case 3:
                            returnValue = 18;
                            break;
                        case 4:
                            returnValue = 17;
                            break;
                        case 5:
                            returnValue = 16;
                            break;
                        case 6:
                            returnValue = 15;
                            break;
                        case 7:
                            returnValue = 14;
                            break;
                        case 8:
                            returnValue = 13;
                            break;
                        case 9:
                            returnValue = 12;
                            break;
                        case 10:
                            returnValue = 11;
                            break;
                        case 11:
                            returnValue = 10;
                            break;
                        case 12:
                            returnValue = 9;
                            break;
                        case 13:
                            returnValue = 8;
                            break;
                        case 14:
                            returnValue = 7;
                            break;
                        case 15:
                            returnValue = 6;
                            break;
                        case 16:
                            returnValue = 5;
                            break;
                        case 17:
                            returnValue = 4;
                            break;
                        case 18:
                            returnValue = 3;
                            break;
                        case 19:
                            returnValue = 2;
                            break;
                        case 20:
                            returnValue = 1;
                            break;
                    }
                    break;
                case 2://thief
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 20;
                            break;
                        case 2:
                            returnValue = 20;
                            break;
                        case 3:
                            returnValue = 19;
                            break;
                        case 4:
                            returnValue = 19;
                            break;
                        case 5:
                            returnValue = 18;
                            break;
                        case 6:
                            returnValue = 18;
                            break;
                        case 7:
                            returnValue = 17;
                            break;
                        case 8:
                            returnValue = 17;
                            break;
                        case 9:
                            returnValue = 16;
                            break;
                        case 10:
                            returnValue = 16;
                            break;
                        case 11:
                            returnValue = 15;
                            break;
                        case 12:
                            returnValue = 15;
                            break;
                        case 13:
                            returnValue = 14;
                            break;
                        case 14:
                            returnValue = 14;
                            break;
                        case 15:
                            returnValue = 13;
                            break;
                        case 16:
                            returnValue = 13;
                            break;
                        case 17:
                            returnValue = 12;
                            break;
                        case 18:
                            returnValue = 12;
                            break;
                        case 19:
                            returnValue = 11;
                            break;
                        case 20:
                            returnValue = 11;
                            break;
                    }
                    break;
                case 3://priest
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 20;
                            break;
                        case 2:
                            returnValue = 20;
                            break;
                        case 3:
                            returnValue = 20;
                            break;
                        case 4:
                            returnValue = 18;
                            break;
                        case 5:
                            returnValue = 18;
                            break;
                        case 6:
                            returnValue = 18;
                            break;
                        case 7:
                            returnValue = 16;
                            break;
                        case 8:
                            returnValue = 16;
                            break;
                        case 9:
                            returnValue = 16;
                            break;
                        case 10:
                            returnValue = 14;
                            break;
                        case 11:
                            returnValue = 14;
                            break;
                        case 12:
                            returnValue = 14;
                            break;
                        case 13:
                            returnValue = 12;
                            break;
                        case 14:
                            returnValue = 12;
                            break;
                        case 15:
                            returnValue = 12;
                            break;
                        case 16:
                            returnValue = 10;
                            break;
                        case 17:
                            returnValue = 10;
                            break;
                        case 18:
                            returnValue = 10;
                            break;
                        case 19:
                            returnValue = 8;
                            break;
                        case 20:
                            returnValue = 8;
                            break;
                    }
                    break;
                case 4://mage
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 20;
                            break;
                        case 2:
                            returnValue = 20;
                            break;
                        case 3:
                            returnValue = 20;
                            break;
                        case 4:
                            returnValue = 19;
                            break;
                        case 5:
                            returnValue = 19;
                            break;
                        case 6:
                            returnValue = 19;
                            break;
                        case 7:
                            returnValue = 18;
                            break;
                        case 8:
                            returnValue = 18;
                            break;
                        case 9:
                            returnValue = 18;
                            break;
                        case 10:
                            returnValue = 17;
                            break;
                        case 11:
                            returnValue = 17;
                            break;
                        case 12:
                            returnValue = 17;
                            break;
                        case 13:
                            returnValue = 16;
                            break;
                        case 14:
                            returnValue = 16;
                            break;
                        case 15:
                            returnValue = 16;
                            break;
                        case 16:
                            returnValue = 15;
                            break;
                        case 17:
                            returnValue = 15;
                            break;
                        case 18:
                            returnValue = 15;
                            break;
                        case 19:
                            returnValue = 14;
                            break;
                        case 20:
                            returnValue = 14;
                            break;
                    }
                    break;
            }
            return returnValue;
        }
        #endregion
    }
}
