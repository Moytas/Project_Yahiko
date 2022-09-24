using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Weight = 0;
        public int Cost_Copper, Cost_Silver, Cost_Gold; 
    }
}
