using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_Yahiko
{
    public class Bushi : Player
    {
        public WeaponProficiency WeaponSpecialization;

        public Bushi()
        { }

        public Bushi(Player p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            
            CharacterClass = 1;
            
            CharacterRace = p.CharacterRace;
            MovementRate = p.MovementRate;

            NumWeaponProf = p.NumWeaponProf;
            NumNonWeaponProf = p.NumNonWeaponProf;

            XP = p.XP;
            XPToNext = p.XPToNext;
            
            CharacterStats = p.CharacterStats;
            EquipedArmor = p.EquipedArmor;
            EquipedWeapon = p.EquipedWeapon;
            NumNonWeaponProf = p.NumNonWeaponProf;
            NumWeaponProf = p.NumWeaponProf;
            Console.WriteLine("char race = " + CharacterRace + " vs p.char race= " + p.CharacterRace);
        }

        void SetInitialMoney()
        {
            Random rand = new Random();
            int total = 0;

            for(int i = 0; i < 5;i++)
            {
                total += (int)rand.Next(1, 5);
                Thread.Sleep(rand.Next(1, 11));
            }

            total *= 10;
            Money_Gold = total;
            Money_Silver = 0;
            Money_Copper = 0;
        }
    }
}
