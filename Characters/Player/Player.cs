﻿using System.Collections.Generic;

namespace Project_Yahiko
{
    public class Player : Character
    {
        public string FirstName, LastName;
        public int CharacterClass;
        public Weapon EquipedWeapon;
        public Armor EquipedArmor;
        public int XP, XPToNext;
        public List<Items> Inventory = new List<Items>();
        public ThiefSkills Skills = new ThiefSkills();
        public int NumWeaponProf,NumNonWeaponProf;
        public List<WeaponProficiency> WeaponProf = new List<WeaponProficiency>();
        public List<NonWeapProficiency> NonWeaponProf = new List<NonWeapProficiency>();
        public Player()
        {
            CharacterStats = new Stats();
            EquipedWeapon = new Weapon();
            EquipedArmor = new Armor();
           
        }
    }
}