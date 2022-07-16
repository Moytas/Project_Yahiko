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
    }
}
