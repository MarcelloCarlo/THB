namespace THB
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.SplashLabel = new System.Windows.Forms.Label();
            this.THBProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashLabel.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.SplashLabel.Location = new System.Drawing.Point(50, 38);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(333, 60);
            this.SplashLabel.TabIndex = 1;
            this.SplashLabel.Text = "The Home Beauté";
            // 
            // THBProgressBar1
            // 
            this.THBProgressBar1.Location = new System.Drawing.Point(99, 184);
            this.THBProgressBar1.MarqueeAnimationSpeed = 500;
            this.THBProgressBar1.Name = "THBProgressBar1";
            this.THBProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.THBProgressBar1.Size = new System.Drawing.Size(238, 23);
            this.THBProgressBar1.Style = MetroFramework.MetroColorStyle.Pink;
            this.THBProgressBar1.TabIndex = 2;
            // 
            // Splash
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 240);
            this.ControlBox = false;
            this.Controls.Add(this.THBProgressBar1);
            this.Controls.Add(this.SplashLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           // this.Load += new System.EventHandler(this.Splash_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashLabel;
        private MetroFramework.Controls.MetroProgressBar THBProgressBar1;
    }
}

