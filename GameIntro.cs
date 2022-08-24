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
    public partial class Form_Initial : Form
    {
        public static DMOptions GM;
        public Player _player;
        public Form_Initial()
        {
            InitializeComponent();
            OnInit();
        }

        //create objects
        private void OnInit()
        {
            GM = new DMOptions();
            GM.PopulateClanNames();
           
        }


        private void lb_Start_Click(object sender, EventArgs e)
        {
            _player = new Player();
            CharacterCreationSheet cs = new CharacterCreationSheet();
            cs.GetPlayer(ref _player);
            cs.Show();
        }
    }
}
