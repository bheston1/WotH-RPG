namespace RPG_UI.View
{
    partial class CombatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatWindow));
            btnAttack = new Button();
            btnSpellCombat = new Button();
            btnItemsCombat = new Button();
            btnFleeCombat = new Button();
            pictureBox1 = new PictureBox();
            pboSpellsCombat = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            rtbCombatLog = new RichTextBox();
            label1 = new Label();
            lblPlayerNameCombat = new Label();
            panel1 = new Panel();
            lblMonsterName = new Label();
            playerHealthBarCombat = new ProgressBar();
            monsterHealthBar = new ProgressBar();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeGameToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            lblMonsterHealth = new Label();
            lblPlayerHealthCombat = new Label();
            panel5 = new Panel();
            lblMonsterMana = new Label();
            lblPlayerManaCombat = new Label();
            cboSpells = new ComboBox();
            label2 = new Label();
            btnClose = new Button();
            cboItems = new ComboBox();
            label3 = new Label();
            lblManaCost = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboSpellsCombat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnAttack
            // 
            btnAttack.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttack.Location = new Point(81, 164);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(113, 48);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // btnSpellCombat
            // 
            btnSpellCombat.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpellCombat.Location = new Point(264, 164);
            btnSpellCombat.Name = "btnSpellCombat";
            btnSpellCombat.Size = new Size(113, 48);
            btnSpellCombat.TabIndex = 1;
            btnSpellCombat.Text = "Cast Spell";
            btnSpellCombat.UseVisualStyleBackColor = true;
            btnSpellCombat.Click += btnSpellCombat_Click;
            // 
            // btnItemsCombat
            // 
            btnItemsCombat.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItemsCombat.Location = new Point(264, 218);
            btnItemsCombat.Name = "btnItemsCombat";
            btnItemsCombat.Size = new Size(113, 48);
            btnItemsCombat.TabIndex = 2;
            btnItemsCombat.Text = "Use Item";
            btnItemsCombat.UseVisualStyleBackColor = true;
            btnItemsCombat.Click += btnItemsCombat_Click;
            // 
            // btnFleeCombat
            // 
            btnFleeCombat.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFleeCombat.Location = new Point(81, 218);
            btnFleeCombat.Name = "btnFleeCombat";
            btnFleeCombat.Size = new Size(113, 48);
            btnFleeCombat.TabIndex = 3;
            btnFleeCombat.Text = "Flee";
            btnFleeCombat.UseVisualStyleBackColor = true;
            btnFleeCombat.Click += btnFleeCombat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pboSpellsCombat
            // 
            pboSpellsCombat.Image = (Image)resources.GetObject("pboSpellsCombat.Image");
            pboSpellsCombat.Location = new Point(210, 164);
            pboSpellsCombat.Name = "pboSpellsCombat";
            pboSpellsCombat.Size = new Size(48, 48);
            pboSpellsCombat.TabIndex = 5;
            pboSpellsCombat.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(210, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // rtbCombatLog
            // 
            rtbCombatLog.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbCombatLog.Location = new Point(3, 25);
            rtbCombatLog.Name = "rtbCombatLog";
            rtbCombatLog.ReadOnly = true;
            rtbCombatLog.Size = new Size(298, 259);
            rtbCombatLog.TabIndex = 8;
            rtbCombatLog.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 9;
            label1.Text = "Combat Log";
            // 
            // lblPlayerNameCombat
            // 
            lblPlayerNameCombat.AutoSize = true;
            lblPlayerNameCombat.Dock = DockStyle.Left;
            lblPlayerNameCombat.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerNameCombat.Location = new Point(0, 0);
            lblPlayerNameCombat.Name = "lblPlayerNameCombat";
            lblPlayerNameCombat.Size = new Size(113, 25);
            lblPlayerNameCombat.TabIndex = 10;
            lblPlayerNameCombat.Text = "[player name]";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMonsterName);
            panel1.Controls.Add(lblPlayerNameCombat);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 29);
            panel1.TabIndex = 11;
            // 
            // lblMonsterName
            // 
            lblMonsterName.AutoSize = true;
            lblMonsterName.Dock = DockStyle.Right;
            lblMonsterName.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonsterName.Location = new Point(465, 0);
            lblMonsterName.Name = "lblMonsterName";
            lblMonsterName.RightToLeft = RightToLeft.Yes;
            lblMonsterName.Size = new Size(127, 25);
            lblMonsterName.TabIndex = 11;
            lblMonsterName.Text = "[monster name]";
            lblMonsterName.TextAlign = ContentAlignment.TopRight;
            // 
            // playerHealthBarCombat
            // 
            playerHealthBarCombat.ForeColor = Color.Red;
            playerHealthBarCombat.Location = new Point(12, 65);
            playerHealthBarCombat.Name = "playerHealthBarCombat";
            playerHealthBarCombat.Size = new Size(150, 20);
            playerHealthBarCombat.TabIndex = 12;
            // 
            // monsterHealthBar
            // 
            monsterHealthBar.ForeColor = Color.Red;
            monsterHealthBar.Location = new Point(454, 65);
            monsterHealthBar.Name = "monsterHealthBar";
            monsterHealthBar.RightToLeft = RightToLeft.Yes;
            monsterHealthBar.RightToLeftLayout = true;
            monsterHealthBar.Size = new Size(150, 20);
            monsterHealthBar.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 27);
            panel2.TabIndex = 26;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(928, 24);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(61, 20);
            fileToolStripMenuItem.Text = "Options";
            // 
            // closeGameToolStripMenuItem
            // 
            closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            closeGameToolStripMenuItem.Size = new Size(180, 22);
            closeGameToolStripMenuItem.Text = "Close game";
            closeGameToolStripMenuItem.Click += closeGameToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMonsterHealth);
            panel4.Controls.Add(lblPlayerHealthCombat);
            panel4.Location = new Point(168, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 20);
            panel4.TabIndex = 29;
            // 
            // lblMonsterHealth
            // 
            lblMonsterHealth.AutoSize = true;
            lblMonsterHealth.Dock = DockStyle.Right;
            lblMonsterHealth.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblMonsterHealth.Location = new Point(238, 0);
            lblMonsterHealth.Name = "lblMonsterHealth";
            lblMonsterHealth.RightToLeft = RightToLeft.Yes;
            lblMonsterHealth.Size = new Size(42, 25);
            lblMonsterHealth.TabIndex = 1;
            lblMonsterHealth.Text = "#/#";
            // 
            // lblPlayerHealthCombat
            // 
            lblPlayerHealthCombat.AutoSize = true;
            lblPlayerHealthCombat.Dock = DockStyle.Left;
            lblPlayerHealthCombat.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerHealthCombat.Location = new Point(0, 0);
            lblPlayerHealthCombat.Name = "lblPlayerHealthCombat";
            lblPlayerHealthCombat.Size = new Size(42, 25);
            lblPlayerHealthCombat.TabIndex = 0;
            lblPlayerHealthCombat.Text = "#/#";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblMonsterMana);
            panel5.Controls.Add(lblPlayerManaCombat);
            panel5.Location = new Point(12, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(592, 20);
            panel5.TabIndex = 30;
            // 
            // lblMonsterMana
            // 
            lblMonsterMana.AutoSize = true;
            lblMonsterMana.Dock = DockStyle.Right;
            lblMonsterMana.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblMonsterMana.Location = new Point(550, 0);
            lblMonsterMana.Name = "lblMonsterMana";
            lblMonsterMana.RightToLeft = RightToLeft.Yes;
            lblMonsterMana.Size = new Size(42, 25);
            lblMonsterMana.TabIndex = 3;
            lblMonsterMana.Text = "#/#";
            // 
            // lblPlayerManaCombat
            // 
            lblPlayerManaCombat.AutoSize = true;
            lblPlayerManaCombat.Dock = DockStyle.Left;
            lblPlayerManaCombat.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerManaCombat.Location = new Point(0, 0);
            lblPlayerManaCombat.Name = "lblPlayerManaCombat";
            lblPlayerManaCombat.Size = new Size(42, 25);
            lblPlayerManaCombat.TabIndex = 2;
            lblPlayerManaCombat.Text = "#/#";
            // 
            // cboSpells
            // 
            cboSpells.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSpells.FormattingEnabled = true;
            cboSpells.Location = new Point(383, 189);
            cboSpells.Name = "cboSpells";
            cboSpells.Size = new Size(212, 23);
            cboSpells.TabIndex = 31;
            cboSpells.SelectionChangeCommitted += cboSpells_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 33;
            label2.Text = "Selected spell:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(408, 312);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 48);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cboItems
            // 
            cboItems.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItems.FormattingEnabled = true;
            cboItems.Location = new Point(383, 243);
            cboItems.Name = "cboItems";
            cboItems.Size = new Size(212, 23);
            cboItems.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(383, 222);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 37;
            label3.Text = "Selected item:";
            // 
            // lblManaCost
            // 
            lblManaCost.AutoSize = true;
            lblManaCost.Dock = DockStyle.Right;
            lblManaCost.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManaCost.Location = new Point(196, 0);
            lblManaCost.Name = "lblManaCost";
            lblManaCost.Size = new Size(16, 18);
            lblManaCost.TabIndex = 38;
            lblManaCost.Text = "#";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblManaCost);
            panel3.Location = new Point(383, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 19);
            panel3.TabIndex = 39;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(rtbCombatLog);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(610, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(306, 289);
            panel6.TabIndex = 40;
            // 
            // CombatWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 372);
            ControlBox = false;
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(cboItems);
            Controls.Add(btnClose);
            Controls.Add(cboSpells);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(monsterHealthBar);
            Controls.Add(pictureBox3);
            Controls.Add(playerHealthBarCombat);
            Controls.Add(pictureBox2);
            Controls.Add(pboSpellsCombat);
            Controls.Add(pictureBox1);
            Controls.Add(btnFleeCombat);
            Controls.Add(btnItemsCombat);
            Controls.Add(btnSpellCombat);
            Controls.Add(btnAttack);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "CombatWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "An enemy appears!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboSpellsCombat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAttack;
        private Button btnSpellCombat;
        private Button btnItemsCombat;
        private Button btnFleeCombat;
        private PictureBox pictureBox1;
        private PictureBox pboSpellsCombat;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RichTextBox rtbCombatLog;
        private Label label1;
        private Label lblPlayerNameCombat;
        private Panel panel1;
        private Label lblMonsterName;
        private ProgressBar playerHealthBarCombat;
        private ProgressBar monsterHealthBar;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeGameToolStripMenuItem;
        private Panel panel4;
        private Label lblMonsterHealth;
        private Label lblPlayerHealthCombat;
        private Panel panel5;
        private Label lblMonsterMana;
        private Label lblPlayerManaCombat;
        private ComboBox cboSpells;
        private Label label2;
        private Button btnClose;
        private ComboBox cboItems;
        private Label label3;
        private Label lblManaCost;
        private Panel panel3;
        private Panel panel6;
    }
}