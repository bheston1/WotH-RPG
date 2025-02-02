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
    public partial class CharacterCreationForm : Form
    {
        private Random r = new();
        private string[] randomNames =
        {
            "Olivia",
            "Noah",
            "Amelia",
            "Liam",
            "Emma",
            "Oliver",
            "Sophia",
            "Elijah",
            "Charlotte",
            "Mateo",
            "Isabella",
            "Lucas",
            "Ava",
            "Levi",
            "Mia",
            "Ezra",
            "Ellie",
            "Asher",
            "Luna",
            "Leo"
        };

        public CharacterCreationForm()
        {
            InitializeComponent();
            rtbIntroText.Text = "Whispers of the Hollow is a prototype idea/concept for a dark fantasy RPG. This version is a text-based game, and was originally intended to be broken up into three acts. The purpose of this project was to be a learning experience.";
        }

        private void btnConfirmName_Click(object sender, EventArgs e)
        {
            string name = nameInputBox.Text;
            if (String.IsNullOrEmpty(name))
            {
                int index = r.Next(randomNames.Length);
                name = randomNames[index];
            }
            GameWindow gameWindow = new(name);
            Close();
            gameWindow.Show();
        }
    }
}
