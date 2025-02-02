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
        private Item? result;
        public CraftingWindow(Player player, GameWindow gameWindow)
        {
            InitializeComponent();
            _player = player;
            _gameWindow = gameWindow;
            tbOutput.Text = "Awaiting recipe...";
            PopulateCbos();
        }

        private void PopulateCbos()
        {
            var items1 = _player.Inventory
                .Where(item => item.UsedForCrafting == true)
                .ToList();
            cboItem1.DataSource = items1;
            cboItem1.DisplayMember = "Name";

            var items2 = _player.Inventory
                .Where(item => item.UsedForCrafting == true)
                .ToList();
            cboItem2.DataSource = items2;
            cboItem2.DisplayMember = "Name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            _gameWindow.Enabled = true;
            _gameWindow.BringToFront();
        }

        private void btnTryCraft_Click(object sender, EventArgs e)
        {
            if (TryRecipe() == true && result != null)
            {
                tbOutput.Text = $"Crafted [{result.Name}]";
            }
            else if (TryRecipe() == false)
            {
                tbOutput.Text = "Invalid recipe";
            }

            PopulateCbos();
        }

        private bool TryRecipe()
        {
            if (cboItem1.SelectedItem is Item selected1 && cboItem2.SelectedItem is Item selected2)
            {
                foreach (Item item in ItemManager.CraftableItems)
                {
                    if (item.FirstIngredient == selected1 && item.SecondIngredient == selected2 || item.FirstIngredient == selected2 && item.SecondIngredient == selected1)
                    {
                        result = item;
                        _player.Inventory.Add(item);
                        _player.Inventory.Remove(selected1);
                        _player.Inventory.Remove(selected2);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
