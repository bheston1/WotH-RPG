using Engine.Controller;
using Engine.Model;
using RPG_UI.View;

namespace RPG_UI
{
    public partial class GameWindow : Form
    {
        public GameController Controller { get; private set; }
        private string _playerName;

        public GameWindow(string playerName)
        {
            InitializeComponent();
            Controller = new();
            _playerName = playerName;
            Controller.Player.Name = _playerName;
            UpdateGUI();
            rtbLog.Text = "You arrive at the edge of the Hollow, drawn by a mysterious force. The once-thriving village near the forest is now abandoned, and only the reanimated corpses and cursed spirits of the villagers remain. At the entrance to the forest you see a camp. There are survivors here.";
        }

        private void StartCombat(Monster monster)
        {
            if (Controller.CurrentMonster != null)
            {
                CombatWindow combatWindow = new(Controller.Player, Controller.CurrentMonster, this);
                Enabled = false;
                combatWindow.Show();
            }
        }

        public void UpdateGUI()
        {
            lblLocation.Text = $"{Controller.Player.CurrentLocation.MapArea.Name}";
            lblPlayerName.Text = Controller.Player.Name;
            lblPlayerLevel.Text = $"{Controller.Player.Level}";
            lblPlayerXp.Text = $"{Controller.Player.Experience}/{Controller.Player.XpToLevel}";
            lblPlayerHealth.Text = $"{Controller.Player.Health}/{Controller.Player.MaxHealth}";
            lblPlayerMana.Text = $"{Controller.Player.Mana}/{Controller.Player.MaxMana}";
            lblPlayerEssence.Text = $"{Controller.Player.Essence}";

            UpdateHealthBar();
            ToggleNavButtons();
            ToggleAreaButtons();
            PopulateCbos();
        }

        private void ToggleAreaButtons()
        {
            if (Controller.Player.CurrentLocation.HasNpc == false) btnTalk.Enabled = false;
            else btnTalk.Enabled = true;

            if (Controller.Player.CurrentLocation.RestArea == false) btnCamp.Enabled = false;
            else btnCamp.Enabled = true;
        }

        private void UpdateHealthBar()
        {
            playerHealthBar.Minimum = 0;
            playerHealthBar.Maximum = Controller.Player.MaxHealth;
            playerHealthBar.Value = Controller.Player.Health;
        }

        private void ToggleNavButtons()
        {
            if (Controller.Player.CurrentLocation.North == null) btnNorth.Enabled = false;
            else btnNorth.Enabled = true;

            if (Controller.Player.CurrentLocation.East == null) btnEast.Enabled = false;
            else btnEast.Enabled = true;

            if (Controller.Player.CurrentLocation.South == null) btnSouth.Enabled = false;
            else btnSouth.Enabled = true;

            if (Controller.Player.CurrentLocation.West == null) btnWest.Enabled = false;
            else btnWest.Enabled = true;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            Controller.Player.Move("north");

            if (Controller.Player.HasRequiredItem == false)
            {
                rtbLog.Text = "An unknown force blocks your path.";
            }

            if (Controller.MonsterFound() == true)
            {
                if (Controller.CurrentMonster != null) StartCombat(Controller.CurrentMonster);
            }

            UpdateGUI();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            Controller.Player.Move("east");

            if (Controller.Player.HasRequiredItem == false)
            {
                rtbLog.Text = "An unknown force blocks your path.";
            }

            if (Controller.MonsterFound() == true)
            {
                if (Controller.CurrentMonster != null) StartCombat(Controller.CurrentMonster);
            }

            UpdateGUI();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            Controller.Player.Move("south");

            if (Controller.Player.HasRequiredItem == false)
            {
                rtbLog.Text = "An unknown force blocks your path.";
            }

            if (Controller.MonsterFound() == true)
            {
                if (Controller.CurrentMonster != null) StartCombat(Controller.CurrentMonster);
            }

            UpdateGUI();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            Controller.Player.Move("west");

            if (Controller.Player.HasRequiredItem == false)
            {
                rtbLog.Text = "An unknown force blocks your path.";
            }

            if (Controller.MonsterFound() == true)
            {
                if (Controller.CurrentMonster != null) StartCombat(Controller.CurrentMonster);
            }

            UpdateGUI();
        }

        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWarning saveWarning = new(this);
            Enabled = false;
            saveWarning.Show();
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {

        }

        private void btnCamp_Click(object sender, EventArgs e)
        {
            Controller.Player.Rest();
            rtbLog.Text = "You set up camp and rest for awhile.\nHealth and mana restored. Status cleared.";
            UpdateGUI();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            EquipmentPanel equipmentPanel = new(Controller.Player, this);
            Enabled = false;
            equipmentPanel.Show();
        }

        private void btnCrafting_Click(object sender, EventArgs e)
        {

        }

        private void btnQuests_Click(object sender, EventArgs e)
        {

        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            if (cboSpells.SelectedItem is Spell selected)
            {
                if (Controller.Player.Mana >= selected.ManaCost && selected.UsableOutOfCombat == true)
                {
                    Controller.Player.CastSpell(selected);
                    rtbLog.Text = $"{Controller.Player.Name} casts {selected.Name}.";
                }
                else if (Controller.Player.Mana >= selected.ManaCost && selected.UsableOutOfCombat == false)
                {
                    rtbLog.Text = $"{selected.Name} can only be used during combat.";
                }
                else
                {
                    rtbLog.Text = $"Not enough mana to cast {selected.Name}!";
                }
            }
            UpdateGUI();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (cboItems.SelectedItem != null)
            {
                // grab the selected item group (anonymous object)
                var selectedGroup = cboItems.SelectedItem as dynamic;
                if (selectedGroup != null)
                {
                    // get the first actual consumable object in the inventory matching selected name
                    Consumable? selected = Controller.Player.Inventory
                        .OfType<Consumable>()
                        .FirstOrDefault(item => item.Name == selectedGroup.ItemName);

                    if (selected != null)
                    {
                        selected.Use(Controller.Player);
                        rtbLog.Text = $"{Controller.Player.Name} used {selected.Name}.";
                    }
                }
            }
            else
            {
                rtbLog.Text = "No item!";
            }
            UpdateGUI();
        }

        private void PopulateCbos()
        {
            // populate item cbo with usable combat consumables and group duplicates
            var combatItems = Controller.Player.Inventory
                .OfType<Consumable>()
                .Where(item => item.IsCombatItem == true)
                .GroupBy(item => item.Name)
                .Select(group => new { ItemName = group.Key, Amount = group.Count() })
                .ToList();
            cboItems.DataSource = combatItems;
            cboItems.DisplayMember = "ItemName";
            cboItems.ValueMember = "Amount";
            cboItems.Format += (s, e) =>
            {
                var item = e.ListItem as dynamic;
                if (item != null)
                {
                    e.Value = $"{item.ItemName} (x{item.Amount})";
                }
            };

            // cbo for spells
            cboSpells.DataSource = Controller.Player.Spells;
            cboSpells.DisplayMember = "Name";
            if (cboSpells.SelectedItem is Spell selected)
            {
                lblManaCost.Text = $"{selected.ManaCost} mana";
            }
        }

        private void cboSpells_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSpells.SelectedItem is Spell selected)
            {
                lblManaCost.Text = $"{selected.ManaCost} mana";
            }
        }
    }
}
