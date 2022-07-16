
namespace Project_Yahiko
{
    partial class Form_Initial
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
            this.Title = new System.Windows.Forms.Label();
            this.lb_Start = new System.Windows.Forms.Label();
            this.lb_Options = new System.Windows.Forms.Label();
            this.lb_Quit = new System.Windows.Forms.Label();
            this.lb_Arrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.Title.Location = new System.Drawing.Point(117, 61);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(459, 120);
            this.Title.TabIndex = 0;
            this.Title.Text = "YAHIKO";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Start
            // 
            this.lb_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Start.AutoSize = true;
            this.lb_Start.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb_Start.Location = new System.Drawing.Point(317, 199);
            this.lb_Start.Name = "lb_Start";
            this.lb_Start.Size = new System.Drawing.Size(29, 13);
            this.lb_Start.TabIndex = 1;
            this.lb_Start.Text = "Start";
            this.lb_Start.Click += new System.EventHandler(this.lb_Start_Click);
            // 
            // lb_Options
            // 
            this.lb_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Options.AutoSize = true;
            this.lb_Options.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb_Options.Location = new System.Drawing.Point(317, 234);
            this.lb_Options.Name = "lb_Options";
            this.lb_Options.Size = new System.Drawing.Size(43, 13);
            this.lb_Options.TabIndex = 2;
            this.lb_Options.Text = "Options";
            // 
            // lb_Quit
            // 
            this.lb_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Quit.AutoSize = true;
            this.lb_Quit.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb_Quit.Location = new System.Drawing.Point(320, 282);
            this.lb_Quit.Name = "lb_Quit";
            this.lb_Quit.Size = new System.Drawing.Size(26, 13);
            this.lb_Quit.TabIndex = 3;
            this.lb_Quit.Text = "Quit";
            // 
            // lb_Arrow
            // 
            this.lb_Arrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Arrow.AutoSize = true;
            this.lb_Arrow.ForeColor = System.Drawing.Color.Gold;
            this.lb_Arrow.Location = new System.Drawing.Point(270, 199);
            this.lb_Arrow.Name = "lb_Arrow";
            this.lb_Arrow.Size = new System.Drawing.Size(16, 13);
            this.lb_Arrow.TabIndex = 4;
            this.lb_Arrow.Text = "->";
            // 
            // Form_Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(685, 356);
            this.Controls.Add(this.lb_Arrow);
            this.Controls.Add(this.lb_Quit);
            this.Controls.Add(this.lb_Options);
            this.Controls.Add(this.lb_Start);
            this.Controls.Add(this.Title);
            this.Name = "Form_Initial";
            this.Text = "Yahiko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lb_Start;
        private System.Windows.Forms.Label lb_Options;
        private System.Windows.Forms.Label lb_Quit;
        private System.Windows.Forms.Label lb_Arrow;
    }
}

