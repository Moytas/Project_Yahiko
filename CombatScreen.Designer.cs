
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
      this.InfoArea = new System.Windows.Forms.Panel();
      this.OptionsPanel = new System.Windows.Forms.Panel();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.lbl_InfoText = new System.Windows.Forms.Label();
      this.lbl_Result = new System.Windows.Forms.Label();
      this.InfoArea.SuspendLayout();
      this.OptionsPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // InfoArea
      // 
      this.InfoArea.BackColor = System.Drawing.SystemColors.Desktop;
      this.InfoArea.Controls.Add(this.OptionsPanel);
      this.InfoArea.Controls.Add(this.lbl_InfoText);
      this.InfoArea.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.InfoArea.Location = new System.Drawing.Point(0, 229);
      this.InfoArea.Name = "InfoArea";
      this.InfoArea.Size = new System.Drawing.Size(582, 100);
      this.InfoArea.TabIndex = 1;
      // 
      // OptionsPanel
      // 
      this.OptionsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
      this.OptionsPanel.Controls.Add(this.button5);
      this.OptionsPanel.Controls.Add(this.button4);
      this.OptionsPanel.Controls.Add(this.button3);
      this.OptionsPanel.Controls.Add(this.button2);
      this.OptionsPanel.Controls.Add(this.button1);
      this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
      this.OptionsPanel.Name = "OptionsPanel";
      this.OptionsPanel.Size = new System.Drawing.Size(582, 100);
      this.OptionsPanel.TabIndex = 1;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(474, 44);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 4;
      this.button5.Text = "button5";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(364, 44);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "button4";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(260, 44);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(151, 44);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(38, 44);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // lbl_InfoText
      // 
      this.lbl_InfoText.AutoSize = true;
      this.lbl_InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
      this.lbl_InfoText.ForeColor = System.Drawing.SystemColors.Control;
      this.lbl_InfoText.Location = new System.Drawing.Point(33, 44);
      this.lbl_InfoText.Name = "lbl_InfoText";
      this.lbl_InfoText.Size = new System.Drawing.Size(64, 25);
      this.lbl_InfoText.TabIndex = 0;
      this.lbl_InfoText.Text = "label1";
      // 
      // lbl_Result
      // 
      this.lbl_Result.AutoSize = true;
      this.lbl_Result.Location = new System.Drawing.Point(99, 54);
      this.lbl_Result.Name = "lbl_Result";
      this.lbl_Result.Size = new System.Drawing.Size(35, 13);
      this.lbl_Result.TabIndex = 2;
      this.lbl_Result.Text = "label1";
      // 
      // CombatScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 329);
      this.Controls.Add(this.lbl_Result);
      this.Controls.Add(this.InfoArea);
      this.Name = "CombatScreen";
      this.Text = "CombatScreen";
      this.InfoArea.ResumeLayout(false);
      this.InfoArea.PerformLayout();
      this.OptionsPanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel InfoArea;
    private System.Windows.Forms.Panel OptionsPanel;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lbl_InfoText;
    private System.Windows.Forms.Label lbl_Result;
  }
}