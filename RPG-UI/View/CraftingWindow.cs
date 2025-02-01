using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.Model;

namespace RPG_UI.View
{
    public partial class CraftingWindow : Form
    {
        private Player _player;
        private GameWindow _gameWindow;
        public CraftingWindow(Player player, GameWindow gameWindow)
        {
            InitializeComponent();
            _player = player;
            _gameWindow = gameWindow;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
