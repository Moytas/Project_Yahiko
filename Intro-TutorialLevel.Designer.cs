
namespace Project_Yahiko
{
    partial class Intro_TutorialLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_IntroText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_IntroText
            // 
            this.tb_IntroText.Location = new System.Drawing.Point(340, 12);
            this.tb_IntroText.Multiline = true;
            this.tb_IntroText.Name = "tb_IntroText";
            this.tb_IntroText.ReadOnly = true;
            this.tb_IntroText.Size = new System.Drawing.Size(100, 392);
            this.tb_IntroText.TabIndex = 0;
            this.tb_IntroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_IntroText.WordWrap = false;
            // 
            // Intro_TutorialLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.tb_IntroText);
            this.Name = "Intro_TutorialLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IntroText;
    }
}