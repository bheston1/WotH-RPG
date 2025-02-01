namespace RPG_UI.View
{
    partial class CharacterCreationForm
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
            rtbIntroText = new RichTextBox();
            nameInputBox = new TextBox();
            label1 = new Label();
            btnConfirmName = new Button();
            SuspendLayout();
            // 
            // rtbIntroText
            // 
            rtbIntroText.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbIntroText.Location = new Point(12, 12);
            rtbIntroText.Name = "rtbIntroText";
            rtbIntroText.ReadOnly = true;
            rtbIntroText.Size = new Size(488, 93);
            rtbIntroText.TabIndex = 0;
            rtbIntroText.Text = "";
            // 
            // nameInputBox
            // 
            nameInputBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameInputBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameInputBox.Location = new Point(140, 141);
            nameInputBox.Name = "nameInputBox";
            nameInputBox.Size = new Size(232, 29);
            nameInputBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 117);
            label1.Name = "label1";
            label1.Size = new Size(197, 17);
            label1.TabIndex = 2;
            label1.Text = "Enter a name for your character:";
            // 
            // btnConfirmName
            // 
            btnConfirmName.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmName.Location = new Point(183, 183);
            btnConfirmName.Name = "btnConfirmName";
            btnConfirmName.Size = new Size(145, 48);
            btnConfirmName.TabIndex = 3;
            btnConfirmName.Text = "Confirm";
            btnConfirmName.UseVisualStyleBackColor = true;
            btnConfirmName.Click += btnConfirmName_Click;
            // 
            // CharacterCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 243);
            ControlBox = false;
            Controls.Add(btnConfirmName);
            Controls.Add(nameInputBox);
            Controls.Add(label1);
            Controls.Add(rtbIntroText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CharacterCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Creation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbIntroText;
        private TextBox nameInputBox;
        private Label label1;
        private Button btnConfirmName;
    }
}