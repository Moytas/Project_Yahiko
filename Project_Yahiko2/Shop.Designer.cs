namespace Project_Yahiko
{
    partial class Shop
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
            this.pb_ShopkeepImg = new System.Windows.Forms.PictureBox();
            this.lb_ShopkeepChat = new System.Windows.Forms.Label();
            this.gb_PlayerReplies = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShopkeepImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ShopkeepImg
            // 
            this.pb_ShopkeepImg.Location = new System.Drawing.Point(12, 12);
            this.pb_ShopkeepImg.Name = "pb_ShopkeepImg";
            this.pb_ShopkeepImg.Size = new System.Drawing.Size(242, 228);
            this.pb_ShopkeepImg.TabIndex = 0;
            this.pb_ShopkeepImg.TabStop = false;
            // 
            // lb_ShopkeepChat
            // 
            this.lb_ShopkeepChat.AutoSize = true;
            this.lb_ShopkeepChat.Location = new System.Drawing.Point(301, 27);
            this.lb_ShopkeepChat.Name = "lb_ShopkeepChat";
            this.lb_ShopkeepChat.Size = new System.Drawing.Size(35, 13);
            this.lb_ShopkeepChat.TabIndex = 1;
            this.lb_ShopkeepChat.Text = "label1";
            // 
            // gb_PlayerReplies
            // 
            this.gb_PlayerReplies.Location = new System.Drawing.Point(12, 280);
            this.gb_PlayerReplies.Name = "gb_PlayerReplies";
            this.gb_PlayerReplies.Size = new System.Drawing.Size(776, 158);
            this.gb_PlayerReplies.TabIndex = 2;
            this.gb_PlayerReplies.TabStop = false;
            this.gb_PlayerReplies.Text = "groupBox1";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_PlayerReplies);
            this.Controls.Add(this.lb_ShopkeepChat);
            this.Controls.Add(this.pb_ShopkeepImg);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShopkeepImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ShopkeepImg;
        private System.Windows.Forms.Label lb_ShopkeepChat;
        private System.Windows.Forms.GroupBox gb_PlayerReplies;
    }
}