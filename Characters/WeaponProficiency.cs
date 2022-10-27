using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class WeaponProficiency : Proficiency
    {
        public int Cost;

        public WeaponProficiency(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
