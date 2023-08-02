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

    public Bushi() //FOR TESTING ONLY
    {
      FirstName = "Fname";
      LastName = "Lname";

      CharacterClass = 1;

      CharacterRace = 1; 
      MovementRate = 12;

      NumWeaponProf = 4;
      NumNonWeaponProf = 3;

      XP = 0;
      XPToNext = 0;
 
      //NumNonWeaponProf += p.CharacterStats.NumLanguages;
      EquipedArmor = new Armor();//CHECK HERE
      EquipedWeapon = new Weapon();//!
    } 
  

        public Bushi(Player p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            
            CharacterClass = 1;
            
            CharacterRace = p.CharacterRace;
            MovementRate = p.MovementRate;

            NumWeaponProf = 4;
            NumNonWeaponProf = 3;

            XP = 0;
            XPToNext = p.XPToNext;
            
            CharacterStats = p.CharacterStats;
            NumNonWeaponProf += p.CharacterStats.NumLanguages;
            EquipedArmor = new Armor();//CHECK HERE
            EquipedWeapon = new Weapon();//!
            
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
