namespace THB
{
    partial class THB
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
            System.Windows.Forms.Button LoginBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THB));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LogiLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PassWLabel = new System.Windows.Forms.Label();
            LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            LoginBtn.Location = new System.Drawing.Point(261, 276);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new System.Drawing.Size(75, 23);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 33);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 219);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 37);
            this.textBox2.TabIndex = 1;
            // 
            // LogiLabel
            // 
            this.LogiLabel.AutoSize = true;
            this.LogiLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogiLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.LogiLabel.Location = new System.Drawing.Point(256, 110);
            this.LogiLabel.Name = "LogiLabel";
            this.LogiLabel.Size = new System.Drawing.Size(80, 31);
            this.LogiLabel.TabIndex = 2;
            this.LogiLabel.Text = "Login";
            this.LogiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(261, 305);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EmailLabel.Location = new System.Drawing.Point(138, 181);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 18);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // PassWLabel
            // 
            this.PassWLabel.AutoSize = true;
            this.PassWLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PassWLabel.Location = new System.Drawing.Point(123, 238);
            this.PassWLabel.Name = "PassWLabel";
            this.PassWLabel.Size = new System.Drawing.Size(75, 18);
            this.PassWLabel.TabIndex = 6;
            this.PassWLabel.Text = "Password";
            this.PassWLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // THB
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 537);
            this.Controls.Add(this.PassWLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(LoginBtn);
            this.Controls.Add(this.LogiLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RegisterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "THB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.THB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LogiLabel;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PassWLabel;
    }
}

