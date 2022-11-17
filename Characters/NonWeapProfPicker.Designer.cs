namespace Project_Yahiko
{
    partial class NonWeapProfPicker
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
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_NonWeapProfsText = new System.Windows.Forms.Label();
            this.btn_RemoveLearnedProficiency = new System.Windows.Forms.Button();
            this.btn_AddNonWeaponProf = new System.Windows.Forms.Button();
            this.btn_ConfirmProf = new System.Windows.Forms.Button();
            this.lb_LearnedProficienies = new System.Windows.Forms.ListBox();
            this.lb_AvailableNonWeaponGeneral = new System.Windows.Forms.ListBox();
            this.lb_AvailableNonWeaponClass = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(19, 250);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 17;
            this.lbl_Description.Text = "Description:";
            // 
            // lbl_NonWeapProfsText
            // 
            this.lbl_NonWeapProfsText.AutoSize = true;
            this.lbl_NonWeapProfsText.Location = new System.Drawing.Point(19, 9);
            this.lbl_NonWeapProfsText.Name = "lbl_NonWeapProfsText";
            this.lbl_NonWeapProfsText.Size = new System.Drawing.Size(117, 13);
            this.lbl_NonWeapProfsText.TabIndex = 16;
            this.lbl_NonWeapProfsText.Text = "lbl_NonWeapProfsText";
            // 
            // btn_RemoveLearnedProficiency
            // 
            this.btn_RemoveLearnedProficiency.Location = new System.Drawing.Point(224, 155);
            this.btn_RemoveLearnedProficiency.Name = "btn_RemoveLearnedProficiency";
            this.btn_RemoveLearnedProficiency.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveLearnedProficiency.TabIndex = 15;
            this.btn_RemoveLearnedProficiency.Text = "Remove";
            this.btn_RemoveLearnedProficiency.UseVisualStyleBackColor = true;
            this.btn_RemoveLearnedProficiency.Click += new System.EventHandler(this.btn_RemoveLearnedProficiency_Click);
            // 
            // btn_AddNonWeaponProf
            // 
            this.btn_AddNonWeaponProf.Location = new System.Drawing.Point(224, 126);
            this.btn_AddNonWeaponProf.Name = "btn_AddNonWeaponProf";
            this.btn_AddNonWeaponProf.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNonWeaponProf.TabIndex = 14;
            this.btn_AddNonWeaponProf.Text = "Add";
            this.btn_AddNonWeaponProf.UseVisualStyleBackColor = true;
            this.btn_AddNonWeaponProf.Click += new System.EventHandler(this.btn_AddNonWeaponProf_Click);
            // 
            // btn_ConfirmProf
            // 
            this.btn_ConfirmProf.Location = new System.Drawing.Point(363, 280);
            this.btn_ConfirmProf.Name = "btn_ConfirmProf";
            this.btn_ConfirmProf.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmProf.TabIndex = 13;
            this.btn_ConfirmProf.Text = "Confirm";
            this.btn_ConfirmProf.UseVisualStyleBackColor = true;
            // 
            // lb_LearnedProficienies
            // 
            this.lb_LearnedProficienies.FormattingEnabled = true;
            this.lb_LearnedProficienies.Location = new System.Drawing.Point(318, 56);
            this.lb_LearnedProficienies.Name = "lb_LearnedProficienies";
            this.lb_LearnedProficienies.Size = new System.Drawing.Size(120, 199);
            this.lb_LearnedProficienies.TabIndex = 12;
            // 
            // lb_AvailableNonWeaponGeneral
            // 
            this.lb_AvailableNonWeaponGeneral.FormattingEnabled = true;
            this.lb_AvailableNonWeaponGeneral.Location = new System.Drawing.Point(22, 56);
            this.lb_AvailableNonWeaponGeneral.Name = "lb_AvailableNonWeaponGeneral";
            this.lb_AvailableNonWeaponGeneral.Size = new System.Drawing.Size(177, 82);
            this.lb_AvailableNonWeaponGeneral.TabIndex = 11;
            this.lb_AvailableNonWeaponGeneral.SelectedValueChanged += new System.EventHandler(this.lb_AvailableNonWeaponGeneral_SelectedValueChanged);
            // 
            // lb_AvailableNonWeaponClass
            // 
            this.lb_AvailableNonWeaponClass.FormattingEnabled = true;
            this.lb_AvailableNonWeaponClass.Location = new System.Drawing.Point(22, 165);
            this.lb_AvailableNonWeaponClass.Name = "lb_AvailableNonWeaponClass";
            this.lb_AvailableNonWeaponClass.Size = new System.Drawing.Size(177, 82);
            this.lb_AvailableNonWeaponClass.TabIndex = 18;
            this.lb_AvailableNonWeaponClass.SelectedIndexChanged += new System.EventHandler(this.lb_AvailableNonWeaponClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Class";
            // 
            // NonWeapProfPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_AvailableNonWeaponClass);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_NonWeapProfsText);
            this.Controls.Add(this.btn_RemoveLearnedProficiency);
            this.Controls.Add(this.btn_AddNonWeaponProf);
            this.Controls.Add(this.btn_ConfirmProf);
            this.Controls.Add(this.lb_LearnedProficienies);
            this.Controls.Add(this.lb_AvailableNonWeaponGeneral);
            this.Name = "NonWeapProfPicker";
            this.Text = "NonWeapProfPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_NonWeapProfsText;
        private System.Windows.Forms.Button btn_RemoveLearnedProficiency;
        private System.Windows.Forms.Button btn_AddNonWeaponProf;
        private System.Windows.Forms.Button btn_ConfirmProf;
        private System.Windows.Forms.ListBox lb_LearnedProficienies;
        private System.Windows.Forms.ListBox lb_AvailableNonWeaponGeneral;
        private System.Windows.Forms.ListBox lb_AvailableNonWeaponClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}