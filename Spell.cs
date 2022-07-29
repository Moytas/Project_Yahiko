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
        public int Sphere { get; set; }
        public int Range { get; set; }

        public SpellComponent Components;

        public int Duration { get; set; }
        public int CastingTime { get; set; }
        public int AreaOfEffect { get; set; }
        public int SavingThrow { get; set; }
        public string Description { get; set; }
        public int Level;

        public Spell(string name,int level,int school, int sphere,int range,bool verbal,bool somatic,bool material,List<Items> materials,int duration,int castTime,int AOE,int ST,string desc)
        {
            Name = name;
            Level = level;
            School = school;
            Sphere = sphere;
            Range = range;
            Components = new SpellComponent(verbal, somatic, material, materials);
            Duration = duration;
            CastingTime = castTime;
            AreaOfEffect = AOE;
            SavingThrow = ST;
            Description = desc;
        }
    }
}
