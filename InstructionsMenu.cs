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
    public partial class InstructionsMenu : Form
    {
        // Reference to main menu
        private MainMenu mainMenu;

        public InstructionsMenu(MainMenu mainMenu)
        {
            InitializeComponent();

            // Set menu reference to main menu
            this.mainMenu = mainMenu;
        }

        private void InstructionsMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show main menu and hide this menu on close
            mainMenu.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Show main menu and hide this menu when back button is pressed
            mainMenu.Show();
            Hide();
        }
    }
}
