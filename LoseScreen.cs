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
    public partial class LoseScreen : Form
    {
        // Reference to main menu
        private MainMenu menu;

        public LoseScreen(MainMenu menu, int score)
        {
            InitializeComponent();

            // Set the main menu reference and update score text
            this.menu = menu;
            scoreLabel.Text = "Score: " + score;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Show main menu and hide this menu
            menu.Show();
            Hide();
        }
    }
}
