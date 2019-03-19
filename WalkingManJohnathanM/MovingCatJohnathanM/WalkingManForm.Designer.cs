namespace MovingCatJohnathanM
{
    partial class frmMovingCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovingCat));
            this.picZombie = new System.Windows.Forms.PictureBox();
            this.btnForwards = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRunForever = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picZombie)).BeginInit();
            this.SuspendLayout();
            // 
            // picZombie
            // 
            this.picZombie.BackColor = System.Drawing.Color.Transparent;
            this.picZombie.Image = global::MovingCatJohnathanM.Properties.Resources.zombie1;
            this.picZombie.InitialImage = null;
            this.picZombie.Location = new System.Drawing.Point(64, 31);
            this.picZombie.Name = "picZombie";
            this.picZombie.Size = new System.Drawing.Size(192, 193);
            this.picZombie.TabIndex = 0;
            this.picZombie.TabStop = false;
            this.picZombie.Click += new System.EventHandler(this.picZombie_Click);
            // 
            // btnForwards
            // 
            this.btnForwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForwards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForwards.Font = new System.Drawing.Font("Tekton Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwards.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForwards.Location = new System.Drawing.Point(278, 43);
            this.btnForwards.Name = "btnForwards";
            this.btnForwards.Size = new System.Drawing.Size(158, 33);
            this.btnForwards.TabIndex = 2;
            this.btnForwards.Text = "Slow Motion Run";
            this.btnForwards.UseVisualStyleBackColor = false;
            this.btnForwards.Click += new System.EventHandler(this.btnForwards_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Font = new System.Drawing.Font("Tekton Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRun.Location = new System.Drawing.Point(278, 116);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(158, 33);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run Once";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRunForever
            // 
            this.btnRunForever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRunForever.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunForever.Font = new System.Drawing.Font("Tekton Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunForever.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRunForever.Location = new System.Drawing.Point(278, 191);
            this.btnRunForever.Name = "btnRunForever";
            this.btnRunForever.Size = new System.Drawing.Size(158, 33);
            this.btnRunForever.TabIndex = 4;
            this.btnRunForever.Text = "Run Forever";
            this.btnRunForever.UseVisualStyleBackColor = false;
            this.btnRunForever.Click += new System.EventHandler(this.btnRunForever_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 264);
            this.Controls.Add(this.btnRunForever);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnForwards);
            this.Controls.Add(this.picZombie);
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat by Johnathan M";
            this.Load += new System.EventHandler(this.frmMovingCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picZombie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picZombie;
        public System.Windows.Forms.Button btnForwards;
        public System.Windows.Forms.Button btnRun;
        public System.Windows.Forms.Button btnRunForever;
    }
}

