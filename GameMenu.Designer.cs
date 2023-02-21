namespace Assignment_One_Game
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.answerOne = new System.Windows.Forms.Button();
            this.answerTwo = new System.Windows.Forms.Button();
            this.answerThree = new System.Windows.Forms.Button();
            this.answerFour = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerOne
            // 
            this.answerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerOne.Location = new System.Drawing.Point(144, 153);
            this.answerOne.Name = "answerOne";
            this.answerOne.Size = new System.Drawing.Size(385, 248);
            this.answerOne.TabIndex = 0;
            this.answerOne.Text = "button1";
            this.answerOne.UseVisualStyleBackColor = true;
            this.answerOne.Click += new System.EventHandler(this.answerOne_Click);
            // 
            // answerTwo
            // 
            this.answerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTwo.Location = new System.Drawing.Point(535, 153);
            this.answerTwo.Name = "answerTwo";
            this.answerTwo.Size = new System.Drawing.Size(385, 248);
            this.answerTwo.TabIndex = 1;
            this.answerTwo.Text = "button2";
            this.answerTwo.UseVisualStyleBackColor = true;
            this.answerTwo.Click += new System.EventHandler(this.answerTwo_Click);
            // 
            // answerThree
            // 
            this.answerThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerThree.Location = new System.Drawing.Point(144, 407);
            this.answerThree.Name = "answerThree";
            this.answerThree.Size = new System.Drawing.Size(385, 248);
            this.answerThree.TabIndex = 2;
            this.answerThree.Text = "button3";
            this.answerThree.UseVisualStyleBackColor = true;
            this.answerThree.Click += new System.EventHandler(this.answerThree_Click);
            // 
            // answerFour
            // 
            this.answerFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerFour.Location = new System.Drawing.Point(535, 407);
            this.answerFour.Name = "answerFour";
            this.answerFour.Size = new System.Drawing.Size(385, 248);
            this.answerFour.TabIndex = 3;
            this.answerFour.Text = "button4";
            this.answerFour.UseVisualStyleBackColor = true;
            this.answerFour.Click += new System.EventHandler(this.answerFour_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.questionLabel.Location = new System.Drawing.Point(2, 29);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(1057, 121);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "Question Goes Here";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(68, 20);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score: 0";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerFour);
            this.Controls.Add(this.answerThree);
            this.Controls.Add(this.answerTwo);
            this.Controls.Add(this.answerOne);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerOne;
        private System.Windows.Forms.Button answerTwo;
        private System.Windows.Forms.Button answerThree;
        private System.Windows.Forms.Button answerFour;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}