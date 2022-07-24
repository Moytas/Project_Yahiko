using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class DMOptions
    {
        public enum Clans
        {
            Oda,
            Tokugawa,
            Mori,
            Clan1,
            Clan2
        };
        public List<String> ClanNames;

        public void PopulateClanNames()
        {
            ClanNames = new List<string>();
            ClanNames.Add("Oda / Human");
            ClanNames.Add("Tokugawa / Elf");
            ClanNames.Add("Mori / Dwarf");
            ClanNames.Add("Ogami / Gnome");
            ClanNames.Add("Yagyu / Halfling");
            ClanNames.Add("Clanless / Half-Elf");
        }

        public enum Races
        {
            Human,
            Elf,
            Dwarf,
            Gnome,
            Halfling,
            Orc
        };

        public enum MonsterRaces
        {
            Orc,
            Human,
            Elf,
            Dwarf,
            Gnome,
            Halfling,
            Dragon,
            Undead
        };

        public int GetXPToNext(int playerClass,int playerLevel)
        {
            int returnValue = 0;
            switch(playerClass)
            {
                case 1:// warrior
                    switch(playerLevel)
                    {
                        case 1:
                            returnValue = 2000;
                            break;
                        case 2:
                            returnValue = 4000;
                            break;
                        case 3:
                            returnValue = 8000;
                            break;
                        case 4:
                            returnValue = 16000;
                            break;
                        case 5:
                            returnValue = 32000;
                            break;
                        case 6:
                            returnValue = 64000;
                            break;
                        case 7:
                            returnValue = 125000;
                            break;
                        case 8:
                            returnValue = 250000;
                            break;
                        case 9:
                            returnValue = 500000;
                            break;
                        case 10:
                            returnValue = 750000;
                            break;
                        case 11:
                            returnValue = 1000000;
                            break;
                        case 12:
                            returnValue = 1250000;
                            break;
                        case 13:
                            returnValue = 1500000;
                            break;
                        case 14:
                            returnValue = 1750000;
                            break;
                        case 15:
                            returnValue = 2000000;
                            break;
                        case 16:
                            returnValue = 2250000;
                            break;
                        case 17:
                            returnValue = 2500000;
                            break;
                        case 18:
                            returnValue = 2750000;
                            break;
                        case 19:
                            returnValue = 3000000;
                            break;
                    }
                    break;
                case 2:// rogue
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 1250;
                            break;
                        case 2:
                            returnValue = 2500;
                            break;
                        case 3:
                            returnValue = 5000;
                            break;
                        case 4:
                            returnValue = 10000;
                            break;
                        case 5:
                            returnValue = 20000;
                            break;
                        case 6:
                            returnValue = 40000;
                            break;
                        case 7:
                            returnValue = 70000;
                            break;
                        case 8:
                            returnValue = 110000;
                            break;
                        case 9:
                            returnValue = 160000;
                            break;
                        case 10:
                            returnValue = 220000;
                            break;
                        case 11:
                            returnValue = 440000;
                            break;
                        case 12:
                            returnValue = 660000;
                            break;
                        case 13:
                            returnValue = 880000;
                            break;
                        case 14:
                            returnValue = 1100000;
                            break;
                        case 15:
                            returnValue = 1320000;
                            break;
                        case 16:
                            returnValue = 1540000;
                            break;
                        case 17:
                            returnValue = 1760000;
                            break;
                        case 18:
                            returnValue = 1980000;
                            break;
                        case 19:
                            returnValue = 2200000;
                            break;
                    }
                    break;
                case 3:// priest
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 1500;
                            break;
                        case 2:
                            returnValue = 3000;
                            break;
                        case 3:
                            returnValue = 6000;
                            break;
                        case 4:
                            returnValue = 13000;
                            break;
                        case 5:
                            returnValue = 27500;
                            break;
                        case 6:
                            returnValue = 55000;
                            break;
                        case 7:
                            returnValue = 110000;
                            break;
                        case 8:
                            returnValue = 225000;
                            break;
                        case 9:
                            returnValue = 450000;
                            break;
                        case 10:
                            returnValue = 675000;
                            break;
                        case 11:
                            returnValue = 900000;
                            break;
                        case 12:
                            returnValue = 1125000;
                            break;
                        case 13:
                            returnValue = 1350000;
                            break;
                        case 14:
                            returnValue = 1575000;
                            break;
                        case 15:
                            returnValue = 1800000;
                            break;
                        case 16:
                            returnValue = 2025000;
                            break;
                        case 17:
                            returnValue = 2250000;
                            break;
                        case 18:
                            returnValue = 2475000;
                            break;
                        case 19:
                            returnValue = 2700000;
                            break;
                    }
                    break;
                case 4:// mage
                    switch (playerLevel)
                    {
                        case 1:
                            returnValue = 2500;
                            break;
                        case 2:
                            returnValue = 5000;
                            break;
                        case 3:
                            returnValue = 10000;
                            break;
                        case 4:
                            returnValue = 20000;
                            break;
                        case 5:
                            returnValue = 40000;
                            break;
                        case 6:
                            returnValue = 60000;
                            break;
                        case 7:
                            returnValue = 90000;
                            break;
                        case 8:
                            returnValue = 135000;
                            break;
                        case 9:
                            returnValue = 250000;
                            break;
                        case 10:
                            returnValue = 375000;
                            break;
                        case 11:
                            returnValue = 750000;
                            break;
                        case 12:
                            returnValue = 1125000;
                            break;
                        case 13:
                            returnValue = 1500000;
                            break;
                        case 14:
                            returnValue = 1875000;
                            break;
                        case 15:
                            returnValue = 2250000;
                            break;
                        case 16:
                            returnValue = 2625000;
                            break;
                        case 17:
                            returnValue = 3000000;
                            break;
                        case 18:
                            returnValue = 3375000;
                            break;
                        case 19:
                            returnValue = 3750000;
                            break;
                    }
                    break;
            }
            return returnValue;
        }
    }
}
