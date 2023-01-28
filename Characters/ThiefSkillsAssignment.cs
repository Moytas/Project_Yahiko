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
        /* TODO
         * make buttons inactive on max and min values
         * accept button
         * ...
         */

        private Table_Shinobi values;
        private Shinobi Player;

        private int pp_init, ms_init, cw_init, ol_init, hs_init, rl_init, frt_init, dn_init;
        private int currentPoints, initialPoints;
        private int limit;

        #region Constructors
        public ThiefSkillsAssignment()
        {
            InitializeComponent();
        }
        public ThiefSkillsAssignment(Shinobi _Player)
        {
            Player = _Player;
            if (Player.Level  <= 1)
            {
                values = new Table_Shinobi();
                values.SetAdjastments_ByDex(Player.CharacterStats.Current_Dex);
                values.SetAdjastments_ByRace(Player.CharacterRace);


                limit = 30;
                InitializeComponent();
                SetInitialValues();

                initialPoints = 60;
                currentPoints = 60;
                ShowPoints();
            }
            else
            {
                limit = 15;
                InitializeComponent();
                SetValues();
                currentPoints = 60;
                ShowPoints();
            }

        }
        #endregion

        #region Init
        private void SetValues() //First time = false 
        {

        }

        private void SetInitialValues() //First time = true/Initialize buttons values
        {
            dn_init = values.GetSkillValue(ThiefSkills.Skills.DN);
            dn_init = dn_init >= 0 ? dn_init : 0;
            lbl_DN_Value.Text = dn_init.ToString();
            
            pp_init = values.GetSkillValue(ThiefSkills.Skills.PP);
            pp_init = pp_init >= 0 ? pp_init : 0;
            lbl_PP_Value.Text = pp_init.ToString();

            ol_init = values.GetSkillValue(ThiefSkills.Skills.OL);
            ol_init = ol_init >= 0 ? ol_init : 0;
            lbl_OL_Value.Text = ol_init.ToString();

            frt_init = values.GetSkillValue(ThiefSkills.Skills.FRT);
            frt_init = frt_init >= 0 ? frt_init : 0;
            lbl_FRT_Value.Text = frt_init.ToString();

            ms_init = values.GetSkillValue(ThiefSkills.Skills.MS);
            ms_init = ms_init >= 0 ? ms_init : 0;
            lbl_MS_Value.Text = ms_init.ToString();

            hs_init = values.GetSkillValue(ThiefSkills.Skills.HS);
            hs_init = hs_init >= 0 ? hs_init : 0;
            lbl_HS_Value.Text = hs_init.ToString();

            cw_init = values.GetSkillValue(ThiefSkills.Skills.CW);
            cw_init = cw_init >= 0 ? cw_init : 0;
            lbl_CW_Value.Text = cw_init.ToString();

            rl_init = values.GetSkillValue(ThiefSkills.Skills.RL);
            rl_init = rl_init >= 0 ? rl_init : 0;
            lbl_RL_Value.Text = rl_init.ToString();


        }
        #endregion

       
        private void ShowPoints()
        {
            lb_PointsPool.Text = string.Format("Remaining: {0}", currentPoints);
        } //Shows remaining points


        #region Buttons

        private void MakeAllButtonsDOWN_Inactive()
        {
            btn_CW_Down.Enabled = false;
            btn_DN_Down.Enabled = false;
            btn_FRT_Down.Enabled = false;
            btn_HS_Down.Enabled = false;
            btn_MS_Down.Enabled = false;
            btn_OL_Down.Enabled = false;
            btn_PP_Down.Enabled = false;
            btn_RL_Down.Enabled = false;
        }
        private void MakeAllButtonsDOWN_Active()
        {
            btn_CW_Down.Enabled = true;
            btn_DN_Down.Enabled = true;
            btn_FRT_Down.Enabled = true;
            btn_HS_Down.Enabled = true;
            btn_MS_Down.Enabled = true;
            btn_OL_Down.Enabled = true;
            btn_PP_Down.Enabled = true;
            btn_RL_Down.Enabled = true;
        }

        private void MakeAllButtonsUP_Active()
        {
            btn_CW_Up.Enabled = true;
            btn_DN_Up.Enabled = true;
            btn_FRT_Up.Enabled = true;
            btn_HS_Up.Enabled = true;
            btn_MS_Up.Enabled = true;
            btn_OL_Up.Enabled = true;
            btn_PP_Up.Enabled = true;
            btn_RL_Up.Enabled = true;
        }
        private void MakeAllButtonsUP_Inactive()
        {
            btn_CW_Up.Enabled = false;
            btn_DN_Up.Enabled = false;
            btn_FRT_Up.Enabled = false;
            btn_HS_Up.Enabled = false;
            btn_MS_Up.Enabled = false;
            btn_OL_Up.Enabled = false;
            btn_PP_Up.Enabled = false;
            btn_RL_Up.Enabled = false;
        }
        private void btn_ThiefReset_Click(object sender, EventArgs e)
        {
            currentPoints = 60;
            ShowPoints();
            SetInitialValues();
        }
        private void btn_ThiefAccept_Click(object sender, EventArgs e)
        {
            WeaponPicker weaponPick = new WeaponPicker(Player);
            weaponPick.Show();
            this.Close();
        }

        #region UP_Buttons

        private void btn_PP_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {
                int value = int.Parse(lbl_PP_Value.Text);
                if (value < pp_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_PP_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }
        private void btn_OL_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_OL_Value.Text);
                if (value < ol_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_OL_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }

        private void btn_MS_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_MS_Value.Text);
                if (value < ms_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_MS_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }

        }

        private void btn_CW_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_CW_Value.Text);
                if (value < cw_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_CW_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }

        private void btn_RL_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_RL_Value.Text);
                if (value < rl_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_RL_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }

        private void btn_HS_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_HS_Value.Text);
                if (value < hs_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_HS_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }

        private void btn_DN_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_DN_Value.Text);
                if (value < dn_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_DN_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }

        private void btn_FRT_Up_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0)
            {

                int value = int.Parse(lbl_FRT_Value.Text);
                if (value < frt_init + limit)
                {
                    value++;
                    currentPoints--;
                    ShowPoints();
                }
                lbl_FRT_Value.Text = value.ToString();
            }
            else if (currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
        }

        private void lb_PointsPool_TextChanged(object sender, EventArgs e)
        {
            if(currentPoints == 0)
            {
                MakeAllButtonsUP_Inactive();
            }
            else
            {
                MakeAllButtonsUP_Active();
            }
        }

        #endregion

        #region Down_Buttons
        private void btn_OL_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints < initialPoints)
            {
                int currentValue = int.Parse(lbl_OL_Value.Text);
                if (currentValue > ol_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_OL_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_OL_Value.Text);
                if (currentValue > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_OL_Value.Text = currentValue.ToString();
            }
        }

        private void btn_MS_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints < initialPoints)
            {
                int currentValue = int.Parse(lbl_MS_Value.Text);
                if (currentValue > ms_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_MS_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_MS_Value.Text);
                if (currentValue > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_MS_Value.Text = currentValue.ToString();
            }

        }

        private void btn_CW_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints < initialPoints)
            {
                int currentValue = int.Parse(lbl_CW_Value.Text);
                if (currentValue > cw_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_CW_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_CW_Value.Text);
                if (currentValue > 0 && currentPoints + 1 < initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_CW_Value.Text = currentValue.ToString();
            }

        }

        private void btn_RL_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints < initialPoints)
            {
                int currentValue = int.Parse(lbl_RL_Value.Text);
                if (currentValue > rl_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_RL_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_RL_Value.Text);
                if (currentValue > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_RL_Value.Text = currentValue.ToString();
            }
        }

        private void btn_HS_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints + 1 <=  initialPoints)
            {
                int currentValue = int.Parse(lbl_HS_Value.Text);
                if (currentValue > hs_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_HS_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_HS_Value.Text);
                if (currentValue > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_HS_Value.Text = currentValue.ToString();
            }
        }

        private void btn_DN_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints < initialPoints)
            {
                int currentValue = int.Parse(lbl_DN_Value.Text);
                if (currentValue > dn_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_DN_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_DN_Value.Text);
                if (currentValue > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_DN_Value.Text = currentValue.ToString();
            }
        }

        private void btn_FRT_Down_Click(object sender, EventArgs e)
        {
            if (currentPoints > 0 && currentPoints < initialPoints)
            {
                int currentValue = int.Parse(lbl_FRT_Value.Text);
                if (currentValue > frt_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_FRT_Value.Text = currentValue.ToString();

            }
            else if (currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_FRT_Value.Text);
                if (currentValue > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_FRT_Value.Text = currentValue.ToString();
            }
        }
        
        private void btn_PP_Down_Click(object sender, EventArgs e)
        {
            if(currentPoints > 0 && currentPoints < initialPoints)
            {
                
                int currentValue = int.Parse(lbl_PP_Value.Text);
                if(currentValue > pp_init)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_PP_Value.Text = currentValue.ToString();
                
            }
            else if(currentPoints == 0)
            {
                int currentValue = int.Parse(lbl_PP_Value.Text);
                if(currentValue  > 0 && currentPoints + 1 <= initialPoints)
                {
                    currentValue--;
                    currentPoints++;
                    ShowPoints();
                }
                lbl_PP_Value.Text = currentValue.ToString();
            }
        }
        #endregion


        #endregion
    }
}
