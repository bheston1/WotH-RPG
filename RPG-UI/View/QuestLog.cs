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
    public partial class QuestLog : Form
    {
        private Player _player;
        private GameWindow _gameWindow;
        private ListViewItem? _selectedQuest;
        public QuestLog(Player player, GameWindow gameWindow)
        {
            InitializeComponent();
            rtbDetails.Text = "Right-click quest for details";
            _player = player;
            _gameWindow = gameWindow;
            InitializeListView();
            UpdateQuestList();
        }

        private void InitializeListView()
        {
            lvQuests.View = System.Windows.Forms.View.Details;
            lvQuests.Columns.Add("Name", 415);
            lvQuests.ColumnWidthChanging += lvQuests_ColumnWidthChanging;
            lvQuests.MouseDown += lvQuests_MouseDown;
        }

        private void UpdateQuestList()
        {
            lvQuests.Items.Clear();
            foreach (Quest quest in _player.QuestLog)
            {
                var listItem = new ListViewItem(quest.Name)
                {
                    Tag = quest
                };
                lvQuests.Items.Add(listItem);
            }
        }

        private void lvQuests_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvQuests.Columns[e.ColumnIndex].Width;
        }

        private void lvQuests_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _selectedQuest = lvQuests.GetItemAt(e.X, e.Y);
                if( _selectedQuest != null)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            _gameWindow.Enabled = true;
            _gameWindow.BringToFront();
        }

        private void Details_Click(object sender, EventArgs e)
        {
            if (_selectedQuest != null && _selectedQuest.Tag is Quest quest)
            {
                rtbDetails.Text = $"{quest.InfoText}";
            }
        }
    }
}
