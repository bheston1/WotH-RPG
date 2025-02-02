namespace RPG_UI.View
{
    partial class StartupForm
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
            btnNewGame = new Button();
            btnLoadGame = new Button();
            btnQuit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(59, 12);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(215, 51);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnLoadGame
            // 
            btnLoadGame.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadGame.Location = new Point(59, 69);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new Size(215, 51);
            btnLoadGame.TabIndex = 1;
            btnLoadGame.Text = "Load Game";
            btnLoadGame.UseVisualStyleBackColor = true;
            btnLoadGame.Click += btnLoadGame_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(59, 126);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(215, 51);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 189);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 3;
            label1.Text = "*Saving/loading not yet implemented";
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 218);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnQuit);
            Controls.Add(btnLoadGame);
            Controls.Add(btnNewGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Whispers of the Hollow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private Button btnLoadGame;
        private Button btnQuit;
        private Label label1;
    }
}