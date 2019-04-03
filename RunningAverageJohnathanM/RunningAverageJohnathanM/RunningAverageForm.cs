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
 * Created on: 03/04/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This Program Adds input and calculates the average
*/

namespace RunningAverageJohnathanM
{
    public partial class RunningAverageForm : Form
    {
        public RunningAverageForm()
        {
            InitializeComponent();
        }

        private void RunningAverageForm_Load(object sender, EventArgs e)
        {

        }
        Double NumberSet = 0;
        Double NumberCounter = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NumberCounter++;
            NumberSet = NumberSet + Convert.ToDouble(txtInput.Text);
            lblAnswer.Text = Convert.ToString(NumberSet / NumberCounter);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
