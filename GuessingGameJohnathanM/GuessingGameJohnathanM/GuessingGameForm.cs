using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Johnathan Meloche
 * Created on: 28/02/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Guessing Game
 * This program randomizes a golf balls location under a cup, you need to guess which cup it is under (with a restart button)
*/
namespace GuessingGameJohnathanM
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
           
        }
        // Declaring variables and randomizer
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
                    //displays winning text for guessing correctly
                    picCup1.Hide();
                    cup1IsHidden = true;
                    lblGuessed.Show();
                    lblGuessed.Text = "You Win!";
                    lblGuessed.Location = new Point(220, 80);
                }
                else
                {
                    //chnages you win or you lose text to you already guessed
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
            //calls the randomizer to set a random location for the ball
            ballLocation = ballLocationGenerator.Next(MIN_VALUE, MAX_VALUE+1);
            btnStart.Hide();
        }

        private void lblGuessed_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //restarts application on button click
            Application.Restart();
        }
    }
}
