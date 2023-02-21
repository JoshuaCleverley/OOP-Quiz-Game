using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_One_Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Create the GameMenu object with a reference to the main menu and show it
            GameMenu gameMenu = new GameMenu(this);
            gameMenu.Show();
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            // Create the InstructionsMenu object with a reference to the main menu and show it
            InstructionsMenu instructionsMenu = new InstructionsMenu(this);
            instructionsMenu.Show();
            Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // Quit the program
            Close();
        }
    }
}
