namespace RPG_UI.View
{
    partial class DeathForm
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
            label1 = new Label();
            btnRestart = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(276, 38);
            label1.TabIndex = 0;
            label1.Text = "Oh dear, you are dead!";
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(39, 78);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(107, 42);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart?";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(175, 78);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(107, 42);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // DeathForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 146);
            ControlBox = false;
            Controls.Add(btnQuit);
            Controls.Add(btnRestart);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DeathForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RIP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRestart;
        private Button btnQuit;
    }
}