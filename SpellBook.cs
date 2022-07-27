using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class SpellBook
    {
        private Player player;
        public enum Type
        {
            Mage,
            Priest
        };

        public SpellBook(Type _typeOfSpellbook,ref Player _p)
        {
            player = _p;
            switch(_typeOfSpellbook)
            {
                case Type.Mage:
                    break;
                case Type.Priest:
                    break;
            }
        }

        public void AddSpellToBook(Spell _spell)
        {
            
        }


    }
}
