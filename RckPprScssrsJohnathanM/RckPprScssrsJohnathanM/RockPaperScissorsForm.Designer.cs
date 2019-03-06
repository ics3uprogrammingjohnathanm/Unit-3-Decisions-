namespace RckPprScssrsJohnathanM
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblScenario = new System.Windows.Forms.Label();
            this.picUSR = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.lblCPUChoice = new System.Windows.Forms.Label();
            this.lblUSRChoice = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picCPUScissors = new System.Windows.Forms.PictureBox();
            this.picCPUPaper = new System.Windows.Forms.PictureBox();
            this.picUSRScissors = new System.Windows.Forms.PictureBox();
            this.picUSRPaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUSRScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUSRPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Black;
            this.btnRock.Font = new System.Drawing.Font("Tekton Pro", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.ForeColor = System.Drawing.Color.Crimson;
            this.btnRock.Location = new System.Drawing.Point(28, 288);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(177, 48);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Black;
            this.btnPaper.Font = new System.Drawing.Font("Tekton Pro", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.ForeColor = System.Drawing.Color.Crimson;
            this.btnPaper.Location = new System.Drawing.Point(327, 288);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(177, 48);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Black;
            this.btnScissors.Font = new System.Drawing.Font("Tekton Pro", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.ForeColor = System.Drawing.Color.Crimson;
            this.btnScissors.Location = new System.Drawing.Point(659, 288);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(177, 48);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblScenario
            // 
            this.lblScenario.AutoSize = true;
            this.lblScenario.BackColor = System.Drawing.Color.Transparent;
            this.lblScenario.Font = new System.Drawing.Font("Tekton Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScenario.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblScenario.Location = new System.Drawing.Point(180, 98);
            this.lblScenario.Name = "lblScenario";
            this.lblScenario.Size = new System.Drawing.Size(508, 58);
            this.lblScenario.TabIndex = 3;
            this.lblScenario.Text = "Rock, Paper or Scissors?";
            // 
            // picUSR
            // 
            this.picUSR.BackColor = System.Drawing.Color.Transparent;
            this.picUSR.BackgroundImage = global::RckPprScssrsJohnathanM.Properties.Resources.rock;
            this.picUSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUSR.InitialImage = null;
            this.picUSR.Location = new System.Drawing.Point(659, 159);
            this.picUSR.Name = "picUSR";
            this.picUSR.Size = new System.Drawing.Size(177, 151);
            this.picUSR.TabIndex = 5;
            this.picUSR.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.BackColor = System.Drawing.Color.Transparent;
            this.picCPU.BackgroundImage = global::RckPprScssrsJohnathanM.Properties.Resources.rock;
            this.picCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCPU.InitialImage = null;
            this.picCPU.Location = new System.Drawing.Point(12, 159);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(177, 151);
            this.picCPU.TabIndex = 8;
            this.picCPU.TabStop = false;
            // 
            // picRock
            // 
            this.picRock.BackColor = System.Drawing.Color.Transparent;
            this.picRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRock.BackgroundImage")));
            this.picRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRock.Location = new System.Drawing.Point(28, 342);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(177, 151);
            this.picRock.TabIndex = 9;
            this.picRock.TabStop = false;
            // 
            // picScissors
            // 
            this.picScissors.BackColor = System.Drawing.Color.Transparent;
            this.picScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picScissors.BackgroundImage")));
            this.picScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picScissors.Location = new System.Drawing.Point(659, 342);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(177, 151);
            this.picScissors.TabIndex = 10;
            this.picScissors.TabStop = false;
            // 
            // picPaper
            // 
            this.picPaper.BackColor = System.Drawing.Color.Transparent;
            this.picPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPaper.BackgroundImage")));
            this.picPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPaper.Location = new System.Drawing.Point(327, 342);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(177, 151);
            this.picPaper.TabIndex = 11;
            this.picPaper.TabStop = false;
            // 
            // lblCPUChoice
            // 
            this.lblCPUChoice.AutoSize = true;
            this.lblCPUChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUChoice.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUChoice.ForeColor = System.Drawing.Color.White;
            this.lblCPUChoice.Location = new System.Drawing.Point(56, 78);
            this.lblCPUChoice.Name = "lblCPUChoice";
            this.lblCPUChoice.Size = new System.Drawing.Size(118, 58);
            this.lblCPUChoice.TabIndex = 13;
            this.lblCPUChoice.Text = "The CPU\r\nChose:";
            this.lblCPUChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUSRChoice
            // 
            this.lblUSRChoice.AutoSize = true;
            this.lblUSRChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblUSRChoice.Font = new System.Drawing.Font("Tekton Pro Ext", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSRChoice.ForeColor = System.Drawing.Color.White;
            this.lblUSRChoice.Location = new System.Drawing.Point(694, 70);
            this.lblUSRChoice.Name = "lblUSRChoice";
            this.lblUSRChoice.Size = new System.Drawing.Size(117, 72);
            this.lblUSRChoice.TabIndex = 14;
            this.lblUSRChoice.Text = "You\r\nChose:";
            this.lblUSRChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.BackColor = System.Drawing.Color.Transparent;
            this.lblWinLose.Font = new System.Drawing.Font("Tandysoft", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.ForeColor = System.Drawing.Color.Yellow;
            this.lblWinLose.Location = new System.Drawing.Point(270, 311);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(309, 82);
            this.lblWinLose.TabIndex = 15;
            this.lblWinLose.Text = "You Win!";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Tekton Pro", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Lime;
            this.btnRestart.Location = new System.Drawing.Point(327, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(177, 48);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picCPUScissors
            // 
            this.picCPUScissors.BackColor = System.Drawing.Color.Transparent;
            this.picCPUScissors.BackgroundImage = global::RckPprScssrsJohnathanM.Properties.Resources.scissors;
            this.picCPUScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCPUScissors.InitialImage = null;
            this.picCPUScissors.Location = new System.Drawing.Point(12, 159);
            this.picCPUScissors.Name = "picCPUScissors";
            this.picCPUScissors.Size = new System.Drawing.Size(177, 151);
            this.picCPUScissors.TabIndex = 18;
            this.picCPUScissors.TabStop = false;
            // 
            // picCPUPaper
            // 
            this.picCPUPaper.BackColor = System.Drawing.Color.Transparent;
            this.picCPUPaper.BackgroundImage = global::RckPprScssrsJohnathanM.Properties.Resources.paper;
            this.picCPUPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCPUPaper.InitialImage = null;
            this.picCPUPaper.Location = new System.Drawing.Point(12, 159);
            this.picCPUPaper.Name = "picCPUPaper";
            this.picCPUPaper.Size = new System.Drawing.Size(177, 151);
            this.picCPUPaper.TabIndex = 19;
            this.picCPUPaper.TabStop = false;
            // 
            // picUSRScissors
            // 
            this.picUSRScissors.BackColor = System.Drawing.Color.Transparent;
            this.picUSRScissors.BackgroundImage = global::RckPprScssrsJohnathanM.Properties.Resources.scissors;
            this.picUSRScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUSRScissors.InitialImage = null;
            this.picUSRScissors.Location = new System.Drawing.Point(659, 159);
            this.picUSRScissors.Name = "picUSRScissors";
            this.picUSRScissors.Size = new System.Drawing.Size(177, 151);
            this.picUSRScissors.TabIndex = 20;
            this.picUSRScissors.TabStop = false;
            // 
            // picUSRPaper
            // 
            this.picUSRPaper.BackColor = System.Drawing.Color.Transparent;
            this.picUSRPaper.BackgroundImage = global::RckPprScssrsJohnathanM.Properties.Resources.paper;
            this.picUSRPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUSRPaper.InitialImage = null;
            this.picUSRPaper.Location = new System.Drawing.Point(659, 159);
            this.picUSRPaper.Name = "picUSRPaper";
            this.picUSRPaper.Size = new System.Drawing.Size(177, 151);
            this.picUSRPaper.TabIndex = 21;
            this.picUSRPaper.TabStop = false;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 521);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblUSRChoice);
            this.Controls.Add(this.lblCPUChoice);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.lblScenario);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.picUSRScissors);
            this.Controls.Add(this.picUSR);
            this.Controls.Add(this.picCPUPaper);
            this.Controls.Add(this.picCPUScissors);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.picUSRPaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Johnathan";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUSRScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUSRPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblScenario;
        private System.Windows.Forms.PictureBox picUSR;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.Label lblCPUChoice;
        private System.Windows.Forms.Label lblUSRChoice;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picCPUScissors;
        private System.Windows.Forms.PictureBox picCPUPaper;
        private System.Windows.Forms.PictureBox picUSRScissors;
        private System.Windows.Forms.PictureBox picUSRPaper;
    }
}

