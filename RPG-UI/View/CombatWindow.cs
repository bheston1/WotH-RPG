using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.Model;

namespace RPG_UI.View
{
    public partial class CombatWindow : Form
    {
        private Player _player;
        private Monster _monster;
        private GameWindow _gameWindow;

        public CombatWindow(Player player, Monster monster, GameWindow gameWindow)
        {
            InitializeComponent();
            _player = player;
            _monster = monster;
            _gameWindow = gameWindow;
            btnClose.Enabled = false;
            UpdateGUI();
        }

        private void PopulateCbos()
        {
            // populate item cbo with usable combat consumables and group duplicates
            var combatItems = _player.Inventory
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
            cboSpells.DataSource = _player.Spells;
            cboSpells.DisplayMember = "Name";
            if (cboSpells.SelectedItem is Spell selected)
            {
                lblManaCost.Text = $"{selected.ManaCost} mana";
            }
        }


        private void UpdateGUI()
        {
            lblPlayerNameCombat.Text = _player.Name;
            lblPlayerHealthCombat.Text = $"{_player.Health}/{_player.MaxHealth}";
            lblPlayerManaCombat.Text = $"MP: {_player.Mana}/{_player.MaxMana}";

            playerHealthBarCombat.Minimum = 0;
            playerHealthBarCombat.Maximum = _player.MaxHealth;
            playerHealthBarCombat.Value = _player.Health;

            lblMonsterName.Text = _monster.Name;
            lblMonsterHealth.Text = $"{_monster.Health}/{_monster.MaxHealth}";
            lblMonsterMana.Text = $"MP: {_monster.Mana}/{_monster.MaxMana}";

            monsterHealthBar.Minimum = 0;
            monsterHealthBar.Maximum = _monster.MaxHealth;
            monsterHealthBar.Value = _monster.Health;
            PopulateCbos();
        }

        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWarning saveWarning = new(this);
            Enabled = false;
            saveWarning.Show();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int damage = _monster.Hurt(_player.Attack(_monster), 0);
            Message($"{_player.Name} attacks {_monster.Name} for {damage} damage!\n");
            if (!MonsterAlive())
            {
                EndCombat();
            }
            else
            {
                DecideMonsterAction();
            }
            if (!PlayerAlive())
            {
                DeathForm deathForm = new();
                deathForm.Show();
                _gameWindow.Close();
                Close();
            }
            UpdateGUI();
        }

        private void btnSpellCombat_Click(object sender, EventArgs e)
        {
            if (cboSpells.SelectedItem is Spell selected)
            {
                if (_player.Mana >= selected.ManaCost && selected.IsHealingSpell == false)
                {
                    int damage = _monster.Hurt(0, _player.CastSpell(selected, _monster));
                    Message($"{_player.Name} casts {selected.Name} for {damage} damage!\n");
                    if (!MonsterAlive())
                    {
                        EndCombat();
                    }
                    else
                    {
                        DecideMonsterAction();
                    }
                }
                else if (_player.Mana >= selected.ManaCost && selected.IsHealingSpell == true)
                {
                    _player.CastSpell(selected);
                    Message($"{_player.Name} casts {selected.Name}!\n");
                    DecideMonsterAction();
                }
                else
                {
                    Message($"Not enough mana to cast {selected.Name}!\n\n");
                }
            }
            if (!PlayerAlive())
            {
                DeathForm deathForm = new();
                deathForm.Show();
                Close();
            }
            UpdateGUI();
        }

        private void btnItemsCombat_Click(object sender, EventArgs e)
        {
            if (cboItems.SelectedItem != null)
            {
                // grab the selected item group (anonymous object)
                var selectedGroup = cboItems.SelectedItem as dynamic;
                if (selectedGroup != null)
                {
                    // get the first actual consumable object in the inventory matching selected name
                    Consumable? selected = _player.Inventory
                        .OfType<Consumable>()
                        .FirstOrDefault(item => item.Name == selectedGroup.ItemName);

                    if (selected != null)
                    {
                        selected.Use(_player);
                        Message($"{_player.Name} used {selected.Name}.\n");
                        DecideMonsterAction();
                    }
                }
            }
            else
            {
                Message("No item!\n\n");
            }
            UpdateGUI();
        }

        private void btnFleeCombat_Click(object sender, EventArgs e)
        {
            if (_monster.ChanceToEscape == 100)
            {
                Close();
                _gameWindow.Enabled = true;
                _gameWindow.BringToFront();
                _gameWindow.UpdateGUI();
            }
            else if (_monster.ChanceToEscape <= Helpers.GetNumberBetween(1, 100))
            {
                Close();
                _gameWindow.Enabled = true;
                _gameWindow.BringToFront();
                _gameWindow.UpdateGUI();
            }
            else
            {
                Message("Couldn't escape!\n");
                DecideMonsterAction();
                if (!PlayerAlive())
                {
                    DeathForm deathForm = new();
                    deathForm.Show();
                    Close();
                }
            }
            UpdateGUI();
        }

        private void DecideMonsterAction()
        {
            Random r = new();
            if (_monster.IsSpellCaster == true && Helpers.GetNumberBetween(1, 100) <= 50)
            {
                int index = r.Next(_monster.Spells.Count);
                if (_monster.Mana >= _monster.Spells[index].ManaCost)
                {
                    int damage = _player.Hurt(0, _monster.CastSpell(_monster.Spells[index], _player));
                    Message($"{_monster.Name} casts {_monster.Spells[index]}, dealing {damage} damage to {_player.Name}!\n\n");
                }
                else
                {
                    int damage = _player.Hurt(_monster.Attack(_player), 0);
                    Message($"{_monster.Name} attacks {_player.Name} for {damage} damage!\n\n");
                }
            }
            else
            {
                int damage = _player.Hurt(_monster.Attack(_player), 0);
                Message($"{_monster.Name} attacks {_player.Name} for {damage} damage!\n\n");
            }
        }

        private bool PlayerAlive()
        {
            if (_player.Health > 0) return true;
            else return false;
        }

        private bool MonsterAlive()
        {
            if (_monster.Health > 0) return true;
            else return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _gameWindow.Enabled = true;
            _gameWindow.UpdateGUI();
            Close();
        }

        private void EndCombat()
        {
            btnClose.Enabled = true;
            btnAttack.Enabled = false;
            btnFleeCombat.Enabled = false;
            btnSpellCombat.Enabled = false;
            cboSpells.Enabled = false;
            btnItemsCombat.Enabled = false;
            cboItems.Enabled = false;
            Message($"{_monster.Name} slain.\nGained {_monster.RewardXp} XP and {_monster.RewardEssence} essence.");
            _player.AddXP(_monster.RewardXp);
            _player.Essence += _monster.RewardEssence;
        }

        private void Message(string message)
        {
            rtbCombatLog.AppendText(message);
            rtbCombatLog.ScrollToCaret();
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
