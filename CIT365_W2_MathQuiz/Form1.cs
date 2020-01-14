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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            btnPauseQuiz.Visible = true;
            btnStartQuiz.Visible = false;


        }
        private void btnPauseQuiz_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnPauseQuiz.Visible = false;
            btnStartQuiz.Visible = true;

        }

    }
}
