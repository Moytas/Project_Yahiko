using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahiko
{
    public class ThiefSkills
    {
        public ThiefSkills()
        {
            SkillValues.Add(Skills.PP, 15);
            SkillValues.Add(Skills.OL, 10);
            SkillValues.Add(Skills.FRT, 5);
            SkillValues.Add(Skills.MS, 10);
            SkillValues.Add(Skills.HS, 5);
            SkillValues.Add(Skills.DN, 15);
            SkillValues.Add(Skills.CW, 60);
            SkillValues.Add(Skills.RL, 0);
        }

        public enum Skills
        {
            PP,
            OL,
            FRT,
            MS,
            HS,
            DN,
            CW,
            RL
        };

        Dictionary<Skills, int> SkillValues = new Dictionary<Skills, int>();

        public void SetValues(Skills skill,int value)
        {
            try
            {
                SkillValues[skill] = value;
            }
            catch
            { }
        }

        public int GetValue(Skills skill)
        {
            int returnValue = 0;
            try
            {
                SkillValues.TryGetValue(skill, out returnValue);
            }
            catch
            {

            }

            if(returnValue < 0)
            {
                returnValue = 0;
                SetValues(skill, returnValue);
            }
            
            return returnValue;
        }
    }
}
