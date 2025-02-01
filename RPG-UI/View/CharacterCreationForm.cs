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
            rtbIntroText.Text = "Whispers of the Hollow is a dark fantasy text RPG set in a cursed world where you are drawn into an ancient forest known as the Hollow, a place of nightmares and forgotten gods. You must unravel the mysteries of the Hollow while facing both external horrors and internal demons. The game is divided into three acts, each with its own distinct atmosphere, characters, quests and threats.";
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
