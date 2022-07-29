using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_Yahiko
{
    public class Onmyoji : Player
    {
        public SpellBook MySpellBook;
        int maxSpellLevel;
        int[] maxPerSpellLevel;
        public List<Spell> MemorizedSpells;

        public Onmyoji(string firstName,string lastName,Stats _stats)
        {
            MySpellBook = new SpellBook(SpellBook.Type.Mage);
            switch(Level)
            {
                case 1:
                    maxPerSpellLevel = new int[1];
                    maxPerSpellLevel[0] = 1;
                    maxSpellLevel = 1;
                    break;
                case 2:
                    maxPerSpellLevel = new int[1];
                    maxPerSpellLevel[0] = 2;
                    maxSpellLevel = 1;
                    break;
                case 3:
                    maxPerSpellLevel = new int[2];
                    maxPerSpellLevel[0] = 2;
                    maxPerSpellLevel[1] = 1;
                    maxSpellLevel = 2;
                    break;
                case 4:
                    maxPerSpellLevel = new int[2];
                    maxPerSpellLevel[0] = 3;
                    maxPerSpellLevel[1] = 2;
                    maxSpellLevel = 2;
                    break;
                case 5:
                    maxPerSpellLevel = new int[3];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 2;
                    maxPerSpellLevel[2] = 1;
                    maxSpellLevel = 3;
                    break;
                case 6:
                    maxPerSpellLevel = new int[3];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 2;
                    maxPerSpellLevel[2] = 2;
                    maxSpellLevel = 3;
                    break;
                case 7:
                    maxPerSpellLevel = new int[4];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 3;
                    maxPerSpellLevel[2] = 2;
                    maxPerSpellLevel[3] = 1;
                    maxSpellLevel = 4;
                    break;
                case 8:
                    maxPerSpellLevel = new int[4];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 3;
                    maxPerSpellLevel[2] = 3;
                    maxPerSpellLevel[3] = 2;
                    maxSpellLevel = 4;
                    break;
                case 9:
                    maxPerSpellLevel = new int[5];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 3;
                    maxPerSpellLevel[2] = 3;
                    maxPerSpellLevel[3] = 2;
                    maxPerSpellLevel[4] = 1;
                    maxSpellLevel = 5;
                    break;
                case 10:
                    maxPerSpellLevel = new int[5];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 4;
                    maxPerSpellLevel[2] = 3;
                    maxPerSpellLevel[3] = 2;
                    maxPerSpellLevel[4] = 2;
                    maxSpellLevel = 5;
                    break;
                case 11:
                    maxPerSpellLevel = new int[5];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 4;
                    maxPerSpellLevel[2] = 4;
                    maxPerSpellLevel[3] = 3;
                    maxPerSpellLevel[4] = 3;
                    maxSpellLevel = 5;
                    break;
                case 12:
                    maxPerSpellLevel = new int[6];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 4;
                    maxPerSpellLevel[2] = 4;
                    maxPerSpellLevel[3] = 4;
                    maxPerSpellLevel[4] = 4;
                    maxPerSpellLevel[5] = 1;
                    maxSpellLevel = 6;
                    break;
                case 13:
                    maxPerSpellLevel = new int[6];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 4;
                    maxPerSpellLevel[4] = 4;
                    maxPerSpellLevel[5] = 2;
                    maxSpellLevel = 6;
                    break;
                case 14:
                    maxPerSpellLevel = new int[7];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 4;
                    maxPerSpellLevel[4] = 4;
                    maxPerSpellLevel[5] = 2;
                    maxPerSpellLevel[6] = 1;
                    maxSpellLevel = 7;
                    break;
                case 15:
                    maxPerSpellLevel = new int[7];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 2;
                    maxPerSpellLevel[6] = 1;
                    maxSpellLevel = 7;
                    break;
                case 16:
                    maxPerSpellLevel = new int[8];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 2;
                    maxPerSpellLevel[7] = 1;
                    maxSpellLevel = 8;
                    break;
                case 17:
                    maxPerSpellLevel = new int[8];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 2;
                    maxSpellLevel = 8;
                    break;
                case 18:
                    maxPerSpellLevel = new int[9];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 2;
                    maxPerSpellLevel[8] = 1;
                    maxSpellLevel = 9;
                    break;
                case 19:
                    maxPerSpellLevel = new int[9];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 3;
                    maxPerSpellLevel[8] = 1;
                    maxSpellLevel = 9;
                    break;
                case 20:
                    maxPerSpellLevel = new int[9];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 4;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 3;
                    maxPerSpellLevel[8] = 2;
                    maxSpellLevel = 9;
                    break;
            }

             MemorizedSpells = new List<Spell>();
        }
        void SetInitialMoney()
        {
            Random rand = new Random();
            int total = 0;
            total = (int)rand.Next(1, 5);
            total++;
            total *= 10;
            Money_Gold = total;
            Money_Silver = 0;
            Money_Copper = 0;
        }

        public bool LearnSpell()
        {
            bool result = false;
            return result;
        }
    }
}
