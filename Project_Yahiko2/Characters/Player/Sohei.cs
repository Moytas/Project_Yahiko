using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_Yahiko
{
    public class Sohei : Player
    {
        public SpellBook MySpellBook;
        public int maxSpellLevel;
        public int[] maxPerSpellLevel;
        public List<Spell> MemorizedSpells;
        public int TurnNum = 20;

        public enum TypeOfTurn
        {
            num,
            turn,
            death,
            nill
        };

        public Sohei(Player p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            CharacterClass = 3;
            XP = p.XP;
            XPToNext = p.XPToNext;
            CharacterStats = p.CharacterStats;
            EquipedArmor = p.EquipedArmor;
            EquipedWeapon = p.EquipedWeapon;
        }

        void SetInitialMoney()
        {
            Random rand = new Random();
            int total = 0;
           for(int i = 0; i < 3; i++)
            {
                total += (int)rand.Next(1, 7);
            }
            total *= 10;
            Money_Gold = total;
            Money_Silver = 0;
            Money_Copper = 0;
        }

        public int GetTurnNum(Undead.UndeadType undead)
        {
            if (GetTurnUndead(undead) == TypeOfTurn.num)
            {
                return TurnNum;
            }
            else
            {
                return -1;
            }
        }

        public bool AutoTurn(Undead.UndeadType undead)
        {
            if (GetTurnUndead(undead) == TypeOfTurn.turn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AutoDeath(Undead.UndeadType undead)
        {
            if (GetTurnUndead(undead) == TypeOfTurn.death)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public TypeOfTurn GetTurnUndead(Undead.UndeadType undead)
        {
            TypeOfTurn returnValue = TypeOfTurn.num;
            switch(Level)
            {
                case 1:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 2:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 3:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 4:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 5:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 6:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 7:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 8:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 9:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Special:
                            TurnNum = 20;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 10:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Special:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 11:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Special:
                            TurnNum = 19;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 12:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Special:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                case 13:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Special:
                            TurnNum = 16;
                            returnValue = TypeOfTurn.num;
                            break;
                        default:
                            returnValue = TypeOfTurn.nill;
                            break;
                    }
                    break;
                default:
                    switch (undead)
                    {
                        case Undead.UndeadType.Skeleton:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Zombie:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghoul:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Shadow:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wight:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Ghast:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Wraith:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.death;
                            break;
                        case Undead.UndeadType.Mummy:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Spectre:
                            TurnNum = 0;
                            returnValue = TypeOfTurn.turn;
                            break;
                        case Undead.UndeadType.Vampire:
                            TurnNum = 4;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Ghost:
                            TurnNum = 7;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Lich:
                            TurnNum = 10;
                            returnValue = TypeOfTurn.num;
                            break;
                        case Undead.UndeadType.Special:
                            TurnNum = 13;
                            returnValue = TypeOfTurn.num;
                            break;
                    }
                    break;
            }
            return returnValue;
        }

        public Sohei()
        {
            MySpellBook = new SpellBook(SpellBook.Type.Priest);
            switch (Level)
            {
                case 1:
                    maxSpellLevel = 1;
                    maxPerSpellLevel = new int[1];
                    maxPerSpellLevel[0] = 1;
                    break;
                case 2:
                    maxPerSpellLevel = new int[1];
                    maxPerSpellLevel[0] = 2;
                    maxSpellLevel = 1;
                    break;
                case 3:
                    maxPerSpellLevel = new int[2];
                    maxPerSpellLevel[0] = 2;
                    maxPerSpellLevel[1] = 1;
                    maxSpellLevel = 2;
                    break;
                case 4:
                    maxPerSpellLevel = new int[2];
                    maxPerSpellLevel[0] = 3;
                    maxPerSpellLevel[1] = 2;
                    maxSpellLevel = 2;
                    break;
                case 5:
                    maxPerSpellLevel = new int[3];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 2;
                    maxPerSpellLevel[2] = 1;
                    maxSpellLevel = 3;
                    break;
                case 6:
                    maxPerSpellLevel = new int[3];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 2;
                    maxPerSpellLevel[2] = 2;
                    maxSpellLevel = 3;
                    break;
                case 7:
                    maxPerSpellLevel = new int[4];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 3;
                    maxPerSpellLevel[2] = 2;
                    maxPerSpellLevel[3] = 1;
                    maxSpellLevel = 4;
                    break;
                case 8:
                    maxPerSpellLevel = new int[4];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 3;
                    maxPerSpellLevel[2] = 3;
                    maxPerSpellLevel[3] = 2;
                    maxSpellLevel = 4;
                    break;
                case 9:
                    maxPerSpellLevel = new int[5];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 3;
                    maxPerSpellLevel[2] = 3;
                    maxPerSpellLevel[3] = 2;
                    maxPerSpellLevel[4] = 1;
                    maxSpellLevel = 5;
                    break;
                case 10:
                    maxPerSpellLevel = new int[5];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 4;
                    maxPerSpellLevel[2] = 3;
                    maxPerSpellLevel[3] = 2;
                    maxPerSpellLevel[4] = 2;
                    maxSpellLevel = 5;
                    break;
                case 11:
                    maxPerSpellLevel = new int[5];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 4;
                    maxPerSpellLevel[2] = 4;
                    maxPerSpellLevel[3] = 3;
                    maxPerSpellLevel[4] = 3;
                    maxSpellLevel = 5;
                    break;
                case 12:
                    maxPerSpellLevel = new int[6];
                    maxPerSpellLevel[0] = 4;
                    maxPerSpellLevel[1] = 4;
                    maxPerSpellLevel[2] = 4;
                    maxPerSpellLevel[3] = 4;
                    maxPerSpellLevel[4] = 4;
                    maxPerSpellLevel[5] = 1;
                    maxSpellLevel = 6;
                    break;
                case 13:
                    maxPerSpellLevel = new int[6];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 4;
                    maxPerSpellLevel[4] = 4;
                    maxPerSpellLevel[5] = 2;
                    maxSpellLevel = 6;
                    break;
                case 14:
                    maxPerSpellLevel = new int[7];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 4;
                    maxPerSpellLevel[4] = 4;
                    maxPerSpellLevel[5] = 2;
                    maxPerSpellLevel[6] = 1;
                    maxSpellLevel = 7;
                    break;
                case 15:
                    maxPerSpellLevel = new int[7];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 2;
                    maxPerSpellLevel[6] = 1;
                    maxSpellLevel = 7;
                    break;
                case 16:
                    maxPerSpellLevel = new int[8];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 2;
                    maxPerSpellLevel[7] = 1;
                    maxSpellLevel = 8;
                    break;
                case 17:
                    maxPerSpellLevel = new int[8];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 2;
                    maxSpellLevel = 8;
                    break;
                case 18:
                    maxPerSpellLevel = new int[9];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 2;
                    maxPerSpellLevel[8] = 1;
                    maxSpellLevel = 9;
                    break;
                case 19:
                    maxPerSpellLevel = new int[9];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 3;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 3;
                    maxPerSpellLevel[8] = 1;
                    maxSpellLevel = 9;
                    break;
                case 20:
                    maxPerSpellLevel = new int[9];
                    maxPerSpellLevel[0] = 5;
                    maxPerSpellLevel[1] = 5;
                    maxPerSpellLevel[2] = 5;
                    maxPerSpellLevel[3] = 5;
                    maxPerSpellLevel[4] = 5;
                    maxPerSpellLevel[5] = 4;
                    maxPerSpellLevel[6] = 3;
                    maxPerSpellLevel[7] = 3;
                    maxPerSpellLevel[8] = 2;
                    maxSpellLevel = 9;
                    break;
            }

            AdjustSpellValues();

            MemorizedSpells = new List<Spell>();
        }

        void AdjustSpellValues()
        {
            if(CharacterStats.SpellLvlMax < maxSpellLevel)
            {
                maxSpellLevel = CharacterStats.SpellLvlMax;
            }
            else
            {
                if(CharacterStats.BonusSpell.Count != 0)
                {

                }
            }
        }
    }
}
