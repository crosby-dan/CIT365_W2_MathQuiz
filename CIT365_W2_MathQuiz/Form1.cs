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
        int QuizTimer = 0;
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

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            QuizTimer++;
            switch (QuizTimer)
            {
                case 1:
                    progressBar1.ForeColor = Color.Green;
                    break;
                case 5:
                    progressBar1.ForeColor = Color.Blue;
                    break;
                case 10:
                    progressBar1.ForeColor = Color.Yellow;
                    break;
                case 13:
                    progressBar1.ForeColor = Color.Red;
                    break;
            }
            if (QuizTimer<=15)
            {
                progressBar1.Value = QuizTimer;
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

        }
    }
}
