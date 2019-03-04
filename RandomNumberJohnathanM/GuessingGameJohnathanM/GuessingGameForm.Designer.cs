namespace GuessingGameJohnathanM
{
    partial class frmGuessingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessingGame));
            this.picCup1 = new System.Windows.Forms.PictureBox();
            this.picCup2 = new System.Windows.Forms.PictureBox();
            this.picCup3 = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.lblScenario = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picCup1
            // 
            this.picCup1.BackColor = System.Drawing.Color.Transparent;
            this.picCup1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCup1.BackgroundImage")));
            this.picCup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCup1.InitialImage = null;
            this.picCup1.Location = new System.Drawing.Point(37, 102);
            this.picCup1.Name = "picCup1";
            this.picCup1.Size = new System.Drawing.Size(180, 251);
            this.picCup1.TabIndex = 0;
            this.picCup1.TabStop = false;
            this.picCup1.Click += new System.EventHandler(this.picCup1_Click);
            // 
            // picCup2
            // 
            this.picCup2.BackColor = System.Drawing.Color.Transparent;
            this.picCup2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCup2.BackgroundImage")));
            this.picCup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCup2.Location = new System.Drawing.Point(514, 102);
            this.picCup2.Name = "picCup2";
            this.picCup2.Size = new System.Drawing.Size(180, 251);
            this.picCup2.TabIndex = 1;
            this.picCup2.TabStop = false;
            this.picCup2.Click += new System.EventHandler(this.picCup2_Click);
            // 
            // picCup3
            // 
            this.picCup3.BackColor = System.Drawing.Color.Transparent;
            this.picCup3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCup3.BackgroundImage")));
            this.picCup3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCup3.Location = new System.Drawing.Point(278, 102);
            this.picCup3.Name = "picCup3";
            this.picCup3.Size = new System.Drawing.Size(180, 251);
            this.picCup3.TabIndex = 2;
            this.picCup3.TabStop = false;
            this.picCup3.Click += new System.EventHandler(this.picCup3_Click);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBall.BackgroundImage")));
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBall.Location = new System.Drawing.Point(25, 157);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(202, 208);
            this.picBall.TabIndex = 3;
            this.picBall.TabStop = false;
            this.picBall.Click += new System.EventHandler(this.picBall_Click);
            // 
            // lblScenario
            // 
            this.lblScenario.AutoSize = true;
            this.lblScenario.BackColor = System.Drawing.Color.Transparent;
            this.lblScenario.Font = new System.Drawing.Font("Tekton Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScenario.Location = new System.Drawing.Point(27, 23);
            this.lblScenario.Name = "lblScenario";
            this.lblScenario.Size = new System.Drawing.Size(671, 58);
            this.lblScenario.TabIndex = 4;
            this.lblScenario.Text = "Guess which cup the ball is under!";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Font = new System.Drawing.Font("Tekton Pro", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(-1, -2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(765, 425);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Click anywhere\r\nto Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.BackColor = System.Drawing.Color.Black;
            this.lblGuessed.Font = new System.Drawing.Font("Tekton Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.ForeColor = System.Drawing.Color.Red;
            this.lblGuessed.Location = new System.Drawing.Point(79, 186);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(580, 58);
            this.lblGuessed.TabIndex = 6;
            this.lblGuessed.Text = "You Already Guessed Wrong!";
            this.lblGuessed.Visible = false;
            this.lblGuessed.Click += new System.EventHandler(this.lblGuessed_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(258, 369);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(228, 40);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Click to Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 421);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.picCup1);
            this.Controls.Add(this.picCup2);
            this.Controls.Add(this.picCup3);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblScenario);
            this.Controls.Add(this.picBall);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game by Johnathan M";
            this.Load += new System.EventHandler(this.frmGuessingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCup1;
        private System.Windows.Forms.PictureBox picCup2;
        private System.Windows.Forms.PictureBox picCup3;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblScenario;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Button btnRestart;
    }
}

