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
    public partial class EquipmentPanel : Form
    {
        private Player _player;
        private Form _parentWindow;

        public EquipmentPanel(Player player, Form parentWindow)
        {
            InitializeComponent();
            _player = player;
            _parentWindow = parentWindow;
            UpdateLabels();
            PopulateCbos();
        }

        private void PopulateCbos()
        {
            var headArmor = _player.Inventory
                .OfType<Armor>()
                .Where(armor => armor.Slot == "Head")
                .ToList();
            cboHead.DataSource = headArmor;
            cboHead.DisplayMember = "Name";
            cboHead.Format += (s, e) =>
            {
                if (e.ListItem is Armor armor)
                {
                    if (armor.ArmorEffect != null)
                    {
                        e.Value = $"[{armor.Name}] [+{armor.DefenseBonus} defense] [{armor.ArmorEffect}]";
                    }
                    else
                    {
                        e.Value = $"[{armor.Name}] [+{armor.DefenseBonus} defense]";
                    }
                }
            };

            var bodyArmor = _player.Inventory
                .OfType<Armor>()
                .Where(armor => armor.Slot == "Body")
                .ToList();
            cboBody.DataSource = bodyArmor;
            cboBody.DisplayMember = "Name";
            cboBody.Format += (s, e) =>
            {
                if (e.ListItem is Armor armor)
                {
                    if (armor.ArmorEffect != null)
                    {
                        e.Value = $"[{armor.Name}] [+{armor.DefenseBonus} defense] [{armor.ArmorEffect}]";
                    }
                    else
                    {
                        e.Value = $"[{armor.Name}] [+{armor.DefenseBonus} defense]";
                    }
                }
            };

            var weaponInventory = _player.Inventory
                .OfType<Weapon>()
                .ToList();
            cboWeapon.DataSource = weaponInventory;
            cboWeapon.DisplayMember = "Name";
            cboWeapon.Format += (s, e) =>
            {
                if (e.ListItem is Weapon weapon)
                {
                    if (weapon.WeaponEffect != null)
                    {
                        e.Value = $"[{weapon.Name}] [+{weapon.MinDamage}-{weapon.MaxDamage} damage] [{weapon.WeaponEffect}]";
                    }
                    else
                    {
                        e.Value = $"[{weapon.Name}] [+{weapon.MinDamage}-{weapon.MaxDamage} damage]";
                    }
                }
            };

            var offHandInventory = _player.Inventory
                .OfType<Armor>()
                .Where(armor => armor.Slot == "Offhand")
                .ToList();
            cboOffHand.DataSource = offHandInventory;
            cboOffHand.DisplayMember = "Name";
            cboBody.Format += (s, e) =>
            {
                if (e.ListItem is Armor armor)
                {
                    if (armor.ArmorEffect != null)
                    {
                        e.Value = $"[{armor.Name}] [+{armor.DefenseBonus} defense] [{armor.ArmorEffect}]";
                    }
                    else
                    {
                        e.Value = $"[{armor.Name}] [+{armor.DefenseBonus} defense]";
                    }
                }
            };

            var neckInventory = _player.Inventory
                .OfType<Jewelry>()
                .Where(jewelry => jewelry.Slot == "Neck")
                .ToList();
            cboNeck.DataSource = neckInventory;
            cboNeck.DisplayMember = "Name";
            cboNeck.Format += (s, e) =>
            {
                if (e.ListItem is Jewelry jewelry)
                {
                    e.Value = $"[{jewelry.Name} [{jewelry.Effect}]";
                }
            };

            var ringInventory = _player.Inventory
                .OfType<Jewelry>()
                .Where(jewelry => jewelry.Slot == "Ring")
                .ToList();
            cboRing.DataSource = ringInventory;
            cboRing.DisplayMember = "Name";
            cboNeck.Format += (s, e) =>
            {
                if (e.ListItem is Jewelry jewelry)
                {
                    e.Value = $"[{jewelry.Name} [{jewelry.Effect}]";
                }
            };
        }

        private void UpdateLabels()
        {
            // head
            if (_player.HeadSlot != null)
            {
                lblHeadName.Text = $"[{_player.HeadSlot.Name}]";
                lblHeadDefense.Text = $"[+{_player.HeadSlot.DefenseBonus} defense]";
                if (_player.HeadSlot.ArmorEffect != null) lblHeadEffect.Text = $"[{_player.HeadSlot.ArmorEffect}]";
                else lblHeadEffect.Text = string.Empty;
            }
            else
            {
                lblHeadName.Text = "Nothing in slot";
                lblHeadDefense.Text = string.Empty;
                lblHeadEffect.Text = string.Empty;
            }

            // body
            if (_player.BodySlot != null)
            {
                lblBodyName.Text = $"[{_player.BodySlot.Name}]";
                lblBodyDefense.Text = $"[+{_player.BodySlot.DefenseBonus} defense]";
                if (_player.BodySlot.ArmorEffect != null) lblBodyEffect.Text = $"[{_player.BodySlot.ArmorEffect}]";
                else lblBodyEffect.Text = string.Empty;
            }
            else
            {
                lblBodyName.Text = "Nothing in slot";
                lblBodyDefense.Text = string.Empty;
                lblBodyEffect.Text = string.Empty;
            }

            // weapon
            if (_player.CurrentWeapon != null)
            {
                lblWeaponName.Text = $"[{_player.CurrentWeapon.Name}]";
                lblWeaponDamage.Text = $"[+{_player.CurrentWeapon.MinDamage}-{_player.CurrentWeapon.MaxDamage} damage]";
                if (_player.CurrentWeapon.WeaponEffect != null) lblWeaponEffect.Text = $"[{_player.CurrentWeapon.WeaponEffect}]";
                else lblWeaponEffect.Text = string.Empty;
            }
            else
            {
                lblWeaponName.Text = "[Fists]";
                lblWeaponDamage.Text = $"[{_player.MinDamage}-{_player.MaxDamage} damage]";
                lblWeaponEffect.Text = string.Empty;
            }

            // offhand
            if (_player.OffHand != null)
            {
                lblOffHandName.Text = $"[{_player.OffHand.Name}]";
                lblOffHandDefense.Text = $"[+{_player.OffHand.DefenseBonus} defense]";
                if (_player.OffHand.ArmorEffect != null) lblOffHandEffect.Text = $"[{_player.OffHand.ArmorEffect}]";
                else lblOffHandEffect.Text = string.Empty;
            }
            else
            {
                lblOffHandName.Text = "Nothing in slot";
                lblOffHandDefense.Text = string.Empty;
                lblOffHandEffect.Text = string.Empty;
            }

            // neck
            if (_player.NeckSlot != null)
            {
                lblNeckName.Text = $"[{_player.NeckSlot.Name}]";
                lblNeckEffect.Text = $"[{_player.NeckSlot.Effect}]";
            }
            else
            {
                lblNeckName.Text = "Nothing in slot";
                lblNeckEffect.Text = string.Empty;
            }

            // ring
            if (_player.RingSlot != null)
            {
                lblRingName.Text = $"[{_player.RingSlot.Name}]";
                lblRingEffect.Text = $"[{_player.RingSlot.Effect}]";
            }
            else
            {
                lblRingName.Text = "Nothing in slot";
                lblRingEffect.Text = string.Empty;
            }

            // stat panel
            lblHealth.Text = $"{_player.MaxHealth}";
            lblMana.Text = $"{_player.MaxMana}";
            lblDmg.Text = $"{GetDamageForDisplay()}";
            lblSpellAdj.Text = $"{GetSpellAdjustForDisplay()}%";
            lblCrit.Text = $"{_player.GetCritChance()}%";
            lblDef.Text = $"{_player.GetDefense()}";
            lblMagRes.Text = $"{_player.GetMagicResist()}%";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            _parentWindow.Enabled = true;
            _parentWindow.BringToFront();
        }

        private void btnEquipOffHand_Click(object sender, EventArgs e)
        {
            if (cboOffHand.SelectedItem is Armor selected) _player.Equip(selected);
            UpdateLabels();
        }

        private void btnRemoveOffHand_Click(object sender, EventArgs e)
        {
            if (_player.OffHand != null) _player.Unequip(_player.OffHand);
            UpdateLabels();
        }

        private void btnEquipWeapon_Click(object sender, EventArgs e)
        {
            if (cboWeapon.SelectedItem is Weapon selected) _player.Equip(selected);
            UpdateLabels();
        }

        private void btnRemoveWeapon_Click(object sender, EventArgs e)
        {
            if (_player.CurrentWeapon != null) _player.Unequip(_player.CurrentWeapon);
            UpdateLabels();
        }

        private void btnEquipHead_Click(object sender, EventArgs e)
        {
            if (cboHead.SelectedItem is Armor selected) _player.Equip(selected);
            UpdateLabels();
        }

        private void btnRemoveHead_Click(object sender, EventArgs e)
        {
            if (_player.HeadSlot != null) _player.Unequip(_player.HeadSlot);
            UpdateLabels() ;
        }

        private void btnEquipBody_Click(object sender, EventArgs e)
        {
            if (cboBody.SelectedItem is Armor selected) _player.Equip(selected);
            UpdateLabels();
        }

        private void btnRemoveBody_Click(object sender, EventArgs e)
        {
            if (_player.BodySlot != null) _player.Unequip(_player.BodySlot);
            UpdateLabels();
        }

        private void btnEquipNeck_Click(object sender, EventArgs e)
        {
            if (cboNeck.SelectedItem is Jewelry selected) _player.Equip(selected);
            UpdateLabels();
        }

        private void btnRemoveNeck_Click(object sender, EventArgs e)
        {
            if (_player.NeckSlot != null) _player.Unequip(_player.NeckSlot);
            UpdateLabels();
        }

        private void btnEquipRing_Click(object sender, EventArgs e)
        {
            if (cboNeck.SelectedItem is Jewelry selected) _player.Equip(selected);
            UpdateLabels();
        }

        private void btnRemoveRing_Click(object sender, EventArgs e)
        {
            if (_player.RingSlot != null) _player.Unequip(_player.RingSlot);
            UpdateLabels();
        }

        private string GetDamageForDisplay()
        {
            if (_player.CurrentWeapon != null)
            {
                int min = _player.MinDamage + _player.CurrentWeapon.MinDamage;
                int max = _player.MaxDamage + _player.CurrentWeapon.MaxDamage;
                return $"{min}-{max}";
            }
            else
            {
                return $"{_player.MinDamage}-{_player.MaxDamage}";
            }
        }

        private int GetSpellAdjustForDisplay()
        {
            int spellAdj = (int)(_player.GetSpellAdjust() * 100);
            return spellAdj;
        }
    }
}
