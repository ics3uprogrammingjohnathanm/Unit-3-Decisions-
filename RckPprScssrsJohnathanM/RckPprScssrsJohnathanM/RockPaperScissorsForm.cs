using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RckPprScssrsJohnathanM
{
    public partial class frmRockPaperScissors : Form
    {
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;
        const int MIN_NUM = 1;
        const int MAX_NUM = 3;
        Random RandomNumber = new Random();
        int CPUChoice;
        
        
        

        public frmRockPaperScissors()
        {
            InitializeComponent();

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            btnScissors.Hide();
            btnRock.Hide();
            btnPaper.Hide();
            picRock.Hide();
            picScissors.Hide();
            picPaper.Hide();

            lblCPUChoice.Show();
            lblUSRChoice.Show();
            lblWinLose.Show();

            picUSRScissors.Show();

            if (CPUChoice == ROCK)
            {
                //CPU WINS
                picCPU.Show();
                lblWinLose.Text = "You Lose!";
            }
            else if (CPUChoice == PAPER)
            {
                //CPU LOSES
                picCPUPaper.Show();
                lblWinLose.Text = "You Win!";
            }
            else if (CPUChoice == SCISSORS)
            {
                //CPU TIES
                picCPUScissors.Show();
                lblWinLose.Text = "You Tied!";
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            btnScissors.Hide();
            btnRock.Hide();
            btnPaper.Hide();
            picRock.Hide();
            picScissors.Hide();
            picPaper.Hide();

            lblCPUChoice.Show();
            lblUSRChoice.Show();
            lblWinLose.Show();

            this.picUSRPaper.Show();

            if (CPUChoice == ROCK)
            {
                //CPU LOSES
                picCPU.Show();
                lblWinLose.Text = "You Win!";
            }
            else if (CPUChoice == PAPER)
            {
                //CPU TIES
                picCPUPaper.Show();
                lblWinLose.Text = "You Tied!";
            }
            else if (CPUChoice == SCISSORS)
            {
                //CPU WINS
                picCPUScissors.Show();
                lblWinLose.Text = "You Lose!";
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            btnScissors.Hide();
            btnRock.Hide();
            btnPaper.Hide();
            picRock.Hide();
            picScissors.Hide();
            picPaper.Hide();

            lblCPUChoice.Show();
            lblUSRChoice.Show();
            lblWinLose.Show();

            this.picUSR.Show();

            this.picUSR.Load(@"Images\rock.png");

            if (CPUChoice == ROCK)
            {
                //CPU TIES
                picCPU.Show();
                lblWinLose.Text = "You Tied!";
            }
            else if (CPUChoice == PAPER)
            {
                //CPU WINS
                picCPUPaper.Show();
                lblWinLose.Text = "You Lose!";
            }
            else if (CPUChoice == SCISSORS)
            {
                //CPU LOSES
                picCPUScissors.Show();
                lblWinLose.Text = "You Win!";

            }
        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            CPUChoice = RandomNumber.Next(MIN_NUM, MAX_NUM + 1);
            picCPU.Hide();
            lblCPUChoice.Hide();
            picUSR.Hide();
            lblUSRChoice.Hide();
            lblWinLose.Hide();
            picUSRScissors.Hide();
            picUSRPaper.Hide();
            picCPUPaper.Hide();
            picCPUScissors.Hide();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            btnScissors.Show();
            btnRock.Show();
            btnPaper.Show();
            picRock.Show();
            picScissors.Show();
            picPaper.Show();
        }
    }
}
