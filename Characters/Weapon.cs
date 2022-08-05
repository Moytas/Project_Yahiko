using System.Collections.Generic;

namespace Project_Yahiko
{
    public class Weapon : Items
    {
        public int NumOfDie_Small;
        public int TypeOfDie_Small;
        public int ModifierSmall;
        public int NumOfDie_Large;
        public int TypeOfDie_Large;
        public int ModifierLarge;
        public int NumOfDie2H_Small;
        public int NumOfDie2H_Large;
        public int TypeOfDie2H_Small;
        public int TypeOfDie2H_Large;
        public int Modifier2HSmall;
        public int Modifier2HLarge;

        public bool CanBeTwoHanded = false;
        public string Size;
        public bool Magic = false;
        public int MagicModifier = 0;

        public int Speed { get; set; }
        public int Speed2H;
        public enum DamageType
        {
            Piercing,
            Slashing,
            Bludgeoning,
            Magic,
            Elemental
        };

        public List<DamageType> WeaponType = new List<DamageType>();

        public enum MadeOf
        {
            wood,
            metal
        };

        public MadeOf _MadeOf = MadeOf.wood;

        public Weapon()
        {
            Name = "Unarmed";
            NumOfDie_Small = 1;
            TypeOfDie_Small = 3;
            NumOfDie_Large = 1;
            TypeOfDie_Large = 2;
            Speed = 3;
        }

        public Weapon(string name, int dieSmall,int typeSmall,int dieLarge,int typeLarge,int speed,List<DamageType> weaponType)
        {
            Name = name;
            NumOfDie_Small = dieSmall;
            TypeOfDie_Small = typeSmall;
            NumOfDie_Large = dieLarge;
            TypeOfDie_Large = typeLarge;
            Speed = speed;
            WeaponType = weaponType;
        }

        public Weapon(string name, int dieSmall, int typeSmall, int dieLarge, int typeLarge,int die2Hsmall, int type2Hsmall,int die2HLarge,int type2HLarge,int speed,int speed2H, List<DamageType> weaponType, int cost_c, int cost_s, int cost_g)
        {
            Name = name;
            NumOfDie_Small = dieSmall;
            TypeOfDie_Small = typeSmall;
            NumOfDie_Large = dieLarge;
            TypeOfDie_Large = typeLarge;
            NumOfDie2H_Small = die2Hsmall;
            TypeOfDie2H_Small = type2Hsmall;
            NumOfDie2H_Large = die2HLarge;
            TypeOfDie2H_Small = type2HLarge;
            Speed2H = speed2H;
            Speed = speed;
            WeaponType = weaponType;
            Cost_Copper = cost_c;
            Cost_Silver = cost_s;
            Cost_Gold = cost_g;
        }

        public Weapon(string name, int dieSmall, int typeSmall, int dieLarge, int typeLarge, int speed, List<DamageType> weaponType, int cost_c,int cost_s,int cost_g)
        {
            Name = name;
            NumOfDie_Small = dieSmall;
            TypeOfDie_Small = typeSmall;
            NumOfDie_Large = dieLarge;
            TypeOfDie_Large = typeLarge;
            Speed = speed;
            WeaponType = weaponType;
            Cost_Copper = cost_c;
            Cost_Silver = cost_s;
            Cost_Gold = cost_g;
        }

    }
}