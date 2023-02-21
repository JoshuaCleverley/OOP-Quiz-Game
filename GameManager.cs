using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_One_Game {
    public class GameManager {

        // Reference to GameMenu object
        private GameMenu gameMenu;
        
        // Labels to update text
        private Label scoreLabel;
        private Label questionLabel;

        // Buttons to update text
        private Button answerOneButton;
        private Button answerTwoButton;
        private Button answerThreeButton;
        private Button answerFourButton;

        // Arrays of questions and answer indexes
        private string[,] questions;
        private int[] answers;

        // Index of current question in array, and List of completed questions
        private int currentQuestion;
        private List<int> completedQuestions;

        // Current score and the score needed to win
        private int score;
        private int winScore = 3;

        public GameManager(GameMenu gameMenu, Label scoreLabel, Label questionLabel, Button answerOneButton, Button answerTwoButton, Button answerThreeButton, Button answerFourButton) {
            // Set GameMenu reference
            this.gameMenu = gameMenu;

            // Set labels and buttons
            this.scoreLabel = scoreLabel;
            this.questionLabel = questionLabel;
            this.answerOneButton = answerOneButton;
            this.answerTwoButton = answerTwoButton;
            this.answerThreeButton = answerThreeButton;
            this.answerFourButton = answerFourButton;

            // Initiate data and get a question to ask the player
            initQuestions();
            nextQuestion();
        }

        private void initQuestions() {
            // Create question array and populate with questions and answers
            questions = new string[6, 5] { 
                { "What is C#?", "An eye test", "A programming language", "A boat", "A tool for designing websites" },
                { "Which of these is not a principle of OOP?", "Abstraction", "Encapsulation", "Simplicity", "Inheritance" },
                { "When was C# created?", "2000", "1989", "2004", "1993" },
                { "Which of these languages do not use OOP?", "Java", "Rust", "C++", "Typescript" },
                { "What were the first computers programmed in?", "C", "Assembly code", "Machine code", "Pascal" },
                { "What was the first 'high level' programming language?", "Fortran", "BASIC", "C", "Assembly language" },
            };

            // Create answer array with the index in the questions array plus one (to account for the question itself)
            answers = new int[6] { 
                2, 
                3, 
                1,
                2,
                3,
                1,
            };

            // Clear completed questions List and score
            completedQuestions = new List<int>();
            score = 0;
        }

        private void endGame(bool didWin)
        {
            // Check if the user won or lost and call the correct method on the game menu
            if (didWin) {
                gameMenu.Win(score);
            }
            else {
                gameMenu.Lose(score);
            }

        }

        private void nextQuestion() {
            // Create a random generator
            Random r = new Random();

            if (completedQuestions.Count == questions.Length / 5) {
                // If the game is complete (all questions have been asked) check if the player won
                if (score >= winScore) endGame(true);
                else endGame(false);
                return;
            }
            else do {
                // If the player hasn't won, generate a new question that hasn't been used before 
                currentQuestion = r.Next(answers.Length);
            } while (completedQuestions.Contains(currentQuestion));

            // Set the current question as completed
            completedQuestions.Add(currentQuestion);

            // Update labels and buttons with information from new question
            questionLabel.Text = questions[currentQuestion, 0];

            answerOneButton.Text = questions[currentQuestion, 1];
            answerTwoButton.Text = questions[currentQuestion, 2];
            answerThreeButton.Text = questions[currentQuestion, 3];
            answerFourButton.Text = questions[currentQuestion, 4];
        }

        public void answer(int answer) {
            // Called from the buttons in the GameMenu class
            // Check if user answered correctly
            if (answers[currentQuestion] == answer) {
                // If they did, increase the score and update the label
                score++;
                scoreLabel.Text = "Score: " + score;
            }
            // No matter what the user answered, create a new question
            nextQuestion();
        }
    }
}
