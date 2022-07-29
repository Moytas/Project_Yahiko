using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class Character
    {
        public string FirstName, Lastname;
        public int Level;
        public bool Gender;
        public int CharacterRace;
        public Stats CharacterStats;
        public SavThrows SavingThrows;
        public int HP_Max, HP_Current;

        public int MovementRate = 0;
        public int Money_Copper, Money_Silver, Money_Gold;

        public int AlignmentLaw, AlignmentGood;
    }
}
