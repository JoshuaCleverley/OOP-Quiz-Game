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
    public partial class GameMenu : Form
    {
        // Reference to main menu
        private MainMenu mainMenu;

        // GameManager instance
        private GameManager gameManager;

        public GameMenu(MainMenu mainMenu)
        {
            InitializeComponent();
            
            // Set reference to main menu
            this.mainMenu = mainMenu;

            // Create a new GameManager and pass references to the objects on screen that it will update
            gameManager = new GameManager(this, scoreLabel, questionLabel, answerOne, answerTwo, answerThree, answerFour);
        }

        public void Win(int score)
        {
            // On win, show a win screen and hide this screen
            WinScreen screen = new WinScreen(mainMenu, score);
            screen.Show();
            Hide();
        }

        public void Lose(int score)
        {
            // On lose, show lose screen and hide this screen
            LoseScreen screen = new LoseScreen(mainMenu, score);
            screen.Show();
            Hide();
        }

        private void GameMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // On close, show main menu and hide this screen
            mainMenu.Show();
            Hide();
        }

        private void answerFour_Click(object sender, EventArgs e)
        {
            // Pass the answer choice to the game manager
            gameManager.answer(4);
        }

        private void answerThree_Click(object sender, EventArgs e)
        {
            // Pass the answer choice to the game manager
            gameManager.answer(3);
        }

        private void answerTwo_Click(object sender, EventArgs e)
        {
            // Pass the answer choice to the game manager
            gameManager.answer(2);
        }

        private void answerOne_Click(object sender, EventArgs e)
        {
            // Pass the answer choice to the game manager
            gameManager.answer(1);
        }
    }
}
