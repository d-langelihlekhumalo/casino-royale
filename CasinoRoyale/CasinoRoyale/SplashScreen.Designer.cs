namespace CasinoRoyale
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cirProgressBar = new CircularProgressBar.CircularProgressBar();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.timerHandleAnimations = new System.Windows.Forms.Timer(this.components);
            this.timerChangeForms = new System.Windows.Forms.Timer(this.components);
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.timerExit = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(99, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(481, 80);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblTitle.Location = new System.Drawing.Point(98, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Casino Royale";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(43, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyrights";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(296, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(99, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 80);
            this.panel2.TabIndex = 4;
            // 
            // cirProgressBar
            // 
            this.cirProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cirProgressBar.AnimationFunction")));
            this.cirProgressBar.AnimationSpeed = 500;
            this.cirProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.cirProgressBar.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cirProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.cirProgressBar.InnerMargin = 2;
            this.cirProgressBar.InnerWidth = -1;
            this.cirProgressBar.Location = new System.Drawing.Point(222, 114);
            this.cirProgressBar.MarqueeAnimationSpeed = 2000;
            this.cirProgressBar.Name = "cirProgressBar";
            this.cirProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.cirProgressBar.OuterMargin = -25;
            this.cirProgressBar.OuterWidth = 26;
            this.cirProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cirProgressBar.ProgressWidth = 26;
            this.cirProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cirProgressBar.Size = new System.Drawing.Size(264, 208);
            this.cirProgressBar.StartAngle = 270;
            this.cirProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cirProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cirProgressBar.SubscriptText = "";
            this.cirProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cirProgressBar.SuperscriptText = "";
            this.cirProgressBar.TabIndex = 5;
            this.cirProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cirProgressBar.Value = 68;
            // 
            // picBoxExit
            // 
            this.picBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExit.Image")));
            this.picBoxExit.Location = new System.Drawing.Point(672, 12);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(52, 50);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxExit.TabIndex = 6;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            // 
            // timerHandleAnimations
            // 
            this.timerHandleAnimations.Interval = 500;
            this.timerHandleAnimations.Tick += new System.EventHandler(this.timerHandleAnimations_Tick);
            // 
            // timerChangeForms
            // 
            this.timerChangeForms.Interval = 500;
            this.timerChangeForms.Tick += new System.EventHandler(this.timerChangeForms_Tick);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Interval = 500;
            this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
            // 
            // timerExit
            // 
            this.timerExit.Interval = 500;
            this.timerExit.Tick += new System.EventHandler(this.timerExit_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(736, 437);
            this.Controls.Add(this.picBoxExit);
            this.Controls.Add(this.cirProgressBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitle);
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private CircularProgressBar.CircularProgressBar cirProgressBar;
        private System.Windows.Forms.PictureBox picBoxExit;
        private System.Windows.Forms.Timer timerHandleAnimations;
        private System.Windows.Forms.Timer timerChangeForms;
        private System.Windows.Forms.Timer timerFadeOut;
        private System.Windows.Forms.Timer timerExit;
    }
}

