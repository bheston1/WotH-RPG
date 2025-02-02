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
    public partial class InventoryPanel : Form
    {
        private Player _player;
        private GameWindow _gameWindow;
        private ListViewItem? _selectedItem;
        public InventoryPanel(Player player, GameWindow gameWindow)
        {
            InitializeComponent();
            _player = player;
            _gameWindow = gameWindow;
            InitializeListView();
            UpdateInventory();
            tbOutput.Text = "Right-click an item to examine";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            _gameWindow.Enabled = true;
            _gameWindow.BringToFront();
        }

        private void InitializeListView()
        {
            lvInventory.View = System.Windows.Forms.View.Details;
            lvInventory.Columns.Add("Name", 250);
            lvInventory.Columns.Add("Quantity", 80);
            lvInventory.ColumnWidthChanging += lvInventory_ColumnWidthChanging;
            lvInventory.MouseDown += lvInventory_MouseDown;
        }

        private void UpdateInventory()
        {
            lvInventory.Items.Clear();

            var groupedItems = _player.Inventory
                .GroupBy(item => item.Name)
                .Select(group => new { Name = group.Key, Quantity = group.Count(), FirstItem = group.First() });

            foreach (var item in groupedItems)
            {
                var listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(item.Quantity.ToString());
                listItem.Tag = item.FirstItem;
                lvInventory.Items.Add(listItem);
            }
        }

        private void lvInventory_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true; // prevent resizing
            e.NewWidth = lvInventory.Columns[e.ColumnIndex].Width; // keep original width
        }

        private void lvInventory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _selectedItem = lvInventory.GetItemAt(e.X, e.Y);
                if (_selectedItem != null)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void Examine_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                if (_selectedItem.Tag is Item item)
                {
                    tbOutput.Text = $"{item.InfoText}";
                }
            }
        }
    }
}
