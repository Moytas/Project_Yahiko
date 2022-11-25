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
        private Shinobi Player;
        public ThiefSkillsAssignment()
        {
            InitializeComponent();
        }

        public ThiefSkillsAssignment(Shinobi _Player)
        {
            Player = _Player;
            InitializeComponent();
        }

        private void btn_ThiefReset_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThiefAccept_Click(object sender, EventArgs e)
        {

        }

        private void ud_PP_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
