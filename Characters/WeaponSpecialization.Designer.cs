namespace Project_Yahiko
{
    partial class WeaponSpecialization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ForgetSpecialized = new System.Windows.Forms.Button();
            this.btn_LearnProficient = new System.Windows.Forms.Button();
            this.btn_ForgetProficient = new System.Windows.Forms.Button();
            this.lb_Specialized = new System.Windows.Forms.ListBox();
            this.lb_Proficient = new System.Windows.Forms.ListBox();
            this.btn_LearnAvailable = new System.Windows.Forms.Button();
            this.lb_Available = new System.Windows.Forms.ListBox();
            this.lbl_WeaponSpecializationInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_ForgetSpecialized);
            this.panel1.Controls.Add(this.btn_LearnProficient);
            this.panel1.Controls.Add(this.btn_ForgetProficient);
            this.panel1.Controls.Add(this.lb_Specialized);
            this.panel1.Controls.Add(this.lb_Proficient);
            this.panel1.Controls.Add(this.btn_LearnAvailable);
            this.panel1.Controls.Add(this.lb_Available);
            this.panel1.Controls.Add(this.lbl_WeaponSpecializationInfo);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 256);
            this.panel1.TabIndex = 13;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(281, 221);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(51, 23);
            this.btn_Confirm.TabIndex = 23;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Specialized";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Proficient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Available";
            // 
            // btn_ForgetSpecialized
            // 
            this.btn_ForgetSpecialized.Location = new System.Drawing.Point(415, 153);
            this.btn_ForgetSpecialized.Name = "btn_ForgetSpecialized";
            this.btn_ForgetSpecialized.Size = new System.Drawing.Size(51, 23);
            this.btn_ForgetSpecialized.TabIndex = 19;
            this.btn_ForgetSpecialized.Text = "Forget";
            this.btn_ForgetSpecialized.UseVisualStyleBackColor = true;
            this.btn_ForgetSpecialized.Click += new System.EventHandler(this.btn_ForgetSpecialized_Click);
            // 
            // btn_LearnProficient
            // 
            this.btn_LearnProficient.Location = new System.Drawing.Point(415, 115);
            this.btn_LearnProficient.Name = "btn_LearnProficient";
            this.btn_LearnProficient.Size = new System.Drawing.Size(51, 23);
            this.btn_LearnProficient.TabIndex = 18;
            this.btn_LearnProficient.Text = "Learn";
            this.btn_LearnProficient.UseVisualStyleBackColor = true;
            this.btn_LearnProficient.Click += new System.EventHandler(this.btn_LearnProficient_Click);
            // 
            // btn_ForgetProficient
            // 
            this.btn_ForgetProficient.Location = new System.Drawing.Point(176, 153);
            this.btn_ForgetProficient.Name = "btn_ForgetProficient";
            this.btn_ForgetProficient.Size = new System.Drawing.Size(51, 23);
            this.btn_ForgetProficient.TabIndex = 17;
            this.btn_ForgetProficient.Text = "Forget";
            this.btn_ForgetProficient.UseVisualStyleBackColor = true;
            this.btn_ForgetProficient.Click += new System.EventHandler(this.btn_ForgetProficient_Click);
            // 
            // lb_Specialized
            // 
            this.lb_Specialized.FormattingEnabled = true;
            this.lb_Specialized.Location = new System.Drawing.Point(481, 99);
            this.lb_Specialized.Name = "lb_Specialized";
            this.lb_Specialized.Size = new System.Drawing.Size(120, 95);
            this.lb_Specialized.TabIndex = 16;
            // 
            // lb_Proficient
            // 
            this.lb_Proficient.FormattingEnabled = true;
            this.lb_Proficient.Location = new System.Drawing.Point(251, 99);
            this.lb_Proficient.Name = "lb_Proficient";
            this.lb_Proficient.Size = new System.Drawing.Size(120, 95);
            this.lb_Proficient.TabIndex = 15;
            // 
            // btn_LearnAvailable
            // 
            this.btn_LearnAvailable.Location = new System.Drawing.Point(176, 115);
            this.btn_LearnAvailable.Name = "btn_LearnAvailable";
            this.btn_LearnAvailable.Size = new System.Drawing.Size(51, 23);
            this.btn_LearnAvailable.TabIndex = 14;
            this.btn_LearnAvailable.Text = "Learn";
            this.btn_LearnAvailable.UseVisualStyleBackColor = true;
            this.btn_LearnAvailable.Click += new System.EventHandler(this.btn_LearnAvailable_Click);
            // 
            // lb_Available
            // 
            this.lb_Available.FormattingEnabled = true;
            this.lb_Available.Location = new System.Drawing.Point(29, 99);
            this.lb_Available.Name = "lb_Available";
            this.lb_Available.Size = new System.Drawing.Size(115, 95);
            this.lb_Available.TabIndex = 13;
            // 
            // lbl_WeaponSpecializationInfo
            // 
            this.lbl_WeaponSpecializationInfo.AutoSize = true;
            this.lbl_WeaponSpecializationInfo.Location = new System.Drawing.Point(26, 17);
            this.lbl_WeaponSpecializationInfo.Name = "lbl_WeaponSpecializationInfo";
            this.lbl_WeaponSpecializationInfo.Size = new System.Drawing.Size(35, 13);
            this.lbl_WeaponSpecializationInfo.TabIndex = 12;
            this.lbl_WeaponSpecializationInfo.Text = "label4";
            // 
            // WeaponSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 264);
            this.Controls.Add(this.panel1);
            this.Name = "WeaponSpecialization";
            this.Text = "Weapon Specialization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ForgetSpecialized;
        private System.Windows.Forms.Button btn_LearnProficient;
        private System.Windows.Forms.Button btn_ForgetProficient;
        private System.Windows.Forms.ListBox lb_Specialized;
        private System.Windows.Forms.ListBox lb_Proficient;
        private System.Windows.Forms.Button btn_LearnAvailable;
        private System.Windows.Forms.ListBox lb_Available;
        private System.Windows.Forms.Label lbl_WeaponSpecializationInfo;
    }
}