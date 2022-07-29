using System.Collections.Generic;

namespace Project_Yahiko
{
    public class SavThrows
    {
        public enum VS
        {
            poison,
            rod,
            petrify,
            Breath,
            Spell
        };

        public Dictionary<VS, int> Values = new Dictionary<VS, int>();

        public SavThrows(int playerClass)
        {
            switch(playerClass)
            {
                case 1:
                    Values.Add(VS.poison, 1);
                    Values.Add(VS.rod, 1);
                    Values.Add(VS.petrify,1);
                    Values.Add(VS.Breath, 1);
                    Values.Add(VS.Spell,1);
                    break;
                case 2:
                    Values.Add(VS.poison, 1);
                    Values.Add(VS.rod, 1);
                    Values.Add(VS.petrify, 1);
                    Values.Add(VS.Breath, 1);
                    Values.Add(VS.Spell, 1);
                    break;
                case 3:
                    Values.Add(VS.poison, 1);
                    Values.Add(VS.rod, 1);
                    Values.Add(VS.petrify, 1);
                    Values.Add(VS.Breath, 1);
                    Values.Add(VS.Spell, 1);
                    break;
                case 4:
                    Values.Add(VS.poison, 1);
                    Values.Add(VS.rod, 1);
                    Values.Add(VS.petrify, 1);
                    Values.Add(VS.Breath, 1);
                    Values.Add(VS.Spell, 1);
                    break;
            }
        }

        public int GetValues(VS st)
        {
            int returnValue; 
            Values.TryGetValue(st, out returnValue);
            return returnValue;
        }

    }
}