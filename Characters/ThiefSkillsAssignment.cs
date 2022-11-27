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
    public partial class ThiefSkillsAssignment : Form
    {
        private Table_Shinobi values;
        private Shinobi Player;

        private int pp_init, ms_init, cw_init, ol_init, hs_init, rl_init, ft_init, dn_init;
        private int points;
        private int limit;

        public ThiefSkillsAssignment()
        {
            InitializeComponent();
        }

        public ThiefSkillsAssignment(Shinobi _Player,bool firstTime)
        {
            Player = _Player;
            if (firstTime)
            {
                values = new Table_Shinobi();
                values.SetAdjastments_ByDex(Player.CharacterStats.Current_Dex);
                values.SetAdjastments_ByRace(Player.CharacterRace);

                points = 60;
                limit = 30;
                InitializeComponent();
                SetInitialValues();
            }
            else
            {
                points = 30;
                limit = 15;
                InitializeComponent();
                SetValues();
            }
            
        }
        private void SetValues() //First time = false
        {

        }

        private void SetInitialValues() //First time = true/Initialize buttons values
        {
            pp_init = values.GetSkillValue(ThiefSkills.Skills.PP);
            ud_PP.Value = pp_init > 0 ? pp_init : 0;
            ud_PP.Maximum = ud_PP.Value + limit;
            ud_PP.Minimum = ud_PP.Value;

            ol_init = values.GetSkillValue(ThiefSkills.Skills.OL);
            ud_OL.Value = ol_init > 0 ? ol_init : 0;
            ud_OL.Maximum = ud_OL.Value + limit;
            ud_OL.Minimum = ud_OL.Value;

            ft_init = values.GetSkillValue(ThiefSkills.Skills.FRT);
            ud_FRT.Value = ft_init > 0 ? ft_init : 0;
            ud_FRT.Maximum = ud_FRT.Value + limit;
            ud_FRT.Minimum = ud_FRT.Value;

            ms_init = values.GetSkillValue(ThiefSkills.Skills.MS);
            ud_MS.Value = ms_init > 0 ? ms_init : 0;
            ud_MS.Maximum = ud_MS.Value + limit;
            ud_MS.Minimum = ud_MS.Value;

            hs_init = values.GetSkillValue(ThiefSkills.Skills.HS);
            ud_HS.Value = hs_init > 0 ? hs_init : 0;
            ud_HS.Maximum = ud_HS.Value + limit;
            ud_HS.Minimum = ud_HS.Value;

            cw_init = values.GetSkillValue(ThiefSkills.Skills.CW);
            ud_CW.Value = cw_init > 0 ? cw_init : 0;
            ud_CW.Maximum = ud_CW.Value + limit;
            ud_CW.Minimum = ud_CW.Value;

            rl_init = values.GetSkillValue(ThiefSkills.Skills.RL);
            ud_RL.Value = rl_init > 0 ? rl_init : 0;
            ud_RL.Maximum = ud_RL.Value + limit;
            ud_RL.Minimum = ud_RL.Value;

        } 

        private void ShowPoints()
        {
            lb_PointsPool.Text = string.Format("Remaining: {0}", points);
        } //Shows remaining points
        private void btn_ThiefReset_Click(object sender, EventArgs e)
        {
            points = 60;
            ShowPoints();
            SetInitialValues();
        }

        private void btn_ThiefAccept_Click(object sender, EventArgs e)
        {

        }

        private void ud_PP_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(ud_PP.Value);
        }
    }
}
