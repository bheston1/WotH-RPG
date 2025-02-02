namespace RPG_UI
{
    partial class GameWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            btnNorth = new Button();
            btnEast = new Button();
            btnSouth = new Button();
            btnWest = new Button();
            pboCompass = new PictureBox();
            rtbLog = new RichTextBox();
            pboMap = new PictureBox();
            navPanel = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveGameToolStripMenuItem = new ToolStripMenuItem();
            loadGameToolStripMenuItem = new ToolStripMenuItem();
            closeGameToolStripMenuItem = new ToolStripMenuItem();
            playerInfoPanel = new Panel();
            lblPlayerEssence = new Label();
            label1 = new Label();
            lblPlayerXp = new Label();
            label6 = new Label();
            lblPlayerLevel = new Label();
            label5 = new Label();
            lblPlayerMana = new Label();
            label3 = new Label();
            lblPlayerHealth = new Label();
            label2 = new Label();
            lblPlayerName = new Label();
            playerHealthBar = new ProgressBar();
            btnQuests = new Button();
            btnTalk = new Button();
            panel1 = new Panel();
            btnSearch = new Button();
            btnBag = new Button();
            panel3 = new Panel();
            label10 = new Label();
            lblManaCost = new Label();
            label12 = new Label();
            cboItems = new ComboBox();
            cboSpells = new ComboBox();
            pictureBox2 = new PictureBox();
            pboSpellsCombat = new PictureBox();
            btnItem = new Button();
            btnSpell = new Button();
            pboCraft = new PictureBox();
            btnCrafting = new Button();
            btnCamp = new Button();
            btnEquipment = new Button();
            pboGear = new PictureBox();
            label4 = new Label();
            lblLocation = new Label();
            label11 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pboCompass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboMap).BeginInit();
            navPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            playerInfoPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboSpellsCombat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboCraft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboGear).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNorth
            // 
            btnNorth.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNorth.Location = new Point(65, 11);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(48, 48);
            btnNorth.TabIndex = 0;
            btnNorth.Text = "N";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnEast
            // 
            btnEast.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEast.Location = new Point(119, 65);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(48, 48);
            btnEast.TabIndex = 1;
            btnEast.Text = "E";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnSouth
            // 
            btnSouth.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSouth.Location = new Point(65, 119);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(48, 48);
            btnSouth.TabIndex = 2;
            btnSouth.Text = "S";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // btnWest
            // 
            btnWest.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWest.Location = new Point(11, 65);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(48, 48);
            btnWest.TabIndex = 3;
            btnWest.Text = "W";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // pboCompass
            // 
            pboCompass.Image = (Image)resources.GetObject("pboCompass.Image");
            pboCompass.Location = new Point(65, 65);
            pboCompass.Name = "pboCompass";
            pboCompass.Size = new Size(48, 48);
            pboCompass.TabIndex = 4;
            pboCompass.TabStop = false;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = SystemColors.Control;
            rtbLog.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbLog.Location = new Point(12, 309);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(714, 99);
            rtbLog.TabIndex = 5;
            rtbLog.Text = "";
            // 
            // pboMap
            // 
            pboMap.BackColor = SystemColors.Control;
            pboMap.BorderStyle = BorderStyle.FixedSingle;
            pboMap.Location = new Point(476, 27);
            pboMap.Name = "pboMap";
            pboMap.Size = new Size(250, 250);
            pboMap.TabIndex = 6;
            pboMap.TabStop = false;
            // 
            // navPanel
            // 
            navPanel.BackColor = SystemColors.Control;
            navPanel.BorderStyle = BorderStyle.FixedSingle;
            navPanel.Controls.Add(pboCompass);
            navPanel.Controls.Add(btnEast);
            navPanel.Controls.Add(btnNorth);
            navPanel.Controls.Add(btnSouth);
            navPanel.Controls.Add(btnWest);
            navPanel.Location = new Point(546, 414);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(180, 180);
            navPanel.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(738, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveGameToolStripMenuItem, loadGameToolStripMenuItem, closeGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(61, 20);
            fileToolStripMenuItem.Text = "Options";
            // 
            // saveGameToolStripMenuItem
            // 
            saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            saveGameToolStripMenuItem.Size = new Size(136, 22);
            saveGameToolStripMenuItem.Text = "Save game";
            // 
            // loadGameToolStripMenuItem
            // 
            loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            loadGameToolStripMenuItem.Size = new Size(136, 22);
            loadGameToolStripMenuItem.Text = "Load game";
            // 
            // closeGameToolStripMenuItem
            // 
            closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            closeGameToolStripMenuItem.Size = new Size(136, 22);
            closeGameToolStripMenuItem.Text = "Close game";
            closeGameToolStripMenuItem.Click += closeGameToolStripMenuItem_Click;
            // 
            // playerInfoPanel
            // 
            playerInfoPanel.BackColor = SystemColors.Control;
            playerInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            playerInfoPanel.Controls.Add(lblPlayerEssence);
            playerInfoPanel.Controls.Add(label1);
            playerInfoPanel.Controls.Add(lblPlayerXp);
            playerInfoPanel.Controls.Add(label6);
            playerInfoPanel.Controls.Add(lblPlayerLevel);
            playerInfoPanel.Controls.Add(label5);
            playerInfoPanel.Controls.Add(lblPlayerMana);
            playerInfoPanel.Controls.Add(label3);
            playerInfoPanel.Controls.Add(lblPlayerHealth);
            playerInfoPanel.Controls.Add(label2);
            playerInfoPanel.Controls.Add(lblPlayerName);
            playerInfoPanel.Controls.Add(playerHealthBar);
            playerInfoPanel.Location = new Point(12, 27);
            playerInfoPanel.Name = "playerInfoPanel";
            playerInfoPanel.Size = new Size(458, 250);
            playerInfoPanel.TabIndex = 9;
            // 
            // lblPlayerEssence
            // 
            lblPlayerEssence.AutoSize = true;
            lblPlayerEssence.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerEssence.Location = new Point(99, 146);
            lblPlayerEssence.Name = "lblPlayerEssence";
            lblPlayerEssence.Size = new Size(22, 25);
            lblPlayerEssence.TabIndex = 31;
            lblPlayerEssence.Text = "#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 146);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 24;
            label1.Text = "Essence:";
            // 
            // lblPlayerXp
            // 
            lblPlayerXp.AutoSize = true;
            lblPlayerXp.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerXp.Location = new Point(56, 69);
            lblPlayerXp.Name = "lblPlayerXp";
            lblPlayerXp.Size = new Size(42, 25);
            lblPlayerXp.TabIndex = 20;
            lblPlayerXp.Text = "#/#";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            label6.Location = new Point(10, 69);
            label6.Name = "label6";
            label6.Size = new Size(40, 25);
            label6.TabIndex = 19;
            label6.Text = "XP:";
            // 
            // lblPlayerLevel
            // 
            lblPlayerLevel.AutoSize = true;
            lblPlayerLevel.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerLevel.Location = new Point(70, 44);
            lblPlayerLevel.Name = "lblPlayerLevel";
            lblPlayerLevel.Size = new Size(22, 25);
            lblPlayerLevel.TabIndex = 18;
            lblPlayerLevel.Text = "#";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            label5.Location = new Point(10, 44);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 17;
            label5.Text = "Level";
            // 
            // lblPlayerMana
            // 
            lblPlayerMana.AutoSize = true;
            lblPlayerMana.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerMana.Location = new Point(60, 121);
            lblPlayerMana.Name = "lblPlayerMana";
            lblPlayerMana.Size = new Size(42, 25);
            lblPlayerMana.TabIndex = 16;
            lblPlayerMana.Text = "#/#";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 121);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 15;
            label3.Text = "MP:";
            // 
            // lblPlayerHealth
            // 
            lblPlayerHealth.AutoSize = true;
            lblPlayerHealth.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            lblPlayerHealth.Location = new Point(214, 97);
            lblPlayerHealth.Name = "lblPlayerHealth";
            lblPlayerHealth.Size = new Size(42, 25);
            lblPlayerHealth.TabIndex = 14;
            lblPlayerHealth.Text = "#/#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 95);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 13;
            label2.Text = "HP:";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerName.Location = new Point(10, 11);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(145, 33);
            lblPlayerName.TabIndex = 12;
            lblPlayerName.Text = "[player name]";
            // 
            // playerHealthBar
            // 
            playerHealthBar.ForeColor = Color.Red;
            playerHealthBar.Location = new Point(58, 99);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(150, 20);
            playerHealthBar.Style = ProgressBarStyle.Continuous;
            playerHealthBar.TabIndex = 10;
            // 
            // btnQuests
            // 
            btnQuests.Font = new Font("Papyrus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuests.Image = (Image)resources.GetObject("btnQuests.Image");
            btnQuests.Location = new Point(465, 12);
            btnQuests.Name = "btnQuests";
            btnQuests.Size = new Size(48, 48);
            btnQuests.TabIndex = 32;
            btnQuests.UseVisualStyleBackColor = true;
            btnQuests.Click += btnQuests_Click;
            // 
            // btnTalk
            // 
            btnTalk.Image = (Image)resources.GetObject("btnTalk.Image");
            btnTalk.Location = new Point(411, 65);
            btnTalk.Name = "btnTalk";
            btnTalk.Size = new Size(48, 48);
            btnTalk.TabIndex = 9;
            btnTalk.UseVisualStyleBackColor = true;
            btnTalk.Click += btnTalk_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnBag);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cboItems);
            panel1.Controls.Add(cboSpells);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pboSpellsCombat);
            panel1.Controls.Add(btnItem);
            panel1.Controls.Add(btnSpell);
            panel1.Controls.Add(btnQuests);
            panel1.Controls.Add(pboCraft);
            panel1.Controls.Add(btnCrafting);
            panel1.Controls.Add(btnCamp);
            panel1.Controls.Add(btnEquipment);
            panel1.Controls.Add(pboGear);
            panel1.Controls.Add(btnTalk);
            panel1.Location = new Point(12, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 180);
            panel1.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(465, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 32;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBag
            // 
            btnBag.Image = (Image)resources.GetObject("btnBag.Image");
            btnBag.Location = new Point(411, 11);
            btnBag.Name = "btnBag";
            btnBag.Size = new Size(48, 48);
            btnBag.TabIndex = 32;
            btnBag.UseVisualStyleBackColor = true;
            btnBag.Click += btnBag_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblManaCost);
            panel3.Location = new Point(182, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 19);
            panel3.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Left;
            label10.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 18);
            label10.TabIndex = 33;
            label10.Text = "Selected spell:";
            // 
            // lblManaCost
            // 
            lblManaCost.AutoSize = true;
            lblManaCost.Dock = DockStyle.Right;
            lblManaCost.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManaCost.Location = new Point(212, 0);
            lblManaCost.Name = "lblManaCost";
            lblManaCost.Size = new Size(0, 18);
            lblManaCost.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(182, 123);
            label12.Name = "label12";
            label12.Size = new Size(92, 18);
            label12.TabIndex = 46;
            label12.Text = "Selected item:";
            // 
            // cboItems
            // 
            cboItems.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItems.FormattingEnabled = true;
            cboItems.Location = new Point(182, 144);
            cboItems.Name = "cboItems";
            cboItems.Size = new Size(212, 23);
            cboItems.TabIndex = 45;
            // 
            // cboSpells
            // 
            cboSpells.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSpells.FormattingEnabled = true;
            cboSpells.Location = new Point(182, 90);
            cboSpells.Name = "cboSpells";
            cboSpells.Size = new Size(212, 23);
            cboSpells.TabIndex = 44;
            cboSpells.SelectionChangeCommitted += cboSpells_SelectionChangeCommitted;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pboSpellsCombat
            // 
            pboSpellsCombat.Image = (Image)resources.GetObject("pboSpellsCombat.Image");
            pboSpellsCombat.Location = new Point(9, 65);
            pboSpellsCombat.Name = "pboSpellsCombat";
            pboSpellsCombat.Size = new Size(48, 48);
            pboSpellsCombat.TabIndex = 42;
            pboSpellsCombat.TabStop = false;
            // 
            // btnItem
            // 
            btnItem.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItem.Location = new Point(63, 119);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(113, 48);
            btnItem.TabIndex = 41;
            btnItem.Text = "Use Item";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += btnItem_Click;
            // 
            // btnSpell
            // 
            btnSpell.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpell.Location = new Point(63, 65);
            btnSpell.Name = "btnSpell";
            btnSpell.Size = new Size(113, 48);
            btnSpell.TabIndex = 40;
            btnSpell.Text = "Cast Spell";
            btnSpell.UseVisualStyleBackColor = true;
            btnSpell.Click += btnSpell_Click;
            // 
            // pboCraft
            // 
            pboCraft.Image = (Image)resources.GetObject("pboCraft.Image");
            pboCraft.Location = new Point(181, 11);
            pboCraft.Name = "pboCraft";
            pboCraft.Size = new Size(48, 48);
            pboCraft.TabIndex = 10;
            pboCraft.TabStop = false;
            // 
            // btnCrafting
            // 
            btnCrafting.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrafting.Location = new Point(236, 11);
            btnCrafting.Name = "btnCrafting";
            btnCrafting.Size = new Size(113, 48);
            btnCrafting.TabIndex = 9;
            btnCrafting.Text = "Crafting";
            btnCrafting.UseVisualStyleBackColor = true;
            btnCrafting.Click += btnCrafting_Click;
            // 
            // btnCamp
            // 
            btnCamp.Image = (Image)resources.GetObject("btnCamp.Image");
            btnCamp.Location = new Point(438, 119);
            btnCamp.Name = "btnCamp";
            btnCamp.Size = new Size(48, 48);
            btnCamp.TabIndex = 24;
            btnCamp.UseVisualStyleBackColor = true;
            btnCamp.Click += btnCamp_Click;
            // 
            // btnEquipment
            // 
            btnEquipment.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipment.Location = new Point(62, 11);
            btnEquipment.Name = "btnEquipment";
            btnEquipment.Size = new Size(113, 48);
            btnEquipment.TabIndex = 3;
            btnEquipment.Text = "Equipment";
            btnEquipment.UseVisualStyleBackColor = true;
            btnEquipment.Click += btnEquipment_Click;
            // 
            // pboGear
            // 
            pboGear.Image = (Image)resources.GetObject("pboGear.Image");
            pboGear.Location = new Point(9, 11);
            pboGear.Name = "pboGear";
            pboGear.Size = new Size(48, 48);
            pboGear.TabIndex = 2;
            pboGear.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 11;
            label4.Text = "Log";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Dock = DockStyle.Right;
            lblLocation.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(642, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.RightToLeft = RightToLeft.Yes;
            lblLocation.Size = new Size(72, 19);
            lblLocation.TabIndex = 28;
            lblLocation.Text = "[location]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(524, 142);
            label11.Name = "label11";
            label11.Size = new Size(150, 30);
            label11.TabIndex = 29;
            label11.Text = "MAP GO HERE";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblLocation);
            panel2.Location = new Point(12, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 20);
            panel2.TabIndex = 30;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(738, 606);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(playerInfoPanel);
            Controls.Add(navPanel);
            Controls.Add(pboMap);
            Controls.Add(rtbLog);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "GameWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Whispers of the Hollow";
            ((System.ComponentModel.ISupportInitialize)pboCompass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboMap).EndInit();
            navPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            playerInfoPanel.ResumeLayout(false);
            playerInfoPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboSpellsCombat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboCraft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboGear).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNorth;
        private Button btnEast;
        private Button btnSouth;
        private Button btnWest;
        private PictureBox pboCompass;
        private RichTextBox rtbLog;
        private PictureBox pboMap;
        private Panel navPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private ToolStripMenuItem loadGameToolStripMenuItem;
        private Panel playerInfoPanel;
        private ProgressBar playerHealthBar;
        private Label lblPlayerName;
        private Label lblPlayerMana;
        private Label label3;
        private Label lblPlayerHealth;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label lblPlayerLevel;
        private Label lblPlayerXp;
        private Label label6;
        private Button btnEquipment;
        private PictureBox pboGear;
        private Button btnTalk;
        private Button btnCrafting;
        private PictureBox pboCraft;
        private Button btnCamp;
        private ToolStripMenuItem closeGameToolStripMenuItem;
        private Label lblLocation;
        private Label label11;
        private Panel panel2;
        private Label lblPlayerEssence;
        private Label label1;
        private Button btnQuests;
        private Panel panel3;
        private Label label10;
        private Label lblManaCost;
        private Label label12;
        private ComboBox cboItems;
        private ComboBox cboSpells;
        private PictureBox pictureBox2;
        private PictureBox pboSpellsCombat;
        private Button btnItem;
        private Button btnSpell;
        private Button btnBag;
        private Button btnSearch;
    }
}
