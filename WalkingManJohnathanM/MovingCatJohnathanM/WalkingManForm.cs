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
 * Created on: 19/03/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 Walking Man
 * This program cycles through animation frames until it reaches max frames
*/
namespace MovingCatJohnathanM
{
    public partial class frmMovingCat : Form
    {
        // global variables
        int zombieCount = 1;
        int zombieRunCount = 1;
        int zombieCycleCount = 1;
        const int MAX_FRAMES = 10;

        public frmMovingCat()
        {
            InitializeComponent();
        }

            
        private void btnForwards_Click(object sender, EventArgs e)
        {
            
            if (zombieCount == 1)
            {
                zombieCount = 2;

                this.picZombie.Load(@"Images\zombie2.png");

            }
            else if (zombieCount == 2)
            {
                zombieCount = 3;

                this.picZombie.Load(@"Images\zombie3.png");
            }
            else if (zombieCount == 3)
            {
                zombieCount = 4;

                this.picZombie.Load(@"Images\zombie4.png");
            }
            else if (zombieCount == 4)
            {
                zombieCount = 5;

                this.picZombie.Load(@"Images\zombie5.png");
            }
            else if (zombieCount == 5)
            {
                zombieCount = 6;

                this.picZombie.Load(@"Images\zombie6.png");
            }
            else if (zombieCount == 6)
            {
                zombieCount = 7;

                this.picZombie.Load(@"Images\zombie7.png");
            }
            else if (zombieCount == 7)
            {
                zombieCount = 8;

                this.picZombie.Load(@"Images\zombie8.png");
            }
            else if (zombieCount == 8)
            {
                zombieCount = 9;

                this.picZombie.Load(@"Images\zombie9.png");
            }
            else if (zombieCount == 9)
            {
                zombieCount = 10;

                this.picZombie.Load(@"Images\zombie10.png");
            }
            else if (zombieCount == 10)
            {
                zombieCount = 1;

                this.picZombie.Load(@"Images\zombie1.png");
            }
           
        }

        private void picZombie_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMovingCat_Load(object sender, EventArgs e)
        {
            zombieCount = 1;
            zombieCycleCount = 1;
            zombieRunCount = 1;
            this.picZombie.Load(@"Images\zombie1.png");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            while (zombieRunCount < MAX_FRAMES + 1)
            {
                if (zombieRunCount == 1)
                {
                    zombieRunCount = 2;

                    this.picZombie.Load(@"Images\zombie2.png");
                }
                else if (zombieRunCount == 2)
                {
                    zombieRunCount = 3;

                    this.picZombie.Load(@"Images\zombie3.png");
                }
                else if (zombieRunCount == 3)
                {
                    zombieRunCount = 4;

                    this.picZombie.Load(@"Images\zombie4.png");
                }
                else if (zombieRunCount == 4)
                {
                    zombieRunCount = 5;

                    this.picZombie.Load(@"Images\zombie5.png");
                }
                else if (zombieRunCount == 5)
                {
                    zombieRunCount = 6;

                    this.picZombie.Load(@"Images\zombie6.png");
                }
                else if (zombieRunCount == 6)
                {
                    zombieRunCount = 7;

                    this.picZombie.Load(@"Images\zombie7.png");
                }
                else if (zombieRunCount == 7)
                {
                    zombieRunCount = 8;

                    this.picZombie.Load(@"Images\zombie8.png");
                }
                else if (zombieRunCount == 8)
                {
                    zombieRunCount = 9;

                    this.picZombie.Load(@"Images\zombie9.png");
                }
                else if (zombieRunCount == 9)
                {
                    zombieRunCount = 10;

                    this.picZombie.Load(@"Images\zombie10.png");
                }
            }
            
        }

        private void btnRunForever_Click(object sender, EventArgs e)
        {
            while (zombieCycleCount < MAX_FRAMES + 1)
            {
                if (zombieCycleCount == 1)
                {
                    zombieCycleCount = 2;

                    this.picZombie.Load(@"Images\zombie2.png");
                }
                else if (zombieCycleCount == 2)
                {
                    zombieCycleCount = 3;

                    this.picZombie.Load(@"Images\zombie3.png");
                }
                else if (zombieCycleCount == 3)
                {
                    zombieCycleCount = 4;

                    this.picZombie.Load(@"Images\zombie4.png");
                }
                else if (zombieCycleCount == 4)
                {
                    zombieCycleCount = 5;

                    this.picZombie.Load(@"Images\zombie5.png");
                }
                else if (zombieCycleCount == 5)
                {
                    zombieCycleCount = 6;

                    this.picZombie.Load(@"Images\zombie6.png");
                }
                else if (zombieCycleCount == 6)
                {
                    zombieCycleCount = 7;

                    this.picZombie.Load(@"Images\zombie7.png");
                }
                else if (zombieCycleCount == 7)
                {
                    zombieCycleCount = 8;

                    this.picZombie.Load(@"Images\zombie8.png");
                }
                else if (zombieCycleCount == 8)
                {
                    zombieCycleCount = 9;

                    this.picZombie.Load(@"Images\zombie9.png");
                }
                else if (zombieCycleCount == 9)
                {
                    zombieCycleCount = 10;

                    this.picZombie.Load(@"Images\zombie10.png");

                    this.Refresh();
                }
            }
        }
    }
}
