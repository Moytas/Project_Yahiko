using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class Proficiency
    {
        public enum Type
        {
            weapon,
            non_weapon
        };

        public Type ProfType;
        public string Name;
        public string Description;
        public string RelatedAbility;
        public int AbilityModifier;
    }
}
