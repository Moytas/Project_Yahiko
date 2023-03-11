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
    public partial class GameIntro : Form
    {
        public GameIntro()
        {
            InitializeComponent();
        }

        private void lb_Start_Click(object sender, EventArgs e)
        {
           // Intro_TutorialLevel tutorial = new Intro_TutorialLevel();
            //tutorial.Show();
            CharacterCreationSheet cs = new CharacterCreationSheet();
            cs.Show();
        }
    }
}
