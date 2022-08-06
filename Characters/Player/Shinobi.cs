﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_Yahiko
{
    public class Shinobi : Player
    {
        public int BackstabModifier = 2;

        private void AdjustBackstab()
        {
            if (Level > 13)
            {
                BackstabModifier = 5;
            }
            else if (Level > 8)
            {
                BackstabModifier = 4;
            }
            else if (Level > 4)
            {
                BackstabModifier = 3;
            }
            else
            {
                BackstabModifier = 2;
            }
        }

        void SetInitialMoney()
        {
            Random rand = new Random();
            int total = 0;
            total = (int)rand.Next(1, 7);
            Thread.Sleep(rand.Next(1, 10));
            total += (int)rand.Next(1, 7);
            total *= 10;
            Money_Gold = total;
            Money_Silver = 0;
            Money_Copper = 0;
        }
    }
}