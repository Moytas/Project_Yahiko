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
            PopulateWeaponProfLists();
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
        public List<NonWeapProficiency> NonWeaponProficiencies = new List<NonWeapProficiency>();
        public List<WeaponProficiency> WeaponProficiencies = new List<WeaponProficiency>();

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
            WeaponProficiencies.Add(new WeaponProficiency("Daikyu", "This is the largest type of bow found in an Oriental setting. In some ways, it is similar to the western long bow.It is 7 feet long and bent at the ends for greater power. Unlike most bows, the grip is closer to the bottom, not centered.This allows the bow to be fired from horseback and kneeling positions."));
            WeaponProficiencies.Add(new WeaponProficiency("Hankyu", " This is the small Oriental bow, often used by ninja"));
            WeaponProficiencies.Add(new WeaponProficiency("Pellet Bow", "Although almost identical in construction and use to a normal bow, the pellet bow has a small pocket in the bowstring for holding a stone or pellet of lead or clay.The pellet can be fired with more force than from a sling (giving the weapon extra range, though not extra damage)."));
            WeaponProficiencies.Add(new WeaponProficiency("Cho-Ko-Nu", "This crossbow is capable of firing several bolts before it must be reloaded.It is similar to the western light crossbow, but mounted on top is a magazine that can hold up to 10 light quarrels.The cocking and reloading action is worked by a single lever, pushed forward and then pulled back.This allows a faster rate of fire than normal.Up to two quarrels can be reloaded in the magazine per round.Thus, five rounds are required to completely reload the chu - ko - nu.A character cannot fire and reload in the same round.The chu - ko - nu is heavier than a normal light crossbow and has a shorter range."));
            WeaponProficiencies.Add(new WeaponProficiency("No-Daichi", "This is the equivalent of the western two-handed sword.It is constructed more like the katana or ancestral long sword, having a narrow, slightly curved or straight blade and a minimal circular or octagonal guard, but has all the characteristics of its western equivalent"));
            WeaponProficiencies.Add(new WeaponProficiency("Tetsu-to", "This odd weapon is basically an iron bar shaped in the fashion of a two - handed Oriental sword.It is a heavy weapon used for strength training,  not combat, and is very slow to use. (It suffers a –3 attack - roll penalty because of its  awkwardness.) However, when the tetsu - to does hit in combat, it does a lot of damage"));
            WeaponProficiencies.Add(new WeaponProficiency("Katana/Bokken", "a wooden copy of the katana, designed to simulate that sword's weight and other characteristics. It is used to practice swordsmanship since it does not cause cutting injuries.Wielded aggressively, however, it can cause injury from the force of the blow. "));
            WeaponProficiencies.Add(new WeaponProficiency("Ninja-to", "This is the ninja's standard sword. It is approximately the length of a short sword, making it easier to conceal on the body.The blade of the ninja - to is straight and of lower quality than that of a katana."));
            WeaponProficiencies.Add(new WeaponProficiency("Tanto", "his is the equivalent of the western two-handed sword.It is constructed more like the katana or ancestral long sword, having a narrow, slightly curved or straight blade and a minimal circular or octagonal guard, but has all the characteristics of its western equival"));
            WeaponProficiencies.Add(new WeaponProficiency("Wakizashi", "This is a short sword, similar in design and construction to the katana. Like the katana, the wakizashi may be named for some past deed or event. It holds almost as important a place in the samurai's honor as his katana. Those rules and guidelines concerning the katana and its care also apply to the wakizashi when it is part of a matched set."));
            WeaponProficiencies.Add(new WeaponProficiency("Chopsticks", "Chopsticks can be used as a weapon in case of emergency. They are not very effective but are better than nothing, and they are commonly available."));
            WeaponProficiencies.Add(new WeaponProficiency("Parang", "The parang is both a tool and a weapon—a heavy-bladed machete capable of delivering chopping blows of great force."));
            WeaponProficiencies.Add(new WeaponProficiency("Nekode", "This dual-purpose ninja tool is a pair of straps or gloves fitted with spikes in the palm.By hammering the spikes into cracks in a wall or cliff to give a better grip, the user of nekode receives a + 10 % bonus to his climb walls skill.Nekode can also be used to claw an opponent for small amounts of damage.While wearing nekode, a character can still wield other weapons without penalty.Nekode are usually worn only when needed, because they easily identify the user as a ninja."));
            WeaponProficiencies.Add(new WeaponProficiency("Kau sin ke", "This weapon consists of four to six short iron bars connected by several links of chain.Its origins can be traced to the agricultural flail.Used properly, it can be a deadly weapon; the iron bars can wrap around shields to land crushing blows.However, because it is not as flexible as a normal chain or rope weapon, it cannot be used to make entangling attacks."));
            WeaponProficiencies.Add(new WeaponProficiency("Kusarigama", " This variation on the kama (sickle) was designed specifically for combat.It is a kama with a length of weighted chain attached to the butt end of the handle.The kusari - gama can be used in several ways: The user can attack with the kama in hand, he can club and entangle with the weighted chain, or he can whirl the kama at the end of the chain.This weapon is relatively easy to make and is favored by both peasants and ninja"));
            WeaponProficiencies.Add(new WeaponProficiency("Manriki-gusari", "This simple length of chain with weights at each end can bewhirled quickly, striking with hard blows from the weights.One end can be swung out to entangle an opponent, or the entire weapon can be thrown, entangling and causing damage at the same time.The manriki - gusari is popular in areas where the lord has forbidden the use or wearing of other weapons, or when secrecy is required.It can easily be worn as a belt or hidden under a sash."));
            WeaponProficiencies.Add(new WeaponProficiency("Three-section staff"));
            WeaponProficiencies.Add(new WeaponProficiency("Whip", "To inflict damage, the whip must strike exposed or lightly covered flesh. Heavy clothing, thick hair, or fur gives considerable protection until torn away by repeated lashing.The type of armor determines how long it takes the whip to begin doing damage.With heavy clothing, damage begins on the third successful blow; thick hair or fur, on the second; padded armor, on the fourth; leather armor, on the fifth; hide armor, on the sixth. The whip can do no harm through armor heavier than that. Thick hide, such as that of an elephant or rhinoceros, will allow a slight sting at best, with no real damage inflicted. However, the whip can also be used to entangle a target, and is often more effectively used in this way than for causing damage."));
            WeaponProficiencies.Add(new WeaponProficiency("Kawanaga", "This a length of rope, with a grappling hook at one end and a weight at the other, is both a tool and a weapon.It can be used as a weapon by swinging the hook or the weight at an opponent.The grappling hook can also be used for climbing, and the rope can be used to entangle an opponent.This type of weapon is popular with ninja because it has several uses and is easily concealed."));
            WeaponProficiencies.Add(new WeaponProficiency("Kyogetsu-shogi", "This is a simple length of rope with a sharp hooked blade at one end and a heavy iron ring at the other.Its uses are similar to those of a standard chain weapon.The rope can be swung to attack with the blade or weight, snapped around the feet or arms to entangle, thrown to entangle, or held while striking with the blade.Although the rope is far easier to cut or break than a chain, the weapon is often used by ninja because it is almost silent. It is easy to conceal and can be worn as a belt or under a sash."));
            WeaponProficiencies.Add(new WeaponProficiency("Battle Axe"));
            WeaponProficiencies.Add(new WeaponProficiency("Hand/Throwing Axe", "Oriental equivalents for the common western battle and hand/throwing axes are readily available."));
            WeaponProficiencies.Add(new WeaponProficiency("Hanbo", "This 2-3 foot stick is used as a weapon; practitioners often carry one in each hand.The statistics for the hanbo are used when a sword sheath is used as a weapon."));
            WeaponProficiencies.Add(new WeaponProficiency("Jo", " This stick weapon is about 4 feet long, between the bo and hanbo in size.It can be used one - handed and in pairs.The jo is a favorite weapon of ninja because it is innocuous; it is also called the shinobi-zue."));
            WeaponProficiencies.Add(new WeaponProficiency("Kiseru", "This is a tobacco pipe made of metal. Its innocent appearance disguises its use as a clubbing weapon.It is popular with peasants and monks because it is cheap and easy to make and does not appear to be dangerous.It can also be used for smoking."));
            WeaponProficiencies.Add(new WeaponProficiency("Tonfa", "This is a hardwood rod with a small handle sticking out off-center from the side.The entire length is about 2–3 feet.It was originally the handle of a millstone.With this weapon, a trained fighter can block, catch weapons, break weapons,and attack effectively.The tonfa is often used in areas where normal weapons are outlawed."));
            WeaponProficiencies.Add(new WeaponProficiency("Kama", "This straight-bladed sickle is a farmer's tool that can also be used as a weapon to great effect.Ninja like this weapon because it can be carried without arousing suspicion.The damage values given for it are for a freshly sharpened weapon.After use in the field for several hours, a kama will be considerably duller, and may, at the DM's discretion, have reduced values for damage."));
            WeaponProficiencies.Add(new WeaponProficiency("Kumade", "This dual-purpose tool consists of a spear-length wooden shaft with a rake head fitted at one end.By setting the rake prongs in a crack, ledge, or sill, a ninja can climb up the shaft.The kumade can also be used as a weapon.Because the kumade has multiple uses and can be carried without arousing suspicion, it is a common item for ninja to use."));
            WeaponProficiencies.Add(new WeaponProficiency("Lajatang", "This rare weapon is most often found in the hands of a martial artist skilled in its use.It consists of a 3–5 foot shaft with a crescent blade fitted at each end. Some individual weapons have smaller barbs projecting downward from the outer edges of the crescent.The weapon is held with two hands, much like a bo."));             
            WeaponProficiencies.Add(new WeaponProficiency("Bo", "This Oriental equivalent of the quarterstaff is normally 6–7 feet long. Its hard wood makes it difficult to cut or break."));
            WeaponProficiencies.Add(new WeaponProficiency("Tetsu-bo", "This is a bo with at least half its length sheathed in studded iron strips.It is often used by travelers because it can also serve as a walking stick."));
            WeaponProficiencies.Add(new WeaponProficiency("Gunsen", "This iron fan's main use is defensive, counting as a small shield.However, it can also be used to strike blows.It is normally considered a fallback weapon."));
            WeaponProficiencies.Add(new WeaponProficiency("Nagimaki", "This shortened version of the naginata is used primarily by horsemen.It consists of a 4 - 6 foot shaft capped by a curved swordlike blade."));
            WeaponProficiencies.Add(new WeaponProficiency("Naginata", "This lightweight but strong polearm is 6–8 feet long and ends in a curved swordlike blade.It is used as a standard polearm.The naginata is often the preferred weapon of women; many female samurai and ninja become proficient with this weapon"));
            WeaponProficiencies.Add(new WeaponProficiency("Sang kauw", "This weapon comes in two forms. The basic form is a double - headed spear with a loop handle in the center, from which projects a dagger or crescent.The weapon is used with one hand to parry and attack.Its other form is almost identical; a small buckler is fitted in the center with the dagger blade projecting from it. When the second form is used, the character is considered to be using a small shield(for calculating Armor Class) "));
            WeaponProficiencies.Add(new WeaponProficiency("Sode garami", "his highly specialized weapon is used to catch and entangle an opponent without causing great harm.It is normally made as a pole and crossbar set with a large number of spikes and hooks.On a successful hit, it hooks and catches the clothing of the opponent, who is allowed a saving throw vs.paralyzation to escape.If the saving throw is unsuccessful, the character is entangled.When used specifically to catch an opponent, the sode garami does no damage.This weapon is often carried by palace guards or city constables."));
            WeaponProficiencies.Add(new WeaponProficiency("Trident", "Oriental version of the trident."));
            WeaponProficiencies.Add(new WeaponProficiency("Chijiriki", "A length of weighted chain is added to the butt end of anormal spear.This weapon can be used as a normal spear, or the butt - chain can be swung out, entangling the opponent."));
            WeaponProficiencies.Add(new WeaponProficiency("Shakujo yari", "This is a spear concealed within a sheath to look like a staff.It can be used as a bo when the sheath is in place.The shakujo yari can be carried on secret missions or when the character desires to look relatively defenseless."));
            WeaponProficiencies.Add(new WeaponProficiency("Uchi-ne", "This is a short, heavy javelin that looks like an oversized arrow. It can be thrown effectively for short distances or used for thrusting and jabbing.The uchi - ne is often carried by nobles when traveling."));
            WeaponProficiencies.Add(new WeaponProficiency("Nage teppo", "These small grenadelike weapons are popular with ninja."));
            WeaponProficiencies.Add(new WeaponProficiency("Shuriken", "This small throwing weapon comes in many sizes and shapes.All shuriken are thrown by hand and have a limited range.They are easily hidden in folds of clothing or tucked into sashes.Spike shuriken can even be worn in the hair.Spike shuriken look like large pins, tapering to a sharp point.Large star shuriken are larger.They may also be gripped in the fist, with one sharpened point projecting between the fingers, and used as a punching weapon.Small star shuriken have three or more razor - edged points, ensuring that at least one point will strike the opponent(if a successful attack roll is made)."));
            WeaponProficiencies.Add(new WeaponProficiency("Dart", "Ordinary darts. Many ninja like them for their lightness and ease of concealment."));
            WeaponProficiencies.Add(new WeaponProficiency("Tetsu-bishi", "This are small caltrops, not melee or thrown weapons. Each is a ball or four - sided diamond of spikes, designed so that no matter how it lands at least one spike is pointing upward. They are used to stop or slow the movement of men and animals by making the ground extremely dangerous to walk on."));
            WeaponProficiencies.Add(new WeaponProficiency("Blowgun", "Many ninja use blowguns, as light weapons or as distractions. Evil ninja may use blowguns as a means to deliver poisons.A blowgun dart is larger and heavier, and does more damage than a blowgun needle.The needle is less expensive but just as good at carrying poisons.Blowguns can also be used as breathing tubes for swimming underwater.Special reinforced blowguns are available.A blowgun costing 6 gp can also be used as a jo stick; a 7 - gp blowgun can be used as a jo stick or the scabbard for a sword."));
            WeaponProficiencies.Add(new WeaponProficiency("Fukimi-bari", "These small darts are held in the mouth and blown into the face of an opponent as a surprise attack.Up to 10 of them can be carried in the mouth.They can be fired singly or all at once.Obviously, since the darts are carried in the mouth, they cannot be poisoned(unless the ninja is willing to suffer the effects of the poison as well).Furthermore, the darts have a very poor range and are almost never effective against any type of armor; wielders of this weapon suffer a –6 penalty to the attack roll when firing at an armored target.However, these darts do have the advantage of surprise and distraction because they are a hidden weapon."));
            WeaponProficiencies.Add(new WeaponProficiency("Metsubishi", "A small wooden device, similar to a short blowgun (1–2 feet long), is used to blow a puff of powder into an opponent's face. It has a mouthpiece at one end, a chamber for holding the powder, and a small tube at the other end.The most common powders are peppers, ashes, and dust.This weapon is often used by ninja for distraction and escape, and by city constables when attempting to capture a criminal."));
            WeaponProficiencies.Add(new WeaponProficiency("Needle", "Although hardly an effective weapon, needles are occasionally carried by ninja for distraction or surprise.Like the fukimi - bari, they are carried in the mouth and fired by spitting or blowing(using the tongue as a blowpipe). Up to 20 needles can be carried in the mouth. The needles can be fired singly or all at once."));
            WeaponProficiencies.Add(new WeaponProficiency("Man-catcher", "This is a two-pronged polearm. Each prong is curved to encircle a humanoid creature of man size.Creatures larger or smaller than human size by 50 % or more are unaffected by this weapon."));

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
