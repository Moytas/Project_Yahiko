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
        int pool = 60;
        int weaponProf = 4;

        int initial_pp, initial_ol, initial_frt, initial_ms, initial_hs, initial_dn, initial_cw, initial_rl;


        public Specialization(ref Player _p)
        {
            InitializeComponent();
            player = _p;
            switch(player.PlayerClass)
            {
                case 1: // warrior
                    this.Text = "Bushi specialization";
                    tabControl1.SelectedTab = tabSamurai;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabShinobi);
                    //weaponProf = _p.WeaponProf; UNCOMENT THIS
                    lb_AvailablePointsValue.Text = weaponProf.ToString();
                    PopulateOptionsWeapon();
                    break;
                case 2: // thief
                    this.Text = "Shinobi skills";
                    tabControl1.SelectedTab = tabShinobi;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabSamurai);
                    AdjustThiefSkills();
                    break;
                case 3: // priest
                    this.Text = "Sohei spells";
                    tabControl1.SelectedTab = tabMonk;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabShinobi);
                    tabControl1.TabPages.Remove(tabSamurai);
                    break;
                case 4: // mage
                    this.Text = "Onmyoji spells";
                    tabControl1.SelectedTab = tabShinobi;
                    tabControl1.TabPages.Remove(tabMage);
                    tabControl1.TabPages.Remove(tabMonk);
                    tabControl1.TabPages.Remove(tabSamurai);
                    break;
            }
        }
        void PopulateOptionsWeapon()
        {
            // Katana / Bokken * Ninja - to * No - daichi * Tetsu - to * Tanto / Yoroi - toshi * Wakizashi *
            List<string> Weapons = new List<string>();
            Weapons.Add("Katana");
            Weapons.Add("Ninja-to");
            Weapons.Add("No-daichi");
            Weapons.Add("Tetsu-to");
            Weapons.Add("Tanto");
            Weapons.Add("Yoroi-toshi");
            Weapons.Add("Wakizashi");
            Weapons.Add("Daikyu");
            Weapons.Add("Hankyu");
            lb_AvailableList.Items.Clear();
            foreach(string s in Weapons)
            {
                lb_AvailableList.Items.Add(s);
            }
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
            initial_cw = player.Skills.GetValue(ThiefSkills.Skills.CW);
            initial_dn = player.Skills.GetValue(ThiefSkills.Skills.DN);
            initial_frt = player.Skills.GetValue(ThiefSkills.Skills.FRT);
            initial_hs = player.Skills.GetValue(ThiefSkills.Skills.HS);
            initial_ms = player.Skills.GetValue(ThiefSkills.Skills.MS);
            initial_ol = player.Skills.GetValue(ThiefSkills.Skills.OL);
            initial_pp = player.Skills.GetValue(ThiefSkills.Skills.PP);
            initial_rl = player.Skills.GetValue(ThiefSkills.Skills.RL);

            ud_CW.Value = initial_cw;
            ud_CW.Maximum = initial_cw + 30;
            ud_CW.Minimum = initial_cw;

            ud_DN.Value = initial_dn;
            ud_DN.Maximum = initial_dn + 30;
            ud_DN.Minimum = initial_dn;
            
            ud_FRT.Value = initial_frt;
            ud_FRT.Maximum = initial_frt + 30;
            ud_FRT.Minimum = initial_frt;
            
            ud_HS.Value = initial_hs;
            ud_HS.Maximum = initial_hs + 30;
            ud_HS.Minimum = initial_hs;
            
            ud_MS.Value = initial_ms;
            ud_MS.Maximum = initial_ms + 30;
            ud_MS.Minimum = initial_ms;

            ud_OL.Value = initial_ol;
            ud_OL.Maximum = initial_ol + 30;
            ud_OL.Minimum = initial_ol;

            ud_PP.Value = initial_pp;
            ud_PP.Maximum = initial_pp + 30;
            ud_PP.Minimum = initial_pp;

            ud_RL.Value = initial_rl;
            ud_RL.Maximum = initial_rl + 30;
            ud_RL.Minimum = initial_rl;
        }

        private void ud_PP_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_PP.Value - player.Skills.GetValue(ThiefSkills.Skills.PP) > 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_PP.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_PP.Value);
                }
            }
        }

        private void btn_reset_Clicked(object sender, EventArgs e)
        {
            ud_CW.Value = initial_cw;
            ud_CW.Maximum = initial_cw + 30;
            ud_CW.Minimum = initial_cw;

            ud_DN.Value = initial_dn;
            ud_DN.Maximum = initial_dn + 30;
            ud_DN.Minimum = initial_dn;

            ud_FRT.Value = initial_frt;
            ud_FRT.Maximum = initial_frt + 30;
            ud_FRT.Minimum = initial_frt;

            ud_HS.Value = initial_hs;
            ud_HS.Maximum = initial_hs + 30;
            ud_HS.Minimum = initial_hs;

            ud_MS.Value = initial_ms;
            ud_MS.Maximum = initial_ms + 30;
            ud_MS.Minimum = initial_ms;

            ud_OL.Value = initial_ol;
            ud_OL.Maximum = initial_ol + 30;
            ud_OL.Minimum = initial_ol;

            ud_PP.Value = initial_pp;
            ud_PP.Maximum = initial_pp + 30;
            ud_PP.Minimum = initial_pp;

            ud_RL.Value = initial_rl;
            ud_RL.Maximum = initial_rl + 30;
            ud_RL.Minimum = initial_rl;

            pool = 60;
            lb_PointsPool.Text = pool.ToString();

            player.Skills.SetValues(ThiefSkills.Skills.OL, initial_ol);
            player.Skills.SetValues(ThiefSkills.Skills.HS, initial_hs);
            player.Skills.SetValues(ThiefSkills.Skills.CW, initial_cw);
            player.Skills.SetValues(ThiefSkills.Skills.MS, initial_ms);
            player.Skills.SetValues(ThiefSkills.Skills.PP, initial_pp);
            player.Skills.SetValues(ThiefSkills.Skills.RL, initial_rl);
            player.Skills.SetValues(ThiefSkills.Skills.FRT, initial_frt);
            player.Skills.SetValues(ThiefSkills.Skills.DN, initial_dn);
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {

        }

        private void btn_LearnAvProf_Clicked(object sender, EventArgs e)
        {
            if(weaponProf > 0)
            {
                weaponProf -= 1;
                lb_AvailablePointsValue.Text = weaponProf.ToString();
                lb_ProficientList.Items.Add(lb_AvailableList.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lb_AvailableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ud_OL_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_OL.Value - player.Skills.GetValue(ThiefSkills.Skills.OL) > 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.OL, (int)ud_OL.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.PP, (int)ud_OL.Value);
                }
            }
        }

        private void ud_DN_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_DN.Value - player.Skills.GetValue(ThiefSkills.Skills.DN) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_DN.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_DN.Value);
                }
            }
        }

        private void ud_CW_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_CW.Value - player.Skills.GetValue(ThiefSkills.Skills.CW) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.CW, (int)ud_CW.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.CW, (int)ud_CW.Value);
                }
            }

        }

        private void ud_RL_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_RL.Value - player.Skills.GetValue(ThiefSkills.Skills.RL) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.RL, (int)ud_RL.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_RL.Value);
                }
            }
        }

        private void ud_HS_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_HS.Value - player.Skills.GetValue(ThiefSkills.Skills.HS) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.HS, (int)ud_HS.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_HS.Value);
                }
            }

        }

        private void ud_MS_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_MS.Value - player.Skills.GetValue(ThiefSkills.Skills.MS) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.MS, (int)ud_MS.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_MS.Value);
                }
            }
        }

        private void ud_FRT_ValueChanged(object sender, EventArgs e)
        {
            if (pool > 0)
            {
                if (ud_FRT.Value - player.Skills.GetValue(ThiefSkills.Skills.FRT) >= 0) //up
                {
                    pool--;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.FRT, (int)ud_FRT.Value);
                }
                else
                {
                    pool++;
                    lb_PointsPool.Text = pool.ToString();
                    player.Skills.SetValues(ThiefSkills.Skills.DN, (int)ud_FRT.Value);
                }
            }

        }
    }
}
