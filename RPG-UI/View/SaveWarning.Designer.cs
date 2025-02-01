namespace RPG_UI.View
{
    partial class SaveWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveWarning));
            btnConfirmClose = new Button();
            btnCancelClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirmClose
            // 
            btnConfirmClose.AutoSize = true;
            btnConfirmClose.Location = new Point(59, 95);
            btnConfirmClose.Name = "btnConfirmClose";
            btnConfirmClose.Size = new Size(84, 33);
            btnConfirmClose.TabIndex = 0;
            btnConfirmClose.Text = "Yes";
            btnConfirmClose.UseVisualStyleBackColor = true;
            btnConfirmClose.Click += btnConfirmClose_Click;
            // 
            // btnCancelClose
            // 
            btnCancelClose.Location = new Point(189, 95);
            btnCancelClose.Name = "btnCancelClose";
            btnCancelClose.Size = new Size(84, 33);
            btnCancelClose.TabIndex = 1;
            btnCancelClose.Text = "No";
            btnCancelClose.UseVisualStyleBackColor = true;
            btnCancelClose.Click += btnCancelClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 2;
            label1.Text = "Are you sure you want to exit?\r\nAny unsaved progress will be lost.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaveWarning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 156);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnCancelClose);
            Controls.Add(btnConfirmClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SaveWarning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Close game?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmClose;
        private Button btnCancelClose;
        private Label label1;
    }
}