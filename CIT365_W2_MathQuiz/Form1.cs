using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT365_W2_MathQuiz
{
    public partial class Form1 : Form
    {
        int intQuizTimer = 0;
        Random randomizer = new Random();
        int intMaxTimer = 15;

        //Rather than create 8 separate variables, I decided to store the operands in a 2 dimensional array.
        int[,] operands = new int[4,2];   // For each of 4 questions we will hold left and right operands.

        //A dedicated method for checking answers.
        //If the game is over, then also fill in any missing answers.
        //Method also returns number of correct answers.
        private int UpdateScores(Boolean boolGameOver=false)
        {
            int intCorrect = 0;
            //Check line 1 (addition) - if correct mark green, if wrong and game over, mark red and fix answer.
            if (nud1.Value==operands[0,0]+operands[0,1])
            {
                nud1.BackColor = Color.Green;
                intCorrect++;
            }
            else if (boolGameOver)
            {
                nud1.Value = operands[0, 0] + operands[0, 1];
                nud1.BackColor = Color.Red;
            }
            else
            {
                nud1.BackColor = Color.White;
            }

            //Check line 2 (subtraction) - if correct mark green, if wrong and game over, mark red and fix answer.
            if (nud2.Value == operands[1, 0] - operands[1, 1])
            {
                nud2.BackColor = Color.Green;
                intCorrect++;
            }
            else if (boolGameOver)
            {
                nud2.Value = operands[1, 0] + operands[1, 1];
                nud2.BackColor = Color.Red;
            }
            else
            {
                nud2.BackColor = Color.White;
            }

            //Check line 3 (multiplication) - if correct mark green, if wrong and game over, mark red and fix answer.
            if (nud3.Value == operands[2, 0] * operands[2, 1])
            {
                nud3.BackColor = Color.Green;
                intCorrect++;
            }
            else if (boolGameOver)
            {
                nud3.Value = operands[2, 0] + operands[2, 1];
                nud3.BackColor = Color.Red;
            }
            else
            {
                nud3.BackColor = Color.White;
            }

            //Check line 4 (division) - if correct mark green, if wrong and game over, mark red and fix answer.
            if (nud4.Value == operands[3, 0] / operands[3, 1])
            {
                nud4.BackColor = Color.Green;
                intCorrect++;
            }
            else if (boolGameOver)
            {
                nud4.Value = operands[3, 0] + operands[3, 1];
                nud4.BackColor = Color.Red;
            }
            else
            {
                nud4.BackColor = Color.White;
            }

            return intCorrect;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void BtnStartQuiz_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BtnPauseQuiz.Visible = true;
            BtnStartQuiz.Visible = false;
            timer1.Enabled = true;
            progressBar1.Maximum = intMaxTimer;
            progressBar1.Value = 0;

            //I am loading an array with all the operands to use for each game.
            operands = new int[,] { { randomizer.Next(51), randomizer.Next(51) }, { randomizer.Next(51), randomizer.Next(51) } , { randomizer.Next(51), randomizer.Next(51) } , { randomizer.Next(51), randomizer.Next(51) } };


            // Since I have 4 rows of similarly named controls, I am using a loop to locate and then update each field.
            for (int i=0; i<4; i++)
            {
                //This finds the appropriate label with the naming convention lblOp1L, where 1 is the index, and L or R is the position.
                //Left label
                Label lbl = this.Controls.Find("lblOp" + (i + 1) + "L", true).FirstOrDefault() as Label;
                lbl.Text = String.Format("{0}", operands[i, 0]);
                //Right label
                lbl = this.Controls.Find("lblOp" + (i + 1) + "R", true).FirstOrDefault() as Label;
                lbl.Text = String.Format("{0}", operands[i, 1]);
                //Reset the numeric up down control to zero (in case this wasn't the first game)
                NumericUpDown nud = this.Controls.Find("nud" + (i + 1), true).FirstOrDefault() as NumericUpDown;
                nud.Value = 0;
            }
            intQuizTimer = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            intQuizTimer++;

            double percentComplete = (double)intQuizTimer / (double)intMaxTimer;
            if (percentComplete<.25)
                progressBar1.ForeColor = Color.Green;
            else if (percentComplete < .5)
                progressBar1.ForeColor = Color.Blue;
            else if (percentComplete < .7)
                progressBar1.ForeColor = Color.Yellow;
            else if (percentComplete < .8)
                progressBar1.ForeColor = Color.Red;
            if (intQuizTimer<= intMaxTimer)
            {
                progressBar1.Value = intQuizTimer;
                toolStripStatusLabel1.Text = String.Format("Seconds remaining {0}", +intMaxTimer - intQuizTimer);
                UpdateScores();
            }
            else
            {
                timer1.Enabled = false;
                toolStripStatusLabel1.Text = "Time's up!";
                MessageBox.Show("You ran out of time, please try again!","Time's up!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Visible = false;
                BtnStartQuiz.Visible = true;
                UpdateScores(true);
            }

        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            BtnResume.Visible = false;
            BtnPauseQuiz.Visible = true;
            panel1.Visible = true;
        }

        private void BtnPauseQuiz_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BtnPauseQuiz.Visible = false;
            BtnResume.Visible = true;
            timer1.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            UpdateScores(true);
            timer1.Enabled = false;

        }
    }
}
