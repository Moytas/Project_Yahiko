namespace Project_Yahiko
{
    partial class WeaponPicker
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
            this.lb_SelectedProfDescription_R = new System.Windows.Forms.Label();
            this.lb_SelectedProfDescription_L = new System.Windows.Forms.Label();
            this.lb_WeapProfsText = new System.Windows.Forms.Label();
            this.btn_RemoveLearnedProficiency = new System.Windows.Forms.Button();
            this.btn_AddNonWeaponProf = new System.Windows.Forms.Button();
            this.btn_ConfirmProf = new System.Windows.Forms.Button();
            this.lb_LearnedProficienies = new System.Windows.Forms.ListBox();
            this.lb_AvailableWeaponList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_SelectedProfDescription_R
            // 
            this.lb_SelectedProfDescription_R.AutoSize = true;
            this.lb_SelectedProfDescription_R.Location = new System.Drawing.Point(322, 172);
            this.lb_SelectedProfDescription_R.Name = "lb_SelectedProfDescription_R";
            this.lb_SelectedProfDescription_R.Size = new System.Drawing.Size(63, 13);
            this.lb_SelectedProfDescription_R.TabIndex = 18;
            this.lb_SelectedProfDescription_R.Text = "Description:";
            // 
            // lb_SelectedProfDescription_L
            // 
            this.lb_SelectedProfDescription_L.AutoSize = true;
            this.lb_SelectedProfDescription_L.Location = new System.Drawing.Point(29, 172);
            this.lb_SelectedProfDescription_L.Name = "lb_SelectedProfDescription_L";
            this.lb_SelectedProfDescription_L.Size = new System.Drawing.Size(63, 13);
            this.lb_SelectedProfDescription_L.TabIndex = 17;
            this.lb_SelectedProfDescription_L.Text = "Description:";
            // 
            // lb_WeapProfsText
            // 
            this.lb_WeapProfsText.AutoSize = true;
            this.lb_WeapProfsText.Location = new System.Drawing.Point(41, 19);
            this.lb_WeapProfsText.Name = "lb_WeapProfsText";
            this.lb_WeapProfsText.Size = new System.Drawing.Size(95, 13);
            this.lb_WeapProfsText.TabIndex = 16;
            this.lb_WeapProfsText.Text = "lb_WeapProfsText";
            // 
            // btn_RemoveLearnedProficiency
            // 
            this.btn_RemoveLearnedProficiency.Location = new System.Drawing.Point(184, 101);
            this.btn_RemoveLearnedProficiency.Name = "btn_RemoveLearnedProficiency";
            this.btn_RemoveLearnedProficiency.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveLearnedProficiency.TabIndex = 15;
            this.btn_RemoveLearnedProficiency.Text = "Remove";
            this.btn_RemoveLearnedProficiency.UseVisualStyleBackColor = true;
            // 
            // btn_AddNonWeaponProf
            // 
            this.btn_AddNonWeaponProf.Location = new System.Drawing.Point(184, 57);
            this.btn_AddNonWeaponProf.Name = "btn_AddNonWeaponProf";
            this.btn_AddNonWeaponProf.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNonWeaponProf.TabIndex = 14;
            this.btn_AddNonWeaponProf.Text = "Add";
            this.btn_AddNonWeaponProf.UseVisualStyleBackColor = true;
            this.btn_AddNonWeaponProf.Click += new System.EventHandler(this.btn_AddNonWeaponProf_Click);
            // 
            // btn_ConfirmProf
            // 
            this.btn_ConfirmProf.Location = new System.Drawing.Point(184, 215);
            this.btn_ConfirmProf.Name = "btn_ConfirmProf";
            this.btn_ConfirmProf.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmProf.TabIndex = 13;
            this.btn_ConfirmProf.Text = "Confirm";
            this.btn_ConfirmProf.UseVisualStyleBackColor = true;
            // 
            // lb_LearnedProficienies
            // 
            this.lb_LearnedProficienies.FormattingEnabled = true;
            this.lb_LearnedProficienies.Location = new System.Drawing.Point(314, 57);
            this.lb_LearnedProficienies.Name = "lb_LearnedProficienies";
            this.lb_LearnedProficienies.Size = new System.Drawing.Size(120, 95);
            this.lb_LearnedProficienies.TabIndex = 12;
            // 
            // lb_AvailableWeaponList
            // 
            this.lb_AvailableWeaponList.FormattingEnabled = true;
            this.lb_AvailableWeaponList.Location = new System.Drawing.Point(18, 57);
            this.lb_AvailableWeaponList.Name = "lb_AvailableWeaponList";
            this.lb_AvailableWeaponList.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailableWeaponList.TabIndex = 11;
            // 
            // WeaponPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 257);
            this.Controls.Add(this.lb_SelectedProfDescription_R);
            this.Controls.Add(this.lb_SelectedProfDescription_L);
            this.Controls.Add(this.lb_WeapProfsText);
            this.Controls.Add(this.btn_RemoveLearnedProficiency);
            this.Controls.Add(this.btn_AddNonWeaponProf);
            this.Controls.Add(this.btn_ConfirmProf);
            this.Controls.Add(this.lb_LearnedProficienies);
            this.Controls.Add(this.lb_AvailableWeaponList);
            this.Name = "WeaponPicker";
            this.Text = "Weapon Proficiencies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SelectedProfDescription_R;
        private System.Windows.Forms.Label lb_SelectedProfDescription_L;
        private System.Windows.Forms.Label lb_WeapProfsText;
        private System.Windows.Forms.Button btn_RemoveLearnedProficiency;
        private System.Windows.Forms.Button btn_AddNonWeaponProf;
        private System.Windows.Forms.Button btn_ConfirmProf;
        private System.Windows.Forms.ListBox lb_LearnedProficienies;
        private System.Windows.Forms.ListBox lb_AvailableWeaponList;
    }
}