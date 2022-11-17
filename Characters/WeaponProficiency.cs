using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class WeaponProficiency : Proficiency
    {
        public int Cost { get; set; }
        public int Penalty { get; set; }

        public WeaponProficiency(string name)
        {
            Name = name;
        }

        public WeaponProficiency(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
