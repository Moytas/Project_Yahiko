using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class Table_Shinobi
    {
        public Dictionary<ThiefSkills.Skills, int> ThiefSkills = new Dictionary<ThiefSkills.Skills, int>();
        public Table_Shinobi()
        {
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.CW, 60);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.OL, 10);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.PP, 15);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.FRT, 5);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.MS, 10);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.HS, 5);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.DN, 15);
            ThiefSkills.Add(Project_Yahiko.ThiefSkills.Skills.RL, 0);
        }

        public void SetAdjastments_ByDex(int dex)
        {
            switch(dex)
            {
                case 9:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] -= 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] -= 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] -= 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] -= 20;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] -= 10;
                    break;
                case 10:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] -= 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] -= 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] -= 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] -= 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] -= 5;
                    break;
                case 11:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] -= 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] -= 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] -= 10;
                    break;
                case 12:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] -= 5;
                    break;
                case 16:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 5;
                    break;
                case 17:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 5;
                    break;
                case 18:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 10;
                    break;
                case 19:
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] += 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 20;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] += 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 15;
                    break;
            }
        }

        public int GetSkillValue(ThiefSkills.Skills skill)
        {
            int returnValue = 0;
            ThiefSkills.TryGetValue(skill, out returnValue);
            return returnValue;
        }

        public void SetAdjastments_ByRace(int race)
        {
            // 0 = Human 1 = Elf 2 = Dwarf 3 = Gnome 4 = Halfling 5 = Half Elf
            switch (race)
            {
                case 0: // Human
                    break;
                case 1: // Elf
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] -= 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.DN] += 5;
                    break;
                case 2: // Dwarf
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] += 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.CW] -= 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.RL] -= 5;
                    break;
                case 3: // Gnome
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.DN] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.CW] -= 15;
                    break;
                case 4: // Halfling
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.OL] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.FRT] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.MS] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.DN] += 5;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.CW] -= 15;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.RL] -= 5;
                    break;
                case 5: // Half-Elf
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.PP] += 10;
                    ThiefSkills[Project_Yahiko.ThiefSkills.Skills.HS] += 5;
                    break;
            }
        }
    }
}
