using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class Dice
    {
        private int result;
        public Dice(int min, int max)
        {
            Random rand = new Random();
            
            result = rand.Next(min, max);
        }

        public int GetResult(int min,int max)
        {
            return new Random().Next(min, max + 1);
        }

        public int GetResult()
        {
            return result;
        }
    }
}
