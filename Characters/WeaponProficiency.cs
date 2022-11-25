using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class WeaponProficiency : Proficiency
    {
        public int Penalty { get; set; }
        public string Description { get; set; }

        public WeaponProficiency(string name)
        {
            Name = name;
            //Cost = cost;
        }

        public WeaponProficiency(string name,string description)
        {
            Name = name;
            Description = description;
        }
    }
}
