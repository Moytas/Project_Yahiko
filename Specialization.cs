using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahiko
{
    public partial class Specialization : Form
    {
        Player player;

        public Specialization(ref Player _p)
        {
            InitializeComponent();
            player = _p;
            
        }

        void AdjustThiefSkills()
        {
            switch(player.CharacterRace)
            {
                case 2://elf
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.DN, player.Skills.GetValue(ThiefSkills.Skills.DN) + 5);
                    break;
                case 3://dwarf
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.CW, player.Skills.GetValue(ThiefSkills.Skills.CW) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.RL, player.Skills.GetValue(ThiefSkills.Skills.RL) - 5);
                    break;
                case 4://gnome
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.DN, player.Skills.GetValue(ThiefSkills.Skills.DN) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.CW, player.Skills.GetValue(ThiefSkills.Skills.CW) - 15);
                    break;
                case 5://halfling
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.DN, player.Skills.GetValue(ThiefSkills.Skills.DN) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.CW, player.Skills.GetValue(ThiefSkills.Skills.CW) - 15);
                    player.Skills.SetValues(ThiefSkills.Skills.RL, player.Skills.GetValue(ThiefSkills.Skills.RL) - 5);
                    break;
                case 6://half-elf
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    break;

            }

            switch(player.CharacterStats.Initial_Dex)
            {
                case 9:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) - 15);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 20);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) - 10);
                    break;
                case 10:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 15);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) - 5);
                    break;
                case 11:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) - 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) - 5);
                    break;
                case 12:
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) - 5);
                    break;
                case 16:
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 5);
                    break;
                case 17:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 5);
                    break;
                case 18:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 5);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 10);
                    break;
                case 19:
                    player.Skills.SetValues(ThiefSkills.Skills.PP, player.Skills.GetValue(ThiefSkills.Skills.PP) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.OL, player.Skills.GetValue(ThiefSkills.Skills.OL) + 20);
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, player.Skills.GetValue(ThiefSkills.Skills.FRT) + 10);
                    player.Skills.SetValues(ThiefSkills.Skills.MS, player.Skills.GetValue(ThiefSkills.Skills.MS) + 15);
                    player.Skills.SetValues(ThiefSkills.Skills.HS, player.Skills.GetValue(ThiefSkills.Skills.HS) + 15);
                    break;
            }
        }
    }
}
