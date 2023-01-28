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
            this.btn_RemoveWeaponProficiency = new System.Windows.Forms.Button();
            this.btn_AddWeaponProf = new System.Windows.Forms.Button();
            this.btn_ConfirmProf = new System.Windows.Forms.Button();
            this.lb_LearnedProficienies = new System.Windows.Forms.ListBox();
            this.lb_AvailableWeaponList = new System.Windows.Forms.ListBox();
            this.lbl_AvailablePoints = new System.Windows.Forms.Label();
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
            this.lb_WeapProfsText.Location = new System.Drawing.Point(181, 9);
            this.lb_WeapProfsText.Name = "lb_WeapProfsText";
            this.lb_WeapProfsText.Size = new System.Drawing.Size(95, 13);
            this.lb_WeapProfsText.TabIndex = 16;
            this.lb_WeapProfsText.Text = "lb_WeapProfsText";
            // 
            // btn_RemoveWeaponProficiency
            // 
            this.btn_RemoveWeaponProficiency.Location = new System.Drawing.Point(184, 101);
            this.btn_RemoveWeaponProficiency.Name = "btn_RemoveWeaponProficiency";
            this.btn_RemoveWeaponProficiency.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveWeaponProficiency.TabIndex = 15;
            this.btn_RemoveWeaponProficiency.Text = "Remove";
            this.btn_RemoveWeaponProficiency.UseVisualStyleBackColor = true;
            this.btn_RemoveWeaponProficiency.Click += new System.EventHandler(this.btn_RemoveWeaponProficiency_Click);
            // 
            // btn_AddWeaponProf
            // 
            this.btn_AddWeaponProf.Location = new System.Drawing.Point(184, 57);
            this.btn_AddWeaponProf.Name = "btn_AddWeaponProf";
            this.btn_AddWeaponProf.Size = new System.Drawing.Size(75, 23);
            this.btn_AddWeaponProf.TabIndex = 14;
            this.btn_AddWeaponProf.Text = "Add";
            this.btn_AddWeaponProf.UseVisualStyleBackColor = true;
            this.btn_AddWeaponProf.Click += new System.EventHandler(this.btn_AddWeaponProf_Click);
            // 
            // btn_ConfirmProf
            // 
            this.btn_ConfirmProf.Location = new System.Drawing.Point(184, 215);
            this.btn_ConfirmProf.Name = "btn_ConfirmProf";
            this.btn_ConfirmProf.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmProf.TabIndex = 13;
            this.btn_ConfirmProf.Text = "Confirm";
            this.btn_ConfirmProf.UseVisualStyleBackColor = true;
            this.btn_ConfirmProf.Click += new System.EventHandler(this.btn_ConfirmProf_Click);
            // 
            // lb_LearnedProficienies
            // 
            this.lb_LearnedProficienies.FormattingEnabled = true;
            this.lb_LearnedProficienies.Location = new System.Drawing.Point(314, 57);
            this.lb_LearnedProficienies.Name = "lb_LearnedProficienies";
            this.lb_LearnedProficienies.Size = new System.Drawing.Size(120, 95);
            this.lb_LearnedProficienies.TabIndex = 12;
            this.lb_LearnedProficienies.SelectedIndexChanged += new System.EventHandler(this.lb_LearnedProficienies_SelectedIndexChanged);
            // 
            // lb_AvailableWeaponList
            // 
            this.lb_AvailableWeaponList.FormattingEnabled = true;
            this.lb_AvailableWeaponList.Location = new System.Drawing.Point(18, 57);
            this.lb_AvailableWeaponList.Name = "lb_AvailableWeaponList";
            this.lb_AvailableWeaponList.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailableWeaponList.TabIndex = 11;
            this.lb_AvailableWeaponList.SelectedIndexChanged += new System.EventHandler(this.lb_AvailableWeaponList_SelectedIndexChanged);
            // 
            // lbl_AvailablePoints
            // 
            this.lbl_AvailablePoints.AutoSize = true;
            this.lbl_AvailablePoints.Location = new System.Drawing.Point(15, 27);
            this.lbl_AvailablePoints.Name = "lbl_AvailablePoints";
            this.lbl_AvailablePoints.Size = new System.Drawing.Size(35, 13);
            this.lbl_AvailablePoints.TabIndex = 19;
            this.lbl_AvailablePoints.Text = "label1";
            // 
            // WeaponPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 257);
            this.Controls.Add(this.lbl_AvailablePoints);
            this.Controls.Add(this.lb_SelectedProfDescription_R);
            this.Controls.Add(this.lb_SelectedProfDescription_L);
            this.Controls.Add(this.lb_WeapProfsText);
            this.Controls.Add(this.btn_RemoveWeaponProficiency);
            this.Controls.Add(this.btn_AddWeaponProf);
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
        private System.Windows.Forms.Button btn_RemoveWeaponProficiency;
        private System.Windows.Forms.Button btn_AddWeaponProf;
        private System.Windows.Forms.Button btn_ConfirmProf;
        private System.Windows.Forms.ListBox lb_LearnedProficienies;
        private System.Windows.Forms.ListBox lb_AvailableWeaponList;
        private System.Windows.Forms.Label lbl_AvailablePoints;
    }
}