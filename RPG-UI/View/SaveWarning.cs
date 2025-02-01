using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_UI.View
{
    public partial class SaveWarning : Form
    {
        private Form _parentWindow;

        public SaveWarning(Form parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void btnConfirmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            Close();
            _parentWindow.Enabled = true;
            _parentWindow.BringToFront();
        }
    }
}
