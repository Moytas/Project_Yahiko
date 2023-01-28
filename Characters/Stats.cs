using System.Collections.Generic;

namespace Project_Yahiko
{
    public class Stats
    {
        public int Initial_Str { get; set; }
        public int ExtraStr { get; set; }
        public int Initial_Dex { get; set; }
        public int Initial_Con { get; set; }
        public int Initial_Int { get; set; }
        public int Initial_Wis { get; set; }
        public int Initial_Cha { get; set; }
        public int Current_Str { get; set; }
        public int Current_Dex { get; set; }
        public int Current_Con { get; set; }
        public int Current_Int { get; set; }
        public int Current_Wis { get; set; }
        public int Current_Cha { get; set; }

        public int HitProb, DmgAdj, WeightAllow, MaxPres, OpenDoors,OpenMagicDoors, BendBars;
        public int ReactionAdj, MissileAdj, DefenceAdj;
        public int HPAdj, SystemShock, ResurectionSurvive, PoisonSave, Regen;
        public int NumLanguages, SpellLvlMax, ChanceToLearn, NumMaxSpellsPerLevel, IllusionImmunity;
        public int MagicDefAdj, ChanceOfSpellFail;
        public List<int> BonusSpell = new List<int>();
        public List<string> SpellImmunity = new List<string>();
        public int NumOfHenchmen, LoyaltyBase, ReactionAdjCha;

        public void SetAbilities(int stat,string statName,int extraStr = 0)
        {
            OpenMagicDoors = 0;
            switch(statName)
            {
                case "STR":
                    switch (stat)
                    {
                        case 1:
                            HitProb = -5;
                            DmgAdj = -4;
                            WeightAllow = 1;
                            MaxPres = 3;
                            OpenDoors = 1;
                            BendBars = 0;
                            break;
                        case 2:
                            HitProb = -3;
                            DmgAdj = -2;
                            WeightAllow = 1;
                            MaxPres = 5;
                            OpenDoors = 1;
                            BendBars = 0;
                            break;
                        case 3:
                            HitProb = -3;
                            DmgAdj = -1;
                            WeightAllow = 5;
                            MaxPres = 10;
                            OpenDoors = 2;
                            BendBars = 0;
                            break;
                        case 4:
                            HitProb = -2;
                            DmgAdj = -1;
                            WeightAllow = 10;
                            MaxPres = 25;
                            OpenDoors = 3;
                            BendBars = 0;
                            break;
                        case 5:
                            HitProb = -2;
                            DmgAdj = -1;
                            WeightAllow = 10;
                            MaxPres = 25;
                            OpenDoors = 3;
                            BendBars = 0;
                            break;
                        case 6:
                            HitProb = -1;
                            DmgAdj = 0;
                            WeightAllow = 20;
                            MaxPres = 55;
                            OpenDoors = 4;
                            BendBars = 0;
                            break;
                        case 7:
                            HitProb = -1;
                            DmgAdj = 0;
                            WeightAllow = 20;
                            MaxPres = 55;
                            OpenDoors = 4;
                            BendBars = 0;
                            break;
                        case 8:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 35;
                            MaxPres = 90;
                            OpenDoors = 5;
                            BendBars = 1;
                            break;
                        case 9:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 35;
                            MaxPres = 90;
                            OpenDoors = 5;
                            BendBars = 1;
                            break;
                        case 10:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 40;
                            MaxPres = 115;
                            OpenDoors = 6;
                            BendBars = 2;
                            break;
                        case 11:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 40;
                            MaxPres = 115;
                            OpenDoors = 6;
                            BendBars = 2;
                            break;
                        case 12:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 45;
                            MaxPres = 140;
                            OpenDoors = 7;
                            BendBars = 4;
                            break;
                        case 13:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 45;
                            MaxPres = 140;
                            OpenDoors = 7;
                            BendBars = 4;
                            break;
                        case 14:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 55;
                            MaxPres = 170;
                            OpenDoors = 8;
                            BendBars = 7;
                            break;
                        case 15:
                            HitProb = 0;
                            DmgAdj = 0;
                            WeightAllow = 55;
                            MaxPres = 170;
                            OpenDoors = 8;
                            BendBars = 7;
                            break;
                        case 16:
                            HitProb = 0;
                            DmgAdj = 1;
                            WeightAllow = 70;
                            MaxPres = 195;
                            OpenDoors = 9;
                            BendBars = 10;
                            break;
                        case 17:
                            HitProb = 1;
                            DmgAdj = 1;
                            WeightAllow = 85;
                            MaxPres = 220;
                            OpenDoors = 10;
                            BendBars = 13;
                            break;
                        case 18:
                            switch (extraStr)
                            {
                                case 0:
                                    HitProb = 1;
                                    DmgAdj = 2;
                                    WeightAllow = 110;
                                    MaxPres = 255;
                                    OpenDoors = 11;
                                    BendBars = 16;
                                    break;
                                case 1:
                                    HitProb = 1;
                                    DmgAdj = 3;
                                    WeightAllow = 135;
                                    MaxPres = 280;
                                    OpenDoors = 12;
                                    BendBars = 20;
                                    break;
                                case 2:
                                    HitProb = 2;
                                    DmgAdj = 3;
                                    WeightAllow = 160;
                                    MaxPres = 305;
                                    OpenDoors = 13;
                                    BendBars = 25;
                                    break;
                                case 3:
                                    HitProb = 2;
                                    DmgAdj = 4;
                                    WeightAllow = 185;
                                    MaxPres = 330;
                                    OpenDoors = 14;
                                    BendBars = 30;
                                    break;
                                case 4:
                                    HitProb = 2;
                                    DmgAdj = 5;
                                    WeightAllow = 235;
                                    MaxPres = 380;
                                    OpenDoors = 15;
                                    OpenMagicDoors = 3;
                                    BendBars = 35;
                                    break;
                                case 5:
                                    HitProb = 3;
                                    DmgAdj = 6;
                                    WeightAllow = 335;
                                    MaxPres = 480;
                                    OpenDoors = 16;
                                    OpenMagicDoors = 6;
                                    BendBars = 40;
                                    break;
                            }
                            break;
                        case 19:
                            HitProb = 3;
                            DmgAdj = 7;
                            WeightAllow = 485;
                            MaxPres = 640;
                            OpenDoors = 16;
                            OpenMagicDoors = 8;
                            BendBars = 50;
                            break;
                        case 20:
                            HitProb = 3;
                            DmgAdj = 8;
                            WeightAllow = 535;
                            MaxPres = 700;
                            OpenDoors = 17;
                            OpenMagicDoors = 10;
                            BendBars = 60;
                            break;
                        case 21:
                            HitProb = 4;
                            DmgAdj = 9;
                            WeightAllow = 635;
                            MaxPres = 810;
                            OpenDoors = 17;
                            OpenMagicDoors = 12;
                            BendBars = 70;
                            break;
                        case 22:
                            HitProb = 4;
                            DmgAdj = 10;
                            WeightAllow = 785;
                            MaxPres = 970;
                            OpenDoors = 18;
                            OpenMagicDoors = 14;
                            BendBars = 80;
                            break;
                        case 23:
                            HitProb = 5;
                            DmgAdj = 11;
                            WeightAllow = 935;
                            MaxPres = 1135;
                            OpenDoors = 18;
                            OpenMagicDoors = 16;
                            BendBars = 90;
                            break;
                        case 24:
                            HitProb = 6;
                            DmgAdj = 12;
                            WeightAllow = 1235;
                            MaxPres = 1440;
                            OpenDoors = 19;
                            OpenMagicDoors = 17;
                            BendBars = 95;
                            break;
                        case 25:
                            HitProb = 7;
                            DmgAdj = 14;
                            WeightAllow = 1535;
                            MaxPres = 1750;
                            OpenDoors = 19;
                            OpenMagicDoors = 18;
                            BendBars = 99;
                            break;
                    }
                    break;
                case "DEX":
                    switch(stat)
                    {
                        case 1:
                            ReactionAdj = -6;
                            MissileAdj = -6;
                            DefenceAdj = 5;
                            break;
                        case 2:
                            ReactionAdj = -4;
                            MissileAdj = -4;
                            DefenceAdj = 5;
                            break;
                        case 3:
                            ReactionAdj = -3;
                            MissileAdj = -3;
                            DefenceAdj = 4;
                            break;
                        case 4:
                            ReactionAdj = -2;
                            MissileAdj = -2;
                            DefenceAdj = 3;
                            break;
                        case 5:
                            ReactionAdj = -1;
                            MissileAdj = -1;
                            DefenceAdj = 2;
                            break;
                        case 6:
                            ReactionAdj = 0;
                            MissileAdj = 0;
                            DefenceAdj = 1;
                            break;
                        case 15:
                            ReactionAdj = 0;
                            MissileAdj = 0;
                            DefenceAdj = -1;
                            break;
                        case 16:
                            ReactionAdj = 1;
                            MissileAdj = 1;
                            DefenceAdj = -2;
                            break;
                        case 17:
                            ReactionAdj = 2;
                            MissileAdj = 2;
                            DefenceAdj = -3;
                            break;
                        case 18:
                            ReactionAdj = 2;
                            MissileAdj = 2;
                            DefenceAdj = -4;
                            break;
                        case 19:
                            ReactionAdj = 3;
                            MissileAdj = 3;
                            DefenceAdj = -4;
                            break;
                        case 20:
                            ReactionAdj = 3;
                            MissileAdj = 3;
                            DefenceAdj = -4;
                            break;
                        case 21:
                            ReactionAdj = 4;
                            MissileAdj = 4;
                            DefenceAdj = -5;
                            break;
                        case 22:
                            ReactionAdj = 4;
                            MissileAdj = 4;
                            DefenceAdj = -5;
                            break;
                        case 23:
                            ReactionAdj = 4;
                            MissileAdj = 4;
                            DefenceAdj = -5;
                            break;
                        case 24:
                            ReactionAdj = 5;
                            MissileAdj = 5;
                            DefenceAdj = -6;
                            break;
                        case 25:
                            ReactionAdj = 5;
                            MissileAdj = 5;
                            DefenceAdj = -6;
                            break;
                        default:
                            ReactionAdj = 0;
                            MissileAdj = 0;
                            DefenceAdj = 0;
                            break;
                    }
                    break;
                case "CON":
                    switch(stat)
                    {
                        case 1:
                            HPAdj = -3;
                            SystemShock = 25;
                            ResurectionSurvive = 30;
                            PoisonSave = -2;
                            Regen = 0;
                            break;
                        case 2:
                            HPAdj = -2;
                            SystemShock = 30;
                            ResurectionSurvive = 35;
                            PoisonSave = -1;
                            Regen = 0;
                            break;
                        case 3:
                            HPAdj = -2;
                            SystemShock = 35;
                            ResurectionSurvive = 40;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 4:
                            HPAdj = -1;
                            SystemShock = 40;
                            ResurectionSurvive = 45;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 5:
                            HPAdj = -1;
                            SystemShock = 45;
                            ResurectionSurvive = 50;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 6:
                            HPAdj = -1;
                            SystemShock = 50;
                            ResurectionSurvive = 55;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 7:
                            HPAdj = -1;
                            SystemShock = 55;
                            ResurectionSurvive = 60;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 8:
                            HPAdj = 0;
                            SystemShock = 60;
                            ResurectionSurvive = 65;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 9:
                            HPAdj = 0;
                            SystemShock = 65;
                            ResurectionSurvive = 70;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 10:
                            HPAdj = 0;
                            SystemShock = 70;
                            ResurectionSurvive = 75;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 11:
                            HPAdj = 0;
                            SystemShock = 75;
                            ResurectionSurvive = 80;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 12:
                            HPAdj = 0;
                            SystemShock = 80;
                            ResurectionSurvive = 85;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 13:
                            HPAdj = 0;
                            SystemShock = 85;
                            ResurectionSurvive = 90;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 14:
                            HPAdj = 0;
                            SystemShock = 88;
                            ResurectionSurvive = 92;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 15:
                            HPAdj = 1;
                            SystemShock = 90;
                            ResurectionSurvive = 94;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 16:
                            HPAdj = 2;
                            SystemShock = 95;
                            ResurectionSurvive = 96;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 17:
                            HPAdj = 2;
                            SystemShock = 97;
                            ResurectionSurvive = 98;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 18:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 0;
                            Regen = 0;
                            break;
                        case 19:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 1;
                            Regen = 0;
                            break;
                        case 20:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 1;
                            Regen = 6;
                            break;
                        case 21:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 2;
                            Regen = 5;
                            break;
                        case 22:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 2;
                            Regen = 4;
                            break;
                        case 23:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 3;
                            Regen = 3;
                            break;
                        case 24:
                            HPAdj = 2;
                            SystemShock = 99;
                            ResurectionSurvive = 100;
                            PoisonSave = 3;
                            Regen = 2;
                            break;
                        case 25:
                            HPAdj = 2;
                            SystemShock = 100;
                            ResurectionSurvive = 100;
                            PoisonSave = 4;
                            Regen = 1;
                            break;
                    }
                    break;
                case "INT":
                    switch(stat)
                    {
                        case 1:
                            NumLanguages = 0;
                            SpellLvlMax = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 2:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 3:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            ChanceToLearn = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 4:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            ChanceToLearn = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 5:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            ChanceToLearn = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 6:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            ChanceToLearn = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 7:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            ChanceToLearn = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 8:
                            NumLanguages = 1;
                            SpellLvlMax = 0;
                            ChanceToLearn = 0;
                            NumMaxSpellsPerLevel = 0;
                            IllusionImmunity = 0;
                            break;
                        case 9:
                            NumLanguages = 2;
                            SpellLvlMax = 4;
                            ChanceToLearn = 35;
                            NumMaxSpellsPerLevel = 6;
                            IllusionImmunity = 0;
                            break;
                        case 10:
                            NumLanguages = 2;
                            SpellLvlMax = 5;
                            ChanceToLearn = 40;
                            NumMaxSpellsPerLevel = 7;
                            IllusionImmunity = 0;
                            break;
                        case 11:
                            NumLanguages = 2;
                            SpellLvlMax = 5;
                            ChanceToLearn = 45;
                            NumMaxSpellsPerLevel = 7;
                            IllusionImmunity = 0;
                            break;
                        case 12:
                            NumLanguages = 3;
                            SpellLvlMax = 6;
                            ChanceToLearn = 50;
                            NumMaxSpellsPerLevel = 7;
                            IllusionImmunity = 0;
                            break;
                        case 13:
                            NumLanguages = 3;
                            SpellLvlMax = 6;
                            ChanceToLearn = 55;
                            NumMaxSpellsPerLevel = 9;
                            IllusionImmunity = 0;
                            break;
                        case 14:
                            NumLanguages = 4;
                            SpellLvlMax = 7;
                            ChanceToLearn = 60;
                            NumMaxSpellsPerLevel = 9;
                            IllusionImmunity = 0;
                            break;
                        case 15:
                            NumLanguages = 4;
                            SpellLvlMax = 7;
                            ChanceToLearn = 65;
                            NumMaxSpellsPerLevel = 11;
                            IllusionImmunity = 0;
                            break;
                        case 16:
                            NumLanguages = 5;
                            SpellLvlMax = 8;
                            ChanceToLearn = 70;
                            NumMaxSpellsPerLevel = 11;
                            IllusionImmunity = 0;
                            break;
                        case 17:
                            NumLanguages = 6;
                            SpellLvlMax = 8;
                            ChanceToLearn = 75;
                            NumMaxSpellsPerLevel = 14;
                            IllusionImmunity = 0;
                            break;
                        case 18:
                            NumLanguages = 7;
                            SpellLvlMax = 9;
                            ChanceToLearn = 85;
                            NumMaxSpellsPerLevel = 18;
                            IllusionImmunity = 0;
                            break;
                        case 19:
                            NumLanguages = 8;
                            SpellLvlMax = 9;
                            ChanceToLearn = 95;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 1;
                            break;
                        case 20:
                            NumLanguages = 9;
                            SpellLvlMax = 9;
                            ChanceToLearn = 96;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 2;
                            break;
                        case 21:
                            NumLanguages = 10;
                            SpellLvlMax = 9;
                            ChanceToLearn = 97;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 3;
                            break;
                        case 22:
                            NumLanguages = 11;
                            SpellLvlMax = 9;
                            ChanceToLearn = 98;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 4;
                            break;
                        case 23:
                            NumLanguages = 12;
                            SpellLvlMax = 9;
                            ChanceToLearn = 99;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 5;
                            break;
                        case 24:
                            NumLanguages = 15;
                            SpellLvlMax = 9;
                            ChanceToLearn = 100;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 6;
                            break;
                        case 25:
                            NumLanguages = 20;
                            SpellLvlMax = 9;
                            ChanceToLearn = 100;
                            NumMaxSpellsPerLevel = 100;
                            IllusionImmunity = 7;
                            break;
                    }
                    break;
                case "WIS":
                    switch(stat)
                    {
                        case 1:
                            MagicDefAdj = -6;
                            //BonusSpell = { };
                            ChanceOfSpellFail = 80;
                            //SpellImmunity = 0;
                            break;
                        case 2:
                            MagicDefAdj = -4;
                           // BonusSpell = 0;
                            ChanceOfSpellFail = 60;
                            //SpellImmunity = 0;
                            break;
                        case 3:
                            MagicDefAdj = -3;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 50;
                            //SpellImmunity = 0;
                            break;
                        case 4:
                            MagicDefAdj = -2;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 45;
                            //SpellImmunity = 0;
                            break;
                        case 5:
                            MagicDefAdj = -1;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 40;
                            //SpellImmunity = 0;
                            break;
                        case 6:
                            MagicDefAdj = -1;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 35;
                            //SpellImmunity = 0;
                            break;
                        case 7:
                            MagicDefAdj = -1;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 30;
                            //SpellImmunity = 0;
                            break;
                        case 8:
                            MagicDefAdj = 0;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 25;
                            //SpellImmunity = 0;
                            break;
                        case 9:
                            MagicDefAdj = 0;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 20;
                            //SpellImmunity = 0;
                            break;
                        case 10:
                            MagicDefAdj = 0;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 15;
                            //SpellImmunity = 0;
                            break;
                        case 11:
                            MagicDefAdj = 0;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 10;
                            //SpellImmunity = 0;
                            break;
                        case 12:
                            MagicDefAdj = 0;
                            //BonusSpell = 0;
                            ChanceOfSpellFail = 5;
                            //SpellImmunity = 0;
                            break;
                        case 13:
                            MagicDefAdj = 0;
                            BonusSpell.Add(1);
                            ChanceOfSpellFail = 0;
                            //SpellImmunity = 0;
                            break;
                        case 14:
                            MagicDefAdj = 0;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            ChanceOfSpellFail = 0;
                            //SpellImmunity = 0;
                            break;
                        case 15:
                            MagicDefAdj = 1;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            ChanceOfSpellFail = 0;
                            //SpellImmunity = 0;
                            break;
                        case 16:
                            MagicDefAdj = 2;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            ChanceOfSpellFail = 0;
                            //SpellImmunity = 0;
                            break;
                        case 17:
                            MagicDefAdj = 3;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            ChanceOfSpellFail = 0;
                            //SpellImmunity = 0;
                            break;
                        case 18:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            ChanceOfSpellFail = 0;
                            //SpellImmunity = 0;
                            break;
                        case 19:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            break;
                        case 20:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            SpellImmunity.Add("Forget");
                            SpellImmunity.Add("Ray Of Enfeeblement");
                            SpellImmunity.Add("Scare");
                            break;
                        case 21:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(5);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            SpellImmunity.Add("Forget");
                            SpellImmunity.Add("Ray Of Enfeeblement");
                            SpellImmunity.Add("Scare");
                            SpellImmunity.Add("Fear");
                            break;
                        case 22:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(5);
                            BonusSpell.Add(5);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            SpellImmunity.Add("Forget");
                            SpellImmunity.Add("Ray Of Enfeeblement");
                            SpellImmunity.Add("Scare");
                            SpellImmunity.Add("Fear");
                            SpellImmunity.Add("Charm Monster");
                            SpellImmunity.Add("Confusion");
                            SpellImmunity.Add("Emotion");
                            SpellImmunity.Add("Fumble");
                            SpellImmunity.Add("Suggestion");
                            break;
                        case 23:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(5);
                            BonusSpell.Add(5);
                            BonusSpell.Add(6);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            SpellImmunity.Add("Forget");
                            SpellImmunity.Add("Ray Of Enfeeblement");
                            SpellImmunity.Add("Scare");
                            SpellImmunity.Add("Fear");
                            SpellImmunity.Add("Charm Monster");
                            SpellImmunity.Add("Confusion");
                            SpellImmunity.Add("Emotion");
                            SpellImmunity.Add("Fumble");
                            SpellImmunity.Add("Suggestion");
                            SpellImmunity.Add("Chaos");
                            SpellImmunity.Add("Feeblemind");
                            SpellImmunity.Add("Hold Monster");
                            SpellImmunity.Add("Magic Jar");
                            SpellImmunity.Add("Quest");
                            break;
                        case 24:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(5);
                            BonusSpell.Add(5);
                            BonusSpell.Add(5);
                            BonusSpell.Add(6);
                            BonusSpell.Add(6);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            SpellImmunity.Add("Forget");
                            SpellImmunity.Add("Ray Of Enfeeblement");
                            SpellImmunity.Add("Scare");
                            SpellImmunity.Add("Fear");
                            SpellImmunity.Add("Charm Monster");
                            SpellImmunity.Add("Confusion");
                            SpellImmunity.Add("Emotion");
                            SpellImmunity.Add("Fumble");
                            SpellImmunity.Add("Suggestion");
                            SpellImmunity.Add("Chaos");
                            SpellImmunity.Add("Feeblemind");
                            SpellImmunity.Add("Hold Monster");
                            SpellImmunity.Add("Magic Jar");
                            SpellImmunity.Add("Quest");
                            SpellImmunity.Add("Mass Suggestion");
                            SpellImmunity.Add("Geas");
                            SpellImmunity.Add("Rod Of Rulership");
                            break;
                        case 25:
                            MagicDefAdj = 4;
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(1);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(2);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(3);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(4);
                            BonusSpell.Add(5);
                            BonusSpell.Add(5);
                            BonusSpell.Add(6);
                            BonusSpell.Add(6);
                            BonusSpell.Add(7);
                            ChanceOfSpellFail = 0;

                            SpellImmunity.Add("Cause Fear");
                            SpellImmunity.Add("Charm Person");
                            SpellImmunity.Add("Command");
                            SpellImmunity.Add("Friends");
                            SpellImmunity.Add("Hypnotism");
                            SpellImmunity.Add("Forget");
                            SpellImmunity.Add("Ray Of Enfeeblement");
                            SpellImmunity.Add("Scare");
                            SpellImmunity.Add("Fear");
                            SpellImmunity.Add("Charm Monster");
                            SpellImmunity.Add("Confusion");
                            SpellImmunity.Add("Emotion");
                            SpellImmunity.Add("Fumble");
                            SpellImmunity.Add("Suggestion");
                            SpellImmunity.Add("Chaos");
                            SpellImmunity.Add("Feeblemind");
                            SpellImmunity.Add("Hold Monster");
                            SpellImmunity.Add("Magic Jar");
                            SpellImmunity.Add("Quest");
                            SpellImmunity.Add("Antipathy");
                            SpellImmunity.Add("Sympathy");
                            SpellImmunity.Add("Death Spell");
                            SpellImmunity.Add("Mass Charm");
                            break;
                    }
                    break;
                case "CHA":
                    switch(stat)
                    {
                        case 1:
                            NumOfHenchmen = 0;
                            LoyaltyBase = -8;
                            ReactionAdjCha = -7;
                            break;
                        case 2:
                            NumOfHenchmen = 1;
                            LoyaltyBase = -7;
                            ReactionAdjCha = -6;
                            break;
                        case 3:
                            NumOfHenchmen = 1;
                            LoyaltyBase = -6;
                            ReactionAdjCha = -5;
                            break;
                        case 4:
                            NumOfHenchmen = 1;
                            LoyaltyBase = -5;
                            ReactionAdjCha = -4;
                            break;
                        case 5:
                            NumOfHenchmen = 2;
                            LoyaltyBase = -4;
                            ReactionAdjCha = -3;
                            break;
                        case 6:
                            NumOfHenchmen = 2;
                            LoyaltyBase = -3;
                            ReactionAdjCha = -2;
                            break;
                        case 7:
                            NumOfHenchmen = 3;
                            LoyaltyBase = -2;
                            ReactionAdjCha = -1;
                            break;
                        case 8:
                            NumOfHenchmen = 3;
                            LoyaltyBase = -1;
                            ReactionAdjCha = 0;
                            break;
                        case 9:
                            NumOfHenchmen = 4;
                            LoyaltyBase = 0;
                            ReactionAdjCha = 0;
                            break;
                        case 10:
                            NumOfHenchmen = 4;
                            LoyaltyBase = 0;
                            ReactionAdjCha = 0;
                            break;
                        case 11:
                            NumOfHenchmen = 4;
                            LoyaltyBase = 0;
                            ReactionAdjCha = 0;
                            break;
                        case 12:
                            NumOfHenchmen = 5;
                            LoyaltyBase = 0;
                            ReactionAdjCha = 0;
                            break;
                        case 13:
                            NumOfHenchmen = 5;
                            LoyaltyBase = 0;
                            ReactionAdjCha = 1;
                            break;
                        case 14:
                            NumOfHenchmen = 6;
                            LoyaltyBase = 1;
                            ReactionAdjCha = 2;
                            break;
                        case 15:
                            NumOfHenchmen = 7;
                            LoyaltyBase = 3;
                            ReactionAdjCha = 3;
                            break;
                        case 16:
                            NumOfHenchmen = 8;
                            LoyaltyBase = 4;
                            ReactionAdjCha = 5;
                            break;
                        case 17:
                            NumOfHenchmen = 10;
                            LoyaltyBase = 6;
                            ReactionAdjCha = 6;
                            break;
                        case 18:
                            NumOfHenchmen = 15;
                            LoyaltyBase = 8;
                            ReactionAdjCha = 7;
                            break;
                        case 19:
                            NumOfHenchmen = 20;
                            LoyaltyBase = 10;
                            ReactionAdjCha = 8;
                            break;
                        case 20:
                            NumOfHenchmen = 25;
                            LoyaltyBase = 12;
                            ReactionAdjCha = 9;
                            break;
                        case 21:
                            NumOfHenchmen = 30;
                            LoyaltyBase = 14;
                            ReactionAdjCha = 10;
                            break;
                        case 22:
                            NumOfHenchmen = 35;
                            LoyaltyBase = 16;
                            ReactionAdjCha = 11;
                            break;
                        case 23:
                            NumOfHenchmen = 40;
                            LoyaltyBase = 18;
                            ReactionAdjCha = 12;
                            break;
                        case 24:
                            NumOfHenchmen = 45;
                            LoyaltyBase = 20;
                            ReactionAdjCha = 13;
                            break;
                        case 25:
                            NumOfHenchmen = 50;
                            LoyaltyBase = 20;
                            ReactionAdjCha = 14;
                            break;
                    }
                    break;
            }
        }

        public void ChangeHPWarrior(int stat)
        {
            switch(stat)
            {
                case 17:
                    HPAdj = 3;
                    break;
                case 18:
                    HPAdj = 4;
                    break;
                case 19:
                    HPAdj = 5;
                    break;
                case 20:
                    HPAdj = 5;
                    break;
                case 21:
                    HPAdj = 6;
                    break;
                case 22:
                    HPAdj = 6;
                    break;
                case 23:
                    HPAdj = 6;
                    break;
                case 24:
                    HPAdj = 7;
                    break;
                case 25:
                    HPAdj = 7;
                    break;
            }
        }
    }
}