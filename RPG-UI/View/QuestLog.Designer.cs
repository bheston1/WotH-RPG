namespace RPG_UI.View
{
    partial class QuestLog
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
            components = new System.ComponentModel.Container();
            btnClose = new Button();
            lvQuests = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Details = new ToolStripMenuItem();
            rtbDetails = new RichTextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(166, 417);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 48);
            btnClose.TabIndex = 38;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lvQuests
            // 
            lvQuests.BorderStyle = BorderStyle.FixedSingle;
            lvQuests.FullRowSelect = true;
            lvQuests.GridLines = true;
            lvQuests.Location = new Point(12, 12);
            lvQuests.Name = "lvQuests";
            lvQuests.Size = new Size(420, 306);
            lvQuests.TabIndex = 39;
            lvQuests.UseCompatibleStateImageBehavior = false;
            lvQuests.ColumnWidthChanging += lvQuests_ColumnWidthChanging;
            lvQuests.MouseDown += lvQuests_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Details });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(137, 26);
            // 
            // Details
            // 
            Details.Name = "Details";
            Details.Size = new Size(136, 22);
            Details.Text = "View details";
            Details.Click += Details_Click;
            // 
            // rtbDetails
            // 
            rtbDetails.BorderStyle = BorderStyle.None;
            rtbDetails.Location = new Point(12, 324);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.Size = new Size(420, 87);
            rtbDetails.TabIndex = 42;
            rtbDetails.Text = "";
            // 
            // QuestLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 477);
            ControlBox = false;
            Controls.Add(rtbDetails);
            Controls.Add(lvQuests);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QuestLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quest Log";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListView lvQuests;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Details;
        private RichTextBox rtbDetails;
    }
}