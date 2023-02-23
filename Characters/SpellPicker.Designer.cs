namespace Project_Yahiko
{
    partial class SpellPicker
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
            this.lb_SelectedSpellDescSpellbook = new System.Windows.Forms.Label();
            this.lb_SelectedSpellDescription = new System.Windows.Forms.Label();
            this.btn_RemoveSpellP = new System.Windows.Forms.Button();
            this.btn_AddSpellP = new System.Windows.Forms.Button();
            this.lbl_InfoText = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lb_SpellBook = new System.Windows.Forms.ListBox();
            this.lb_AvailableSpells = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_SelectedSpellDescSpellbook
            // 
            this.lb_SelectedSpellDescSpellbook.AutoSize = true;
            this.lb_SelectedSpellDescSpellbook.Location = new System.Drawing.Point(345, 167);
            this.lb_SelectedSpellDescSpellbook.Name = "lb_SelectedSpellDescSpellbook";
            this.lb_SelectedSpellDescSpellbook.Size = new System.Drawing.Size(89, 13);
            this.lb_SelectedSpellDescSpellbook.TabIndex = 18;
            this.lb_SelectedSpellDescSpellbook.Text = "Spell Description:";
            // 
            // lb_SelectedSpellDescription
            // 
            this.lb_SelectedSpellDescription.AutoSize = true;
            this.lb_SelectedSpellDescription.Location = new System.Drawing.Point(12, 167);
            this.lb_SelectedSpellDescription.Name = "lb_SelectedSpellDescription";
            this.lb_SelectedSpellDescription.Size = new System.Drawing.Size(89, 13);
            this.lb_SelectedSpellDescription.TabIndex = 17;
            this.lb_SelectedSpellDescription.Text = "Spell Description:";
            // 
            // btn_RemoveSpellP
            // 
            this.btn_RemoveSpellP.Location = new System.Drawing.Point(186, 107);
            this.btn_RemoveSpellP.Name = "btn_RemoveSpellP";
            this.btn_RemoveSpellP.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveSpellP.TabIndex = 16;
            this.btn_RemoveSpellP.Text = "Remove";
            this.btn_RemoveSpellP.UseVisualStyleBackColor = true;
            this.btn_RemoveSpellP.Click += new System.EventHandler(this.btn_RemoveSpellP_Click);
            // 
            // btn_AddSpellP
            // 
            this.btn_AddSpellP.Location = new System.Drawing.Point(186, 63);
            this.btn_AddSpellP.Name = "btn_AddSpellP";
            this.btn_AddSpellP.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSpellP.TabIndex = 15;
            this.btn_AddSpellP.Text = "Add";
            this.btn_AddSpellP.UseVisualStyleBackColor = true;
            this.btn_AddSpellP.Click += new System.EventHandler(this.btn_AddSpellP_Click);
            // 
            // lbl_InfoText
            // 
            this.lbl_InfoText.AutoSize = true;
            this.lbl_InfoText.Location = new System.Drawing.Point(12, 9);
            this.lbl_InfoText.Name = "lbl_InfoText";
            this.lbl_InfoText.Size = new System.Drawing.Size(35, 13);
            this.lbl_InfoText.TabIndex = 14;
            this.lbl_InfoText.Text = "label3";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Enabled = false;
            this.btn_Confirm.Location = new System.Drawing.Point(186, 190);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 13;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // lb_SpellBook
            // 
            this.lb_SpellBook.FormattingEnabled = true;
            this.lb_SpellBook.Location = new System.Drawing.Point(326, 49);
            this.lb_SpellBook.Name = "lb_SpellBook";
            this.lb_SpellBook.Size = new System.Drawing.Size(120, 95);
            this.lb_SpellBook.TabIndex = 12;
            // 
            // lb_AvailableSpells
            // 
            this.lb_AvailableSpells.FormattingEnabled = true;
            this.lb_AvailableSpells.Location = new System.Drawing.Point(15, 49);
            this.lb_AvailableSpells.Name = "lb_AvailableSpells";
            this.lb_AvailableSpells.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailableSpells.TabIndex = 11;
            this.lb_AvailableSpells.SelectedIndexChanged += new System.EventHandler(this.lb_AvailableSpells_SelectedIndexChanged);
            // 
            // SpellPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 429);
            this.Controls.Add(this.lb_SelectedSpellDescSpellbook);
            this.Controls.Add(this.lb_SelectedSpellDescription);
            this.Controls.Add(this.btn_RemoveSpellP);
            this.Controls.Add(this.btn_AddSpellP);
            this.Controls.Add(this.lbl_InfoText);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lb_SpellBook);
            this.Controls.Add(this.lb_AvailableSpells);
            this.Name = "SpellPicker";
            this.Text = "SpellPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SelectedSpellDescSpellbook;
        private System.Windows.Forms.Label lb_SelectedSpellDescription;
        private System.Windows.Forms.Button btn_RemoveSpellP;
        private System.Windows.Forms.Button btn_AddSpellP;
        private System.Windows.Forms.Label lbl_InfoText;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ListBox lb_SpellBook;
        private System.Windows.Forms.ListBox lb_AvailableSpells;
    }
}