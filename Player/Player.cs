using System.Collections.Generic;

namespace Project_Yahiko
{
    public class Player : Character
    {
        public string FirstName, LastName;
        public int PlayerClass;
        public Weapon EquipedWeapon;
        public Armor EquipedArmor;
        public int XP, XPToNext;
        public List<Items> Inventory = new List<Items>();
        public ThiefSkills Skills = new ThiefSkills();
        public int NumWeaponProf,NumNonWeaponProf;
        public List<Proficiency> WeaponProf = new List<Proficiency>();
        public List<Proficiency> NonWeaponProf = new List<Proficiency>();
        public Player()
        {
            CharacterStats = new Stats();
            EquipedWeapon = new Weapon();
            EquipedArmor = new Armor();
           
        }
    }
}