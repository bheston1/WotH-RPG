namespace RPG_UI.View
{
    partial class CraftingWindow
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
            btnClose = new Button();
            cboItem1 = new ComboBox();
            cboItem2 = new ComboBox();
            btnTryCraft = new Button();
            lblFirst = new Label();
            lblSecond = new Label();
            tbOutput = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(231, 147);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 48);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cboItem1
            // 
            cboItem1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItem1.FormattingEnabled = true;
            cboItem1.Location = new Point(20, 106);
            cboItem1.Name = "cboItem1";
            cboItem1.Size = new Size(200, 23);
            cboItem1.TabIndex = 37;
            // 
            // cboItem2
            // 
            cboItem2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItem2.FormattingEnabled = true;
            cboItem2.Location = new Point(236, 106);
            cboItem2.Name = "cboItem2";
            cboItem2.Size = new Size(200, 23);
            cboItem2.TabIndex = 38;
            // 
            // btnTryCraft
            // 
            btnTryCraft.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTryCraft.Location = new Point(112, 147);
            btnTryCraft.Name = "btnTryCraft";
            btnTryCraft.Size = new Size(113, 48);
            btnTryCraft.TabIndex = 39;
            btnTryCraft.Text = "Try Recipe";
            btnTryCraft.UseVisualStyleBackColor = true;
            btnTryCraft.Click += btnTryCraft_Click;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirst.Location = new Point(20, 87);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(92, 16);
            lblFirst.TabIndex = 40;
            lblFirst.Text = "First ingredient";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecond.Location = new Point(236, 87);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(105, 16);
            lblSecond.TabIndex = 41;
            lblSecond.Text = "Second ingredient";
            // 
            // tbOutput
            // 
            tbOutput.BorderStyle = BorderStyle.FixedSingle;
            tbOutput.Location = new Point(99, 32);
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(259, 23);
            tbOutput.TabIndex = 42;
            tbOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // CraftingWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 207);
            ControlBox = false;
            Controls.Add(tbOutput);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            Controls.Add(btnTryCraft);
            Controls.Add(cboItem2);
            Controls.Add(cboItem1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CraftingWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crafting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private ComboBox cboItem1;
        private ComboBox cboItem2;
        private Button btnTryCraft;
        private Label lblFirst;
        private Label lblSecond;
        private TextBox tbOutput;
    }
}