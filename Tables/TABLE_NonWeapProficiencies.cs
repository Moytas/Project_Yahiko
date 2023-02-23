using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class TABLE_NonWeapProficiencies
    {
        public List<NonWeapProficiency> NonWeaponProficiencies = new List<NonWeapProficiency>();
        public TABLE_NonWeapProficiencies()
        {
            PopulateNonWeaponProfLists();
        }
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

    }
}
