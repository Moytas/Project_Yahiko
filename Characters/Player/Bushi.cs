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
