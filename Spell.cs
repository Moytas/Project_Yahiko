using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class Spell
    {
        public string Name { get; set; }
        public int School { get; set; }
        public int Spere { get; set; }
        public int Range { get; set; }
        
        public List<Items> Components = new List<Items>();
        public int Duration { get; set; }
        public int CastingTime { get; set; }
        public int AreaOfEffect { get; set; }
        public int SavingThrow { get; set; }
        public string Description { get; set; }


    }
}
