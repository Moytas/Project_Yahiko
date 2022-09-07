namespace Project_Yahiko
{
    partial class Specialization
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShinobi = new System.Windows.Forms.TabPage();
            this.tabMonk = new System.Windows.Forms.TabPage();
            this.lb_SelectedSpellDescSpellbook = new System.Windows.Forms.Label();
            this.lb_SelectedSpellDescription = new System.Windows.Forms.Label();
            this.btn_RemoveSpellP = new System.Windows.Forms.Button();
            this.btn_AddSpellP = new System.Windows.Forms.Button();
            this.lb_PriestInfoText = new System.Windows.Forms.Label();
            this.btn_confirmPriest = new System.Windows.Forms.Button();
            this.lb_PriestSpellBook = new System.Windows.Forms.ListBox();
            this.lb_AvailablePriestSpells = new System.Windows.Forms.ListBox();
            this.tabMage = new System.Windows.Forms.TabPage();
            this.lb_MageSelectedSpellBookSpell = new System.Windows.Forms.Label();
            this.lb_MageSelectedAvailableSpell = new System.Windows.Forms.Label();
            this.lb_MageInfoText = new System.Windows.Forms.Label();
            this.btn_RemoveSpellM = new System.Windows.Forms.Button();
            this.btn_AddSpellM = new System.Windows.Forms.Button();
            this.btn_ConfirmMage = new System.Windows.Forms.Button();
            this.lb_MageSpellBook = new System.Windows.Forms.ListBox();
            this.lb_AvailableSpells = new System.Windows.Forms.ListBox();
            this.tabProficiencies = new System.Windows.Forms.TabPage();
            this.lb_SelectedProfDescription_R = new System.Windows.Forms.Label();
            this.lb_SelectedProfDescription_L = new System.Windows.Forms.Label();
            this.lb_NonWeapProfsText = new System.Windows.Forms.Label();
            this.btn_RemoveLearnedProficiency = new System.Windows.Forms.Button();
            this.btn_AddNonWeaponProf = new System.Windows.Forms.Button();
            this.btn_ConfirmProf = new System.Windows.Forms.Button();
            this.lb_LearnedProficienies = new System.Windows.Forms.ListBox();
            this.lb_AvailableNonWeaponList = new System.Windows.Forms.ListBox();
            this.lb_ShinobiIntroText = new System.Windows.Forms.Label();
            this.lb_PP = new System.Windows.Forms.Label();
            this.lb_OL = new System.Windows.Forms.Label();
            this.lb_FRT = new System.Windows.Forms.Label();
            this.lb_MS = new System.Windows.Forms.Label();
            this.lb_HS = new System.Windows.Forms.Label();
            this.lb_DN = new System.Windows.Forms.Label();
            this.lb_CW = new System.Windows.Forms.Label();
            this.lb_RL = new System.Windows.Forms.Label();
            this.ud_HS = new System.Windows.Forms.NumericUpDown();
            this.ud_PP = new System.Windows.Forms.NumericUpDown();
            this.ud_OL = new System.Windows.Forms.NumericUpDown();
            this.ud_FRT = new System.Windows.Forms.NumericUpDown();
            this.ud_MS = new System.Windows.Forms.NumericUpDown();
            this.ud_DN = new System.Windows.Forms.NumericUpDown();
            this.ud_CW = new System.Windows.Forms.NumericUpDown();
            this.ud_RL = new System.Windows.Forms.NumericUpDown();
            this.btn_ThiefReset = new System.Windows.Forms.Button();
            this.btn_ThiefAccept = new System.Windows.Forms.Button();
            this.lb_PointsPool = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabShinobi.SuspendLayout();
            this.tabMonk.SuspendLayout();
            this.tabMage.SuspendLayout();
            this.tabProficiencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_HS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_PP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_OL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_FRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_MS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_DN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_CW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_RL)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShinobi);
            this.tabControl1.Controls.Add(this.tabMonk);
            this.tabControl1.Controls.Add(this.tabMage);
            this.tabControl1.Controls.Add(this.tabProficiencies);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // tabShinobi
            // 
            this.tabShinobi.Controls.Add(this.lb_PointsPool);
            this.tabShinobi.Controls.Add(this.btn_ThiefAccept);
            this.tabShinobi.Controls.Add(this.btn_ThiefReset);
            this.tabShinobi.Controls.Add(this.ud_RL);
            this.tabShinobi.Controls.Add(this.ud_CW);
            this.tabShinobi.Controls.Add(this.ud_DN);
            this.tabShinobi.Controls.Add(this.ud_MS);
            this.tabShinobi.Controls.Add(this.ud_FRT);
            this.tabShinobi.Controls.Add(this.ud_OL);
            this.tabShinobi.Controls.Add(this.ud_PP);
            this.tabShinobi.Controls.Add(this.ud_HS);
            this.tabShinobi.Controls.Add(this.lb_RL);
            this.tabShinobi.Controls.Add(this.lb_CW);
            this.tabShinobi.Controls.Add(this.lb_DN);
            this.tabShinobi.Controls.Add(this.lb_HS);
            this.tabShinobi.Controls.Add(this.lb_MS);
            this.tabShinobi.Controls.Add(this.lb_FRT);
            this.tabShinobi.Controls.Add(this.lb_OL);
            this.tabShinobi.Controls.Add(this.lb_PP);
            this.tabShinobi.Controls.Add(this.lb_ShinobiIntroText);
            this.tabShinobi.Location = new System.Drawing.Point(4, 24);
            this.tabShinobi.Name = "tabShinobi";
            this.tabShinobi.Padding = new System.Windows.Forms.Padding(3);
            this.tabShinobi.Size = new System.Drawing.Size(571, 271);
            this.tabShinobi.TabIndex = 1;
            this.tabShinobi.Text = "Shinobi";
            this.tabShinobi.UseVisualStyleBackColor = true;
            // 
            // tabMonk
            // 
            this.tabMonk.Controls.Add(this.lb_SelectedSpellDescSpellbook);
            this.tabMonk.Controls.Add(this.lb_SelectedSpellDescription);
            this.tabMonk.Controls.Add(this.btn_RemoveSpellP);
            this.tabMonk.Controls.Add(this.btn_AddSpellP);
            this.tabMonk.Controls.Add(this.lb_PriestInfoText);
            this.tabMonk.Controls.Add(this.btn_confirmPriest);
            this.tabMonk.Controls.Add(this.lb_PriestSpellBook);
            this.tabMonk.Controls.Add(this.lb_AvailablePriestSpells);
            this.tabMonk.Location = new System.Drawing.Point(4, 24);
            this.tabMonk.Name = "tabMonk";
            this.tabMonk.Size = new System.Drawing.Size(571, 271);
            this.tabMonk.TabIndex = 2;
            this.tabMonk.Text = "Sohei";
            this.tabMonk.UseVisualStyleBackColor = true;
            // 
            // lb_SelectedSpellDescSpellbook
            // 
            this.lb_SelectedSpellDescSpellbook.AutoSize = true;
            this.lb_SelectedSpellDescSpellbook.Location = new System.Drawing.Point(400, 174);
            this.lb_SelectedSpellDescSpellbook.Name = "lb_SelectedSpellDescSpellbook";
            this.lb_SelectedSpellDescSpellbook.Size = new System.Drawing.Size(89, 13);
            this.lb_SelectedSpellDescSpellbook.TabIndex = 10;
            this.lb_SelectedSpellDescSpellbook.Text = "Spell Description:";
            // 
            // lb_SelectedSpellDescription
            // 
            this.lb_SelectedSpellDescription.AutoSize = true;
            this.lb_SelectedSpellDescription.Location = new System.Drawing.Point(67, 174);
            this.lb_SelectedSpellDescription.Name = "lb_SelectedSpellDescription";
            this.lb_SelectedSpellDescription.Size = new System.Drawing.Size(89, 13);
            this.lb_SelectedSpellDescription.TabIndex = 9;
            this.lb_SelectedSpellDescription.Text = "Spell Description:";
            // 
            // btn_RemoveSpellP
            // 
            this.btn_RemoveSpellP.Location = new System.Drawing.Point(241, 114);
            this.btn_RemoveSpellP.Name = "btn_RemoveSpellP";
            this.btn_RemoveSpellP.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveSpellP.TabIndex = 8;
            this.btn_RemoveSpellP.Text = "Remove";
            this.btn_RemoveSpellP.UseVisualStyleBackColor = true;
            this.btn_RemoveSpellP.Click += new System.EventHandler(this.btn_RemoveSpellP_Click);
            // 
            // btn_AddSpellP
            // 
            this.btn_AddSpellP.Location = new System.Drawing.Point(241, 70);
            this.btn_AddSpellP.Name = "btn_AddSpellP";
            this.btn_AddSpellP.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSpellP.TabIndex = 7;
            this.btn_AddSpellP.Text = "Add";
            this.btn_AddSpellP.UseVisualStyleBackColor = true;
            this.btn_AddSpellP.Click += new System.EventHandler(this.btn_AddSpellP_Click);
            // 
            // lb_PriestInfoText
            // 
            this.lb_PriestInfoText.AutoSize = true;
            this.lb_PriestInfoText.Location = new System.Drawing.Point(67, 16);
            this.lb_PriestInfoText.Name = "lb_PriestInfoText";
            this.lb_PriestInfoText.Size = new System.Drawing.Size(35, 13);
            this.lb_PriestInfoText.TabIndex = 6;
            this.lb_PriestInfoText.Text = "label3";
            // 
            // btn_confirmPriest
            // 
            this.btn_confirmPriest.Enabled = false;
            this.btn_confirmPriest.Location = new System.Drawing.Point(241, 197);
            this.btn_confirmPriest.Name = "btn_confirmPriest";
            this.btn_confirmPriest.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmPriest.TabIndex = 5;
            this.btn_confirmPriest.Text = "Confirm";
            this.btn_confirmPriest.UseVisualStyleBackColor = true;
            this.btn_confirmPriest.Click += new System.EventHandler(this.btn_confirmPriest_Click);
            // 
            // lb_PriestSpellBook
            // 
            this.lb_PriestSpellBook.FormattingEnabled = true;
            this.lb_PriestSpellBook.Location = new System.Drawing.Point(381, 56);
            this.lb_PriestSpellBook.Name = "lb_PriestSpellBook";
            this.lb_PriestSpellBook.Size = new System.Drawing.Size(120, 95);
            this.lb_PriestSpellBook.TabIndex = 4;
            this.lb_PriestSpellBook.SelectedIndexChanged += new System.EventHandler(this.lb_PriestSpellBook_SelectedIndexChanged);
            // 
            // lb_AvailablePriestSpells
            // 
            this.lb_AvailablePriestSpells.FormattingEnabled = true;
            this.lb_AvailablePriestSpells.Location = new System.Drawing.Point(70, 56);
            this.lb_AvailablePriestSpells.Name = "lb_AvailablePriestSpells";
            this.lb_AvailablePriestSpells.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailablePriestSpells.TabIndex = 3;
            this.lb_AvailablePriestSpells.SelectedIndexChanged += new System.EventHandler(this.lb_AvailablePriestSpells_SelectedIndexChanged);
            // 
            // tabMage
            // 
            this.tabMage.Controls.Add(this.lb_MageSelectedSpellBookSpell);
            this.tabMage.Controls.Add(this.lb_MageSelectedAvailableSpell);
            this.tabMage.Controls.Add(this.lb_MageInfoText);
            this.tabMage.Controls.Add(this.btn_RemoveSpellM);
            this.tabMage.Controls.Add(this.btn_AddSpellM);
            this.tabMage.Controls.Add(this.btn_ConfirmMage);
            this.tabMage.Controls.Add(this.lb_MageSpellBook);
            this.tabMage.Controls.Add(this.lb_AvailableSpells);
            this.tabMage.Location = new System.Drawing.Point(4, 24);
            this.tabMage.Name = "tabMage";
            this.tabMage.Size = new System.Drawing.Size(571, 271);
            this.tabMage.TabIndex = 3;
            this.tabMage.Text = "Onmyoji";
            this.tabMage.UseVisualStyleBackColor = true;
            // 
            // lb_MageSelectedSpellBookSpell
            // 
            this.lb_MageSelectedSpellBookSpell.AutoSize = true;
            this.lb_MageSelectedSpellBookSpell.Location = new System.Drawing.Point(381, 181);
            this.lb_MageSelectedSpellBookSpell.Name = "lb_MageSelectedSpellBookSpell";
            this.lb_MageSelectedSpellBookSpell.Size = new System.Drawing.Size(89, 13);
            this.lb_MageSelectedSpellBookSpell.TabIndex = 12;
            this.lb_MageSelectedSpellBookSpell.Text = "Spell Description:";
            // 
            // lb_MageSelectedAvailableSpell
            // 
            this.lb_MageSelectedAvailableSpell.AutoSize = true;
            this.lb_MageSelectedAvailableSpell.Location = new System.Drawing.Point(48, 181);
            this.lb_MageSelectedAvailableSpell.Name = "lb_MageSelectedAvailableSpell";
            this.lb_MageSelectedAvailableSpell.Size = new System.Drawing.Size(89, 13);
            this.lb_MageSelectedAvailableSpell.TabIndex = 11;
            this.lb_MageSelectedAvailableSpell.Text = "Spell Description:";
            // 
            // lb_MageInfoText
            // 
            this.lb_MageInfoText.AutoSize = true;
            this.lb_MageInfoText.Location = new System.Drawing.Point(46, 17);
            this.lb_MageInfoText.Name = "lb_MageInfoText";
            this.lb_MageInfoText.Size = new System.Drawing.Size(87, 13);
            this.lb_MageInfoText.TabIndex = 5;
            this.lb_MageInfoText.Text = "lb_MageInfoText";
            // 
            // btn_RemoveSpellM
            // 
            this.btn_RemoveSpellM.Location = new System.Drawing.Point(219, 122);
            this.btn_RemoveSpellM.Name = "btn_RemoveSpellM";
            this.btn_RemoveSpellM.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveSpellM.TabIndex = 4;
            this.btn_RemoveSpellM.Text = "Remove";
            this.btn_RemoveSpellM.UseVisualStyleBackColor = true;
            this.btn_RemoveSpellM.Click += new System.EventHandler(this.btn_RemoveSpellM_Click);
            // 
            // btn_AddSpellM
            // 
            this.btn_AddSpellM.Location = new System.Drawing.Point(219, 78);
            this.btn_AddSpellM.Name = "btn_AddSpellM";
            this.btn_AddSpellM.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSpellM.TabIndex = 3;
            this.btn_AddSpellM.Text = "Add";
            this.btn_AddSpellM.UseVisualStyleBackColor = true;
            this.btn_AddSpellM.Click += new System.EventHandler(this.btn_AddSpellM_Click);
            // 
            // btn_ConfirmMage
            // 
            this.btn_ConfirmMage.Enabled = false;
            this.btn_ConfirmMage.Location = new System.Drawing.Point(236, 207);
            this.btn_ConfirmMage.Name = "btn_ConfirmMage";
            this.btn_ConfirmMage.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmMage.TabIndex = 2;
            this.btn_ConfirmMage.Text = "Confirm";
            this.btn_ConfirmMage.UseVisualStyleBackColor = true;
            this.btn_ConfirmMage.Click += new System.EventHandler(this.btn_ConfirmMage_Click);
            // 
            // lb_MageSpellBook
            // 
            this.lb_MageSpellBook.FormattingEnabled = true;
            this.lb_MageSpellBook.Location = new System.Drawing.Point(360, 69);
            this.lb_MageSpellBook.Name = "lb_MageSpellBook";
            this.lb_MageSpellBook.Size = new System.Drawing.Size(120, 95);
            this.lb_MageSpellBook.TabIndex = 1;
            this.lb_MageSpellBook.SelectedIndexChanged += new System.EventHandler(this.lb_MageSpellBook_SelectedIndexChanged);
            // 
            // lb_AvailableSpells
            // 
            this.lb_AvailableSpells.FormattingEnabled = true;
            this.lb_AvailableSpells.Location = new System.Drawing.Point(49, 69);
            this.lb_AvailableSpells.Name = "lb_AvailableSpells";
            this.lb_AvailableSpells.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailableSpells.TabIndex = 0;
            this.lb_AvailableSpells.SelectedIndexChanged += new System.EventHandler(this.lb_AvailableSpells_SelectedIndexChanged);
            // 
            // tabProficiencies
            // 
            this.tabProficiencies.Controls.Add(this.lb_SelectedProfDescription_R);
            this.tabProficiencies.Controls.Add(this.lb_SelectedProfDescription_L);
            this.tabProficiencies.Controls.Add(this.lb_NonWeapProfsText);
            this.tabProficiencies.Controls.Add(this.btn_RemoveLearnedProficiency);
            this.tabProficiencies.Controls.Add(this.btn_AddNonWeaponProf);
            this.tabProficiencies.Controls.Add(this.btn_ConfirmProf);
            this.tabProficiencies.Controls.Add(this.lb_LearnedProficienies);
            this.tabProficiencies.Controls.Add(this.lb_AvailableNonWeaponList);
            this.tabProficiencies.Location = new System.Drawing.Point(4, 24);
            this.tabProficiencies.Name = "tabProficiencies";
            this.tabProficiencies.Size = new System.Drawing.Size(571, 271);
            this.tabProficiencies.TabIndex = 4;
            this.tabProficiencies.Text = "Proficiencies";
            this.tabProficiencies.UseVisualStyleBackColor = true;
            // 
            // lb_SelectedProfDescription_R
            // 
            this.lb_SelectedProfDescription_R.AutoSize = true;
            this.lb_SelectedProfDescription_R.Location = new System.Drawing.Point(377, 175);
            this.lb_SelectedProfDescription_R.Name = "lb_SelectedProfDescription_R";
            this.lb_SelectedProfDescription_R.Size = new System.Drawing.Size(63, 13);
            this.lb_SelectedProfDescription_R.TabIndex = 10;
            this.lb_SelectedProfDescription_R.Text = "Description:";
            // 
            // lb_SelectedProfDescription_L
            // 
            this.lb_SelectedProfDescription_L.AutoSize = true;
            this.lb_SelectedProfDescription_L.Location = new System.Drawing.Point(84, 175);
            this.lb_SelectedProfDescription_L.Name = "lb_SelectedProfDescription_L";
            this.lb_SelectedProfDescription_L.Size = new System.Drawing.Size(63, 13);
            this.lb_SelectedProfDescription_L.TabIndex = 9;
            this.lb_SelectedProfDescription_L.Text = "Description:";
            // 
            // lb_NonWeapProfsText
            // 
            this.lb_NonWeapProfsText.AutoSize = true;
            this.lb_NonWeapProfsText.Location = new System.Drawing.Point(96, 22);
            this.lb_NonWeapProfsText.Name = "lb_NonWeapProfsText";
            this.lb_NonWeapProfsText.Size = new System.Drawing.Size(115, 13);
            this.lb_NonWeapProfsText.TabIndex = 8;
            this.lb_NonWeapProfsText.Text = "lb_NonWeapProfsText";
            // 
            // btn_RemoveLearnedProficiency
            // 
            this.btn_RemoveLearnedProficiency.Location = new System.Drawing.Point(239, 104);
            this.btn_RemoveLearnedProficiency.Name = "btn_RemoveLearnedProficiency";
            this.btn_RemoveLearnedProficiency.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveLearnedProficiency.TabIndex = 7;
            this.btn_RemoveLearnedProficiency.Text = "Remove";
            this.btn_RemoveLearnedProficiency.UseVisualStyleBackColor = true;
            this.btn_RemoveLearnedProficiency.Click += new System.EventHandler(this.btn_RemoveLearnedProficiency_Click);
            // 
            // btn_AddNonWeaponProf
            // 
            this.btn_AddNonWeaponProf.Location = new System.Drawing.Point(239, 60);
            this.btn_AddNonWeaponProf.Name = "btn_AddNonWeaponProf";
            this.btn_AddNonWeaponProf.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNonWeaponProf.TabIndex = 6;
            this.btn_AddNonWeaponProf.Text = "Add";
            this.btn_AddNonWeaponProf.UseVisualStyleBackColor = true;
            this.btn_AddNonWeaponProf.Click += new System.EventHandler(this.btn_AddNonWeaponProf_Click);
            // 
            // btn_ConfirmProf
            // 
            this.btn_ConfirmProf.Location = new System.Drawing.Point(239, 218);
            this.btn_ConfirmProf.Name = "btn_ConfirmProf";
            this.btn_ConfirmProf.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfirmProf.TabIndex = 5;
            this.btn_ConfirmProf.Text = "Confirm";
            this.btn_ConfirmProf.UseVisualStyleBackColor = true;
            this.btn_ConfirmProf.Click += new System.EventHandler(this.btn_ConfirmProf_Click);
            // 
            // lb_LearnedProficienies
            // 
            this.lb_LearnedProficienies.FormattingEnabled = true;
            this.lb_LearnedProficienies.Location = new System.Drawing.Point(369, 60);
            this.lb_LearnedProficienies.Name = "lb_LearnedProficienies";
            this.lb_LearnedProficienies.Size = new System.Drawing.Size(120, 95);
            this.lb_LearnedProficienies.TabIndex = 2;
            this.lb_LearnedProficienies.SelectedIndexChanged += new System.EventHandler(this.lb_LearnedProficienies_SelectedIndexChanged);
            // 
            // lb_AvailableNonWeaponList
            // 
            this.lb_AvailableNonWeaponList.FormattingEnabled = true;
            this.lb_AvailableNonWeaponList.Location = new System.Drawing.Point(73, 60);
            this.lb_AvailableNonWeaponList.Name = "lb_AvailableNonWeaponList";
            this.lb_AvailableNonWeaponList.Size = new System.Drawing.Size(120, 95);
            this.lb_AvailableNonWeaponList.TabIndex = 1;
            this.lb_AvailableNonWeaponList.SelectedIndexChanged += new System.EventHandler(this.lb_AvailableNonWeaponList_SelectedIndexChanged);
            // 
            // lb_ShinobiIntroText
            // 
            this.lb_ShinobiIntroText.AutoSize = true;
            this.lb_ShinobiIntroText.Location = new System.Drawing.Point(41, 14);
            this.lb_ShinobiIntroText.Name = "lb_ShinobiIntroText";
            this.lb_ShinobiIntroText.Size = new System.Drawing.Size(119, 13);
            this.lb_ShinobiIntroText.TabIndex = 0;
            this.lb_ShinobiIntroText.Text = "A shinobi blah blah blah";
            this.lb_ShinobiIntroText.Click += new System.EventHandler(this.lb_ShinobiIntroText_Click);
            // 
            // lb_PP
            // 
            this.lb_PP.AutoSize = true;
            this.lb_PP.Location = new System.Drawing.Point(8, 70);
            this.lb_PP.Name = "lb_PP";
            this.lb_PP.Size = new System.Drawing.Size(73, 13);
            this.lb_PP.TabIndex = 1;
            this.lb_PP.Text = "Pick Pockets:";
            this.lb_PP.Click += new System.EventHandler(this.lb_PP_Click);
            // 
            // lb_OL
            // 
            this.lb_OL.AutoSize = true;
            this.lb_OL.Location = new System.Drawing.Point(8, 118);
            this.lb_OL.Name = "lb_OL";
            this.lb_OL.Size = new System.Drawing.Size(68, 13);
            this.lb_OL.TabIndex = 2;
            this.lb_OL.Text = "Open Locks:";
            this.lb_OL.Click += new System.EventHandler(this.lb_OL_Click);
            // 
            // lb_FRT
            // 
            this.lb_FRT.AutoSize = true;
            this.lb_FRT.Location = new System.Drawing.Point(8, 158);
            this.lb_FRT.Name = "lb_FRT";
            this.lb_FRT.Size = new System.Drawing.Size(105, 13);
            this.lb_FRT.TabIndex = 3;
            this.lb_FRT.Text = "Find/Remove Traps:";
            this.lb_FRT.Click += new System.EventHandler(this.lb_FRT_Click);
            // 
            // lb_MS
            // 
            this.lb_MS.AutoSize = true;
            this.lb_MS.Location = new System.Drawing.Point(209, 70);
            this.lb_MS.Name = "lb_MS";
            this.lb_MS.Size = new System.Drawing.Size(73, 13);
            this.lb_MS.TabIndex = 4;
            this.lb_MS.Text = "Move Silently:";
            this.lb_MS.Click += new System.EventHandler(this.lb_MS_Click);
            // 
            // lb_HS
            // 
            this.lb_HS.AutoSize = true;
            this.lb_HS.Location = new System.Drawing.Point(191, 118);
            this.lb_HS.Name = "lb_HS";
            this.lb_HS.Size = new System.Drawing.Size(91, 13);
            this.lb_HS.TabIndex = 5;
            this.lb_HS.Text = "Hide In Shadows:";
            this.lb_HS.Click += new System.EventHandler(this.lb_HS_Click);
            // 
            // lb_DN
            // 
            this.lb_DN.AutoSize = true;
            this.lb_DN.Location = new System.Drawing.Point(210, 158);
            this.lb_DN.Name = "lb_DN";
            this.lb_DN.Size = new System.Drawing.Size(72, 13);
            this.lb_DN.TabIndex = 6;
            this.lb_DN.Text = "Detect Noise:";
            this.lb_DN.Click += new System.EventHandler(this.lb_DN_Click);
            // 
            // lb_CW
            // 
            this.lb_CW.AutoSize = true;
            this.lb_CW.Location = new System.Drawing.Point(383, 72);
            this.lb_CW.Name = "lb_CW";
            this.lb_CW.Size = new System.Drawing.Size(64, 13);
            this.lb_CW.TabIndex = 7;
            this.lb_CW.Text = "Climb Walls:";
            this.lb_CW.Click += new System.EventHandler(this.lb_CW_Click);
            // 
            // lb_RL
            // 
            this.lb_RL.AutoSize = true;
            this.lb_RL.Location = new System.Drawing.Point(372, 118);
            this.lb_RL.Name = "lb_RL";
            this.lb_RL.Size = new System.Drawing.Size(92, 13);
            this.lb_RL.TabIndex = 8;
            this.lb_RL.Text = "Read Languages:";
            this.lb_RL.Click += new System.EventHandler(this.lb_RL_Click);
            // 
            // ud_HS
            // 
            this.ud_HS.Location = new System.Drawing.Point(288, 118);
            this.ud_HS.Name = "ud_HS";
            this.ud_HS.Size = new System.Drawing.Size(60, 20);
            this.ud_HS.TabIndex = 9;
            this.ud_HS.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ud_HS.ValueChanged += new System.EventHandler(this.ud_HS_ValueChanged);
            // 
            // ud_PP
            // 
            this.ud_PP.Location = new System.Drawing.Point(119, 70);
            this.ud_PP.Name = "ud_PP";
            this.ud_PP.Size = new System.Drawing.Size(59, 20);
            this.ud_PP.TabIndex = 10;
            this.ud_PP.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ud_PP.ValueChanged += new System.EventHandler(this.ud_PP_ValueChanged);
            // 
            // ud_OL
            // 
            this.ud_OL.Location = new System.Drawing.Point(119, 118);
            this.ud_OL.Name = "ud_OL";
            this.ud_OL.Size = new System.Drawing.Size(59, 20);
            this.ud_OL.TabIndex = 11;
            this.ud_OL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_OL.ValueChanged += new System.EventHandler(this.ud_OL_ValueChanged);
            // 
            // ud_FRT
            // 
            this.ud_FRT.Location = new System.Drawing.Point(119, 156);
            this.ud_FRT.Name = "ud_FRT";
            this.ud_FRT.Size = new System.Drawing.Size(59, 20);
            this.ud_FRT.TabIndex = 12;
            this.ud_FRT.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ud_FRT.ValueChanged += new System.EventHandler(this.ud_FRT_ValueChanged);
            // 
            // ud_MS
            // 
            this.ud_MS.Location = new System.Drawing.Point(288, 70);
            this.ud_MS.Name = "ud_MS";
            this.ud_MS.Size = new System.Drawing.Size(60, 20);
            this.ud_MS.TabIndex = 13;
            this.ud_MS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_MS.ValueChanged += new System.EventHandler(this.ud_MS_ValueChanged);
            // 
            // ud_DN
            // 
            this.ud_DN.Location = new System.Drawing.Point(288, 158);
            this.ud_DN.Name = "ud_DN";
            this.ud_DN.Size = new System.Drawing.Size(60, 20);
            this.ud_DN.TabIndex = 14;
            this.ud_DN.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ud_DN.ValueChanged += new System.EventHandler(this.ud_DN_ValueChanged);
            // 
            // ud_CW
            // 
            this.ud_CW.Location = new System.Drawing.Point(470, 70);
            this.ud_CW.Name = "ud_CW";
            this.ud_CW.Size = new System.Drawing.Size(60, 20);
            this.ud_CW.TabIndex = 15;
            this.ud_CW.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ud_CW.ValueChanged += new System.EventHandler(this.ud_CW_ValueChanged);
            // 
            // ud_RL
            // 
            this.ud_RL.Location = new System.Drawing.Point(470, 116);
            this.ud_RL.Name = "ud_RL";
            this.ud_RL.Size = new System.Drawing.Size(60, 20);
            this.ud_RL.TabIndex = 16;
            this.ud_RL.ValueChanged += new System.EventHandler(this.ud_RL_ValueChanged);
            // 
            // btn_ThiefReset
            // 
            this.btn_ThiefReset.Location = new System.Drawing.Point(68, 217);
            this.btn_ThiefReset.Name = "btn_ThiefReset";
            this.btn_ThiefReset.Size = new System.Drawing.Size(75, 23);
            this.btn_ThiefReset.TabIndex = 17;
            this.btn_ThiefReset.Text = "Reset";
            this.btn_ThiefReset.UseVisualStyleBackColor = true;
            this.btn_ThiefReset.Click += new System.EventHandler(this.btn_reset_Clicked);
            // 
            // btn_ThiefAccept
            // 
            this.btn_ThiefAccept.Location = new System.Drawing.Point(399, 217);
            this.btn_ThiefAccept.Name = "btn_ThiefAccept";
            this.btn_ThiefAccept.Size = new System.Drawing.Size(75, 23);
            this.btn_ThiefAccept.TabIndex = 18;
            this.btn_ThiefAccept.Text = "Accept";
            this.btn_ThiefAccept.UseVisualStyleBackColor = true;
            this.btn_ThiefAccept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // lb_PointsPool
            // 
            this.lb_PointsPool.AutoSize = true;
            this.lb_PointsPool.Location = new System.Drawing.Point(24, 44);
            this.lb_PointsPool.Name = "lb_PointsPool";
            this.lb_PointsPool.Size = new System.Drawing.Size(19, 13);
            this.lb_PointsPool.TabIndex = 19;
            this.lb_PointsPool.Text = "60";
            this.lb_PointsPool.Click += new System.EventHandler(this.lb_PointsPool_Click);
            // 
            // Specialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 299);
            this.Controls.Add(this.tabControl1);
            this.Name = "Specialization";
            this.Text = "Specialization";
            this.tabControl1.ResumeLayout(false);
            this.tabShinobi.ResumeLayout(false);
            this.tabShinobi.PerformLayout();
            this.tabMonk.ResumeLayout(false);
            this.tabMonk.PerformLayout();
            this.tabMage.ResumeLayout(false);
            this.tabMage.PerformLayout();
            this.tabProficiencies.ResumeLayout(false);
            this.tabProficiencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_HS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_PP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_OL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_FRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_MS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_DN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_CW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_RL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShinobi;
        private System.Windows.Forms.TabPage tabMonk;
        private System.Windows.Forms.TabPage tabMage;
        private System.Windows.Forms.Button btn_confirmPriest;
        private System.Windows.Forms.ListBox lb_PriestSpellBook;
        private System.Windows.Forms.ListBox lb_AvailablePriestSpells;
        private System.Windows.Forms.Label lb_MageInfoText;
        private System.Windows.Forms.Button btn_RemoveSpellM;
        private System.Windows.Forms.Button btn_AddSpellM;
        private System.Windows.Forms.Button btn_ConfirmMage;
        private System.Windows.Forms.ListBox lb_MageSpellBook;
        private System.Windows.Forms.ListBox lb_AvailableSpells;
        private System.Windows.Forms.Button btn_RemoveSpellP;
        private System.Windows.Forms.Button btn_AddSpellP;
        private System.Windows.Forms.Label lb_PriestInfoText;
        private System.Windows.Forms.TabPage tabProficiencies;
        private System.Windows.Forms.Button btn_RemoveLearnedProficiency;
        private System.Windows.Forms.Button btn_AddNonWeaponProf;
        private System.Windows.Forms.Button btn_ConfirmProf;
        private System.Windows.Forms.ListBox lb_LearnedProficienies;
        private System.Windows.Forms.ListBox lb_AvailableNonWeaponList;
        private System.Windows.Forms.Label lb_NonWeapProfsText;
        private System.Windows.Forms.Label lb_SelectedSpellDescription;
        private System.Windows.Forms.Label lb_SelectedSpellDescSpellbook;
        private System.Windows.Forms.Label lb_MageSelectedSpellBookSpell;
        private System.Windows.Forms.Label lb_MageSelectedAvailableSpell;
        private System.Windows.Forms.Label lb_SelectedProfDescription_R;
        private System.Windows.Forms.Label lb_SelectedProfDescription_L;
        private System.Windows.Forms.Label lb_PointsPool;
        private System.Windows.Forms.Button btn_ThiefAccept;
        private System.Windows.Forms.Button btn_ThiefReset;
        private System.Windows.Forms.NumericUpDown ud_RL;
        private System.Windows.Forms.NumericUpDown ud_CW;
        private System.Windows.Forms.NumericUpDown ud_DN;
        private System.Windows.Forms.NumericUpDown ud_MS;
        private System.Windows.Forms.NumericUpDown ud_FRT;
        private System.Windows.Forms.NumericUpDown ud_OL;
        private System.Windows.Forms.NumericUpDown ud_PP;
        private System.Windows.Forms.NumericUpDown ud_HS;
        private System.Windows.Forms.Label lb_RL;
        private System.Windows.Forms.Label lb_CW;
        private System.Windows.Forms.Label lb_DN;
        private System.Windows.Forms.Label lb_HS;
        private System.Windows.Forms.Label lb_MS;
        private System.Windows.Forms.Label lb_FRT;
        private System.Windows.Forms.Label lb_OL;
        private System.Windows.Forms.Label lb_PP;
        private System.Windows.Forms.Label lb_ShinobiIntroText;
    }
}