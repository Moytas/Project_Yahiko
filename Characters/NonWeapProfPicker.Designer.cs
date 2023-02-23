
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_General = new System.Windows.Forms.ListBox();
            this.lb_Class = new System.Windows.Forms.ListBox();
            this.lb_Known = new System.Windows.Forms.ListBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.lbl_Remaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "General";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(20, 208);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(41, 13);
            this.lbl_Class.TabIndex = 1;
            this.lbl_Class.Text = "CLASS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Known";
            // 
            // lb_General
            // 
            this.lb_General.FormattingEnabled = true;
            this.lb_General.Location = new System.Drawing.Point(23, 78);
            this.lb_General.Name = "lb_General";
            this.lb_General.Size = new System.Drawing.Size(200, 95);
            this.lb_General.TabIndex = 3;
            this.lb_General.SelectedIndexChanged += new System.EventHandler(this.lb_General_SelectedIndexChanged);
            // 
            // lb_Class
            // 
            this.lb_Class.FormattingEnabled = true;
            this.lb_Class.Location = new System.Drawing.Point(23, 239);
            this.lb_Class.Name = "lb_Class";
            this.lb_Class.Size = new System.Drawing.Size(200, 95);
            this.lb_Class.TabIndex = 4;
            this.lb_Class.SelectedIndexChanged += new System.EventHandler(this.lb_Class_SelectedIndexChanged);
            // 
            // lb_Known
            // 
            this.lb_Known.FormattingEnabled = true;
            this.lb_Known.Location = new System.Drawing.Point(501, 78);
            this.lb_Known.Name = "lb_Known";
            this.lb_Known.Size = new System.Drawing.Size(120, 95);
            this.lb_Known.TabIndex = 5;
            this.lb_Known.SelectedIndexChanged += new System.EventHandler(this.lb_Known_SelectedIndexChanged);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(56, 366);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 6;
            this.lbl_Description.Text = "Description:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(333, 117);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(333, 179);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 8;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(559, 333);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 9;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            // 
            // lbl_Remaining
            // 
            this.lbl_Remaining.AutoSize = true;
            this.lbl_Remaining.Location = new System.Drawing.Point(285, 9);
            this.lbl_Remaining.Name = "lbl_Remaining";
            this.lbl_Remaining.Size = new System.Drawing.Size(60, 13);
            this.lbl_Remaining.TabIndex = 10;
            this.lbl_Remaining.Text = "Remaining:";
            // 
            // NonWeapProfPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 388);
            this.Controls.Add(this.lbl_Remaining);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lb_Known);
            this.Controls.Add(this.lb_Class);
            this.Controls.Add(this.lb_General);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.label1);
            this.Name = "NonWeapProfPicker";
            this.Text = "NonWeapProfPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_General;
        private System.Windows.Forms.ListBox lb_Class;
        private System.Windows.Forms.ListBox lb_Known;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label lbl_Remaining;
    }
}