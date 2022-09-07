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
            this.lb_PriestInfoText = new System.Windows.Forms.Label();
            this.btn_confirmPriest = new System.Windows.Forms.Button();
            this.lb_PriestSpellBook = new System.Windows.Forms.ListBox();
            this.lb_AvailablePriestSpells = new System.Windows.Forms.ListBox();
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
            // 
            // btn_AddSpellP
            // 
            this.btn_AddSpellP.Location = new System.Drawing.Point(186, 63);
            this.btn_AddSpellP.Name = "btn_AddSpellP";
            this.btn_AddSpellP.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSpellP.TabIndex = 15;
            this.btn_AddSpellP.Text = "Add";
            this.btn_AddSpellP.UseVisualStyleBackColor = true;
            // 
            // lb_PriestInfoText
            // 
            this.lb_PriestInfoText.AutoSize = true;
            this.lb_PriestInfoText.Location = new System.Drawing.Point(12, 9);
            this.lb_PriestInfoText.Name = "lb_PriestInfoText";
            this.lb_PriestInfoText.Size = new System.Drawing.Size(35, 13);
            this.lb_PriestInfoText.TabIndex = 14;
            this.lb_PriestInfoText.Text = "label3";
            // 
            // btn_confirmPriest
            // 
            this.btn_confirmPriest.Enabled = false;
            this.btn_confirmPriest.Location = new System.Drawing.Point(186, 190);
            this.btn_confirmPriest.Name = "btn_confirmPriest";
            this.btn_confirmPriest.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmPriest.TabIndex = 13;
            this.btn_confirmPriest.Text = "Confirm";
            this.btn_confirmPriest.UseVisualStyleBackColor = true;
            // 
            // lb_PriestSpellBook
            // 
            this.lb_PriestSpellBook.FormattingEnabled = true;
            this.lb_PriestSpellBook.Location = new System.Drawing.Point(326, 49);
            this.lb_PriestSpellBook.Name = "lb_PriestSpellBook";
            this.lb_PriestSpellBook.Size = new System.Drawing.Size(120, 95);
            this.lb_PriestSpellBook.TabIndex = 12;
            // 
            // lb_AvailablePriestSpells
            // 
            this.lb_AvailablePriestSpells.FormattingEnabled = true;
            this.lb_AvailablePriestSpells.Location = new System.Drawing.Point(15, 49);
            this.lb_AvailablePriestSpells.Name = "lb_AvailablePriestSpells";
            this.lb_AvailablePriestSpells.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailablePriestSpells.TabIndex = 11;
            // 
            // SpellPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 231);
            this.Controls.Add(this.lb_SelectedSpellDescSpellbook);
            this.Controls.Add(this.lb_SelectedSpellDescription);
            this.Controls.Add(this.btn_RemoveSpellP);
            this.Controls.Add(this.btn_AddSpellP);
            this.Controls.Add(this.lb_PriestInfoText);
            this.Controls.Add(this.btn_confirmPriest);
            this.Controls.Add(this.lb_PriestSpellBook);
            this.Controls.Add(this.lb_AvailablePriestSpells);
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
        private System.Windows.Forms.Label lb_PriestInfoText;
        private System.Windows.Forms.Button btn_confirmPriest;
        private System.Windows.Forms.ListBox lb_PriestSpellBook;
        private System.Windows.Forms.ListBox lb_AvailablePriestSpells;
    }
}