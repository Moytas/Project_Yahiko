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
    public partial class Intro_TutorialLevel : Form
    {
    int index = 0;

        #region Constructors
       
        public Intro_TutorialLevel(Bushi Player)
        {
            InitializeComponent();
        }
        public Intro_TutorialLevel(Shinobi Player)
        {
            InitializeComponent();
        }
        public Intro_TutorialLevel(Sohei Player)
        {
            InitializeComponent();
        }
        public Intro_TutorialLevel(Onmyoji Player)
        {
            InitializeComponent();
        }
        #endregion;

        #region TextBox
        //idea in progress..
        /*void ShowIntroText(string text)
        {
            int numOfWordsInText = text.Split(' ').Length;

            foreach(char c in text)
            {
            }
        }

        void ShowText()
        {
            string txt = "Japan, 1755.";
            int numOfWords = txt.Split(' ').Length;
            
            List<int> NumOfCharactersInWord = new List<int>();

            for (int i = 0; i < numOfWords; i++)
            {
                NumOfCharactersInWord.Add(txt.Split(' ')[i].Length);
            }

            int totalLines = 0;
            
            for(int i = 0; i < NumOfCharactersInWord.Count; i++)
            {
                totalLines += NumOfCharactersInWord[i];
            }

            tb_IntroText.Text = "";
            for(int i = 0; i < numOfWords; i++)
            {
                foreach(string s in txt.Split(' '))
                {
                    for(int j = 0; j < s.Length; j++)
                    {
                        tb_IntroText.Text += string.Format("{0}\n", s[j]);
                    }
                }
            }
        }
        */
        void ShowIntro()
    {
      lbl_Top.Text = "Japan, 1759..";
      lbl_Mid_Top.Text = "";
      lbl_Mid_Mid.Text = "";
      lbl_Mid_Low.Text = "";
      lbl_Low.Text = "";
    
    }

    void ShowNextText()
    {
      switch(index)
      {
        case 1:
          break;
      }
    }
        #endregion;

    #region Random
    #endregion

  }
}
