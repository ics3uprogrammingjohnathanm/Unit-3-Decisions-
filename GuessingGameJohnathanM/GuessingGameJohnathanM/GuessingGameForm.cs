using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameJohnathanM
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
           
        }
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        int ballLocation;
        Random ballLocationGenerator = new Random();
        bool cup1IsHidden = false;
        bool cup2IsHidden = false;
        bool cup3IsHidden = false;
        



        private void picBall_Click(object sender, EventArgs e)
        {

        }

        private void picCup1_Click(object sender, EventArgs e)
        {
            if (ballLocation == 1)
            {
                picBall.Location = new Point(25, 157);
                if (cup3IsHidden == false & cup2IsHidden == false)
                {
                    picCup1.Hide();
                    cup1IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Win!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }

            }
            else if (ballLocation == 2)
            {
                picBall.Location = new Point(267, 157);
                if (cup3IsHidden == false & cup2IsHidden == false)
                {
                    picCup1.Hide();
                    cup1IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Lose!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }

            }
            else if (ballLocation == 3)
            {
                picBall.Location = new Point(505, 157);
                if (cup3IsHidden == false & cup2IsHidden == false)
                {
                    picCup1.Hide();
                    cup1IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Lose!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }
            }
            
           
        }

        private void picCup3_Click(object sender, EventArgs e)
        {
            if (ballLocation == 1)
            {
                picBall.Location = new Point(25, 157);
                if (cup1IsHidden == false & cup2IsHidden == false)
                {
                    picCup3.Hide();
                    cup3IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Lose!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }

            }
            else if (ballLocation == 2)
            {
                picBall.Location = new Point(267, 157);
                if (cup1IsHidden == false & cup2IsHidden == false)
                {
                    picCup3.Hide();
                    cup3IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Win!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }

            }
            else if (ballLocation == 3)
            {
                picBall.Location = new Point(505, 157);
                if (cup1IsHidden == false & cup2IsHidden == false)
                {
                    picCup3.Hide();
                    cup3IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Lose!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }

            }

            
        }

        private void picCup2_Click(object sender, EventArgs e)
        {
            if (ballLocation == 1)
            {
                picBall.Location = new Point(25, 157);
                if (cup1IsHidden == false & cup3IsHidden == false)
                {
                    picCup2.Hide();
                    cup2IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Lose!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }

            }
            else if (ballLocation == 2)
            {
                picBall.Location = new Point(267, 157);
                if (cup1IsHidden == false & cup3IsHidden == false)
                {
                    picCup2.Hide();
                    cup2IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Lose!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }
            }
            else if (ballLocation == 3)
            {
                picBall.Location = new Point(505, 157);
                if (cup1IsHidden == false & cup3IsHidden == false)
                {
                    picCup2.Hide();
                    cup2IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Win!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    lblGuessed.Show();
                    lblGuessed.Text = "You Already Guessed!";
                    lblGuessed.Location = new Point(130, 185);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ballLocation = ballLocationGenerator.Next(MIN_VALUE, MAX_VALUE);
            btnStart.Hide();
        }

        private void lblGuessed_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
