namespace RPG_UI.View
{
    partial class InventoryPanel
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
            lvInventory = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Examine = new ToolStripMenuItem();
            tbOutput = new TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(127, 342);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 48);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lvInventory
            // 
            lvInventory.BorderStyle = BorderStyle.FixedSingle;
            lvInventory.ContextMenuStrip = contextMenuStrip1;
            lvInventory.FullRowSelect = true;
            lvInventory.GridLines = true;
            lvInventory.Location = new Point(16, 12);
            lvInventory.Name = "lvInventory";
            lvInventory.Size = new Size(334, 295);
            lvInventory.TabIndex = 38;
            lvInventory.UseCompatibleStateImageBehavior = false;
            lvInventory.View = System.Windows.Forms.View.List;
            lvInventory.ColumnWidthChanging += lvInventory_ColumnWidthChanging;
            lvInventory.MouseDown += lvInventory_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Examine });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(120, 26);
            // 
            // Examine
            // 
            Examine.Name = "Examine";
            Examine.Size = new Size(119, 22);
            Examine.Text = "Examine";
            Examine.Click += Examine_Click;
            // 
            // tbOutput
            // 
            tbOutput.BorderStyle = BorderStyle.None;
            tbOutput.Location = new Point(16, 313);
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(334, 16);
            tbOutput.TabIndex = 39;
            // 
            // InventoryPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 401);
            ControlBox = false;
            Controls.Add(tbOutput);
            Controls.Add(lvInventory);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InventoryPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private ListView lvInventory;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Examine;
        private TextBox tbOutput;
    }
}