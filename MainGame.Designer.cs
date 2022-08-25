namespace Project_Yahiko
{
    partial class MainGame
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
            this.btn_CharSheet = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.btn_Spells = new System.Windows.Forms.Button();
            this.Panel_Story = new System.Windows.Forms.Panel();
            this.Panel_PlayerChoise = new System.Windows.Forms.Panel();
            this.Panel_CharButtons = new System.Windows.Forms.Panel();
            this.tb_DMText = new System.Windows.Forms.TextBox();
            this.Panel_Story.SuspendLayout();
            this.Panel_CharButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CharSheet
            // 
            this.btn_CharSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CharSheet.Location = new System.Drawing.Point(18, 16);
            this.btn_CharSheet.Name = "btn_CharSheet";
            this.btn_CharSheet.Size = new System.Drawing.Size(98, 33);
            this.btn_CharSheet.TabIndex = 0;
            this.btn_CharSheet.Text = "Character Sheet";
            this.btn_CharSheet.UseVisualStyleBackColor = true;
            this.btn_CharSheet.Click += new System.EventHandler(this.btn_CharSheet_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inventory.Location = new System.Drawing.Point(158, 16);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Inventory.TabIndex = 1;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.UseVisualStyleBackColor = true;
            // 
            // btn_Spells
            // 
            this.btn_Spells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Spells.Location = new System.Drawing.Point(158, 80);
            this.btn_Spells.Name = "btn_Spells";
            this.btn_Spells.Size = new System.Drawing.Size(75, 23);
            this.btn_Spells.TabIndex = 2;
            this.btn_Spells.Text = "Spells";
            this.btn_Spells.UseVisualStyleBackColor = true;
            // 
            // Panel_Story
            // 
            this.Panel_Story.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Story.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_Story.Controls.Add(this.tb_DMText);
            this.Panel_Story.Location = new System.Drawing.Point(299, 12);
            this.Panel_Story.Name = "Panel_Story";
            this.Panel_Story.Size = new System.Drawing.Size(489, 363);
            this.Panel_Story.TabIndex = 3;
            // 
            // Panel_PlayerChoise
            // 
            this.Panel_PlayerChoise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_PlayerChoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_PlayerChoise.Location = new System.Drawing.Point(12, 235);
            this.Panel_PlayerChoise.Name = "Panel_PlayerChoise";
            this.Panel_PlayerChoise.Size = new System.Drawing.Size(255, 140);
            this.Panel_PlayerChoise.TabIndex = 4;
            // 
            // Panel_CharButtons
            // 
            this.Panel_CharButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_CharButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_CharButtons.Controls.Add(this.btn_CharSheet);
            this.Panel_CharButtons.Controls.Add(this.btn_Inventory);
            this.Panel_CharButtons.Controls.Add(this.btn_Spells);
            this.Panel_CharButtons.Location = new System.Drawing.Point(12, 12);
            this.Panel_CharButtons.Name = "Panel_CharButtons";
            this.Panel_CharButtons.Size = new System.Drawing.Size(255, 192);
            this.Panel_CharButtons.TabIndex = 5;
            // 
            // tb_DMText
            // 
            this.tb_DMText.BackColor = System.Drawing.Color.Silver;
            this.tb_DMText.Enabled = false;
            this.tb_DMText.ForeColor = System.Drawing.Color.Maroon;
            this.tb_DMText.Location = new System.Drawing.Point(30, 23);
            this.tb_DMText.Multiline = true;
            this.tb_DMText.Name = "tb_DMText";
            this.tb_DMText.Size = new System.Drawing.Size(445, 322);
            this.tb_DMText.TabIndex = 0;
            this.tb_DMText.TabStop = false;
            this.tb_DMText.Text = "Welcome to Yahiko... blah blah blah\r\n";
            this.tb_DMText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.Panel_CharButtons);
            this.Controls.Add(this.Panel_PlayerChoise);
            this.Controls.Add(this.Panel_Story);
            this.Name = "MainGame";
            this.Text = "Yahiko";
            this.Panel_Story.ResumeLayout(false);
            this.Panel_Story.PerformLayout();
            this.Panel_CharButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CharSheet;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_Spells;
        private System.Windows.Forms.Panel Panel_Story;
        private System.Windows.Forms.TextBox tb_DMText;
        private System.Windows.Forms.Panel Panel_PlayerChoise;
        private System.Windows.Forms.Panel Panel_CharButtons;
    }
}