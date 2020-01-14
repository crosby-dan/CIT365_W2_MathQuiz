namespace CIT365_W2_MathQuiz
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnPauseQuiz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPlusLeft);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 275);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // lblPlusLeft
            // 
            this.lblPlusLeft.AutoSize = true;
            this.lblPlusLeft.Location = new System.Drawing.Point(46, 71);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(13, 13);
            this.lblPlusLeft.TabIndex = 0;
            this.lblPlusLeft.Text = "?";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Location = new System.Drawing.Point(56, 12);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnStartQuiz.TabIndex = 1;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnPauseQuiz
            // 
            this.btnPauseQuiz.Location = new System.Drawing.Point(56, 56);
            this.btnPauseQuiz.Name = "btnPauseQuiz";
            this.btnPauseQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnPauseQuiz.TabIndex = 2;
            this.btnPauseQuiz.Text = "Pause Quiz";
            this.btnPauseQuiz.UseVisualStyleBackColor = true;
            this.btnPauseQuiz.Visible = false;
            this.btnPauseQuiz.Click += new System.EventHandler(this.btnPauseQuiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.btnPauseQuiz);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CIT365 Math Quiz - Dan Crosby";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnPauseQuiz;
    }
}

