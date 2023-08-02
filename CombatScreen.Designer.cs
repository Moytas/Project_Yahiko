
namespace Project_Yahiko
{
  partial class CombatScreen
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
      this.lbl_DmText = new System.Windows.Forms.Label();
      this.InfoPanel = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // lbl_DmText
      // 
      this.lbl_DmText.AutoSize = true;
      this.lbl_DmText.Location = new System.Drawing.Point(404, 50);
      this.lbl_DmText.Name = "lbl_DmText";
      this.lbl_DmText.Size = new System.Drawing.Size(35, 13);
      this.lbl_DmText.TabIndex = 2;
      this.lbl_DmText.Text = "label1";
      // 
      // InfoPanel
      // 
      this.InfoPanel.BackColor = System.Drawing.Color.Gray;
      this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.InfoPanel.Location = new System.Drawing.Point(0, 401);
      this.InfoPanel.Name = "InfoPanel";
      this.InfoPanel.Size = new System.Drawing.Size(479, 105);
      this.InfoPanel.TabIndex = 5;
      // 
      // CombatScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(479, 506);
      this.Controls.Add(this.InfoPanel);
      this.Controls.Add(this.lbl_DmText);
      this.Name = "CombatScreen";
      this.Text = "CombatScreen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lbl_DmText;
    private System.Windows.Forms.Panel InfoPanel;
  }
}