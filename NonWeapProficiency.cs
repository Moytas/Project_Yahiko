using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class NonWeapProficiency : Proficiency
    {
        public enum Type
        {
            General,
            Warrior,
            Thief,
            Mage,
            Priest
        };

        public Type ProfType;
        public int RequiredSlots;
        public string Ability;
        public int Modifier;

        public NonWeapProficiency(string name, string description, Type type,int reqSlot,string ability,int mod)
        {
            Name = name;
            Description = description;
            ProfType = type;
            RequiredSlots = reqSlot;
            Ability = ability;
            Modifier = mod;
        }

    }
}
