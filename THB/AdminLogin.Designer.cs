namespace THB
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.AdminInputTabs = new MetroFramework.Controls.MetroTabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LoginAdminLabel = new MetroFramework.Controls.MetroLabel();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.PassLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordtxtBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernametxtBox = new MetroFramework.Controls.MetroTextBox();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.RegAdminLabel = new MetroFramework.Controls.MetroLabel();
            this.RegAdminNametxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AdminRegbtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.RegAdminPasstxtBox = new MetroFramework.Controls.MetroTextBox();
            this.RegAdminUsrtxtBox = new MetroFramework.Controls.MetroTextBox();
            this.AdminInputTabs.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.RegisterTab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminInputTabs
            // 
            this.AdminInputTabs.Controls.Add(this.LoginTab);
            this.AdminInputTabs.Controls.Add(this.RegisterTab);
            this.AdminInputTabs.Location = new System.Drawing.Point(23, 50);
            this.AdminInputTabs.Name = "AdminInputTabs";
            this.AdminInputTabs.SelectedIndex = 0;
            this.AdminInputTabs.Size = new System.Drawing.Size(291, 241);
            this.AdminInputTabs.TabIndex = 0;
            this.AdminInputTabs.UseSelectable = true;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.metroPanel1);
            this.LoginTab.Location = new System.Drawing.Point(4, 38);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(283, 199);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LoginAdminLabel);
            this.metroPanel1.Controls.Add(this.LoginButton);
            this.metroPanel1.Controls.Add(this.PassLabel);
            this.metroPanel1.Controls.Add(this.UsernameLabel);
            this.metroPanel1.Controls.Add(this.PasswordtxtBox);
            this.metroPanel1.Controls.Add(this.UsernametxtBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(277, 193);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginAdminLabel
            // 
            this.LoginAdminLabel.AutoSize = true;
            this.LoginAdminLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LoginAdminLabel.Location = new System.Drawing.Point(3, 10);
            this.LoginAdminLabel.Name = "LoginAdminLabel";
            this.LoginAdminLabel.Size = new System.Drawing.Size(109, 25);
            this.LoginAdminLabel.TabIndex = 11;
            this.LoginAdminLabel.Text = "Login Admin";
            // 
            // LoginButton
            // 
            this.LoginButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LoginButton.Location = new System.Drawing.Point(115, 127);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(20, 89);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(63, 19);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(15, 55);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 19);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordtxtBox
            // 
            // 
            // 
            // 
            this.PasswordtxtBox.CustomButton.Image = null;
            this.PasswordtxtBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.PasswordtxtBox.CustomButton.Name = "";
            this.PasswordtxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordtxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordtxtBox.CustomButton.TabIndex = 1;
            this.PasswordtxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordtxtBox.CustomButton.UseSelectable = true;
            this.PasswordtxtBox.CustomButton.Visible = false;
            this.PasswordtxtBox.Lines = new string[0];
            this.PasswordtxtBox.Location = new System.Drawing.Point(89, 89);
            this.PasswordtxtBox.MaxLength = 32767;
            this.PasswordtxtBox.Name = "PasswordtxtBox";
            this.PasswordtxtBox.PasswordChar = '*';
            this.PasswordtxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordtxtBox.SelectedText = "";
            this.PasswordtxtBox.SelectionLength = 0;
            this.PasswordtxtBox.SelectionStart = 0;
            this.PasswordtxtBox.ShortcutsEnabled = true;
            this.PasswordtxtBox.Size = new System.Drawing.Size(137, 23);
            this.PasswordtxtBox.TabIndex = 7;
            this.PasswordtxtBox.UseSelectable = true;
            this.PasswordtxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordtxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UsernametxtBox
            // 
            // 
            // 
            // 
            this.UsernametxtBox.CustomButton.Image = null;
            this.UsernametxtBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.UsernametxtBox.CustomButton.Name = "";
            this.UsernametxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernametxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernametxtBox.CustomButton.TabIndex = 1;
            this.UsernametxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernametxtBox.CustomButton.UseSelectable = true;
            this.UsernametxtBox.CustomButton.Visible = false;
            this.UsernametxtBox.Lines = new string[0];
            this.UsernametxtBox.Location = new System.Drawing.Point(89, 55);
            this.UsernametxtBox.MaxLength = 32767;
            this.UsernametxtBox.Name = "UsernametxtBox";
            this.UsernametxtBox.PasswordChar = '\0';
            this.UsernametxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernametxtBox.SelectedText = "";
            this.UsernametxtBox.SelectionLength = 0;
            this.UsernametxtBox.SelectionStart = 0;
            this.UsernametxtBox.ShortcutsEnabled = true;
            this.UsernametxtBox.Size = new System.Drawing.Size(137, 23);
            this.UsernametxtBox.TabIndex = 6;
            this.UsernametxtBox.UseSelectable = true;
            this.UsernametxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernametxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegisterTab
            // 
            this.RegisterTab.Controls.Add(this.metroPanel2);
            this.RegisterTab.Location = new System.Drawing.Point(4, 38);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Size = new System.Drawing.Size(283, 199);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.RegAdminLabel);
            this.metroPanel2.Controls.Add(this.RegAdminNametxtBox);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.AdminRegbtn);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.RegAdminPasstxtBox);
            this.metroPanel2.Controls.Add(this.RegAdminUsrtxtBox);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(277, 192);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // RegAdminLabel
            // 
            this.RegAdminLabel.AutoSize = true;
            this.RegAdminLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RegAdminLabel.Location = new System.Drawing.Point(3, 12);
            this.RegAdminLabel.Name = "RegAdminLabel";
            this.RegAdminLabel.Size = new System.Drawing.Size(127, 25);
            this.RegAdminLabel.TabIndex = 13;
            this.RegAdminLabel.Text = "Register Admin";
            // 
            // RegAdminNametxtBox
            // 
            // 
            // 
            // 
            this.RegAdminNametxtBox.CustomButton.Image = null;
            this.RegAdminNametxtBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.RegAdminNametxtBox.CustomButton.Name = "";
            this.RegAdminNametxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegAdminNametxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegAdminNametxtBox.CustomButton.TabIndex = 1;
            this.RegAdminNametxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegAdminNametxtBox.CustomButton.UseSelectable = true;
            this.RegAdminNametxtBox.CustomButton.Visible = false;
            this.RegAdminNametxtBox.Lines = new string[0];
            this.RegAdminNametxtBox.Location = new System.Drawing.Point(93, 54);
            this.RegAdminNametxtBox.MaxLength = 32767;
            this.RegAdminNametxtBox.Name = "RegAdminNametxtBox";
            this.RegAdminNametxtBox.PasswordChar = '\0';
            this.RegAdminNametxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegAdminNametxtBox.SelectedText = "";
            this.RegAdminNametxtBox.SelectionLength = 0;
            this.RegAdminNametxtBox.SelectionStart = 0;
            this.RegAdminNametxtBox.ShortcutsEnabled = true;
            this.RegAdminNametxtBox.Size = new System.Drawing.Size(137, 23);
            this.RegAdminNametxtBox.TabIndex = 12;
            this.RegAdminNametxtBox.UseSelectable = true;
            this.RegAdminNametxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegAdminNametxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 54);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Name";
            // 
            // AdminRegbtn
            // 
            this.AdminRegbtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.AdminRegbtn.Location = new System.Drawing.Point(123, 151);
            this.AdminRegbtn.Name = "AdminRegbtn";
            this.AdminRegbtn.Size = new System.Drawing.Size(75, 23);
            this.AdminRegbtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.AdminRegbtn.TabIndex = 10;
            this.AdminRegbtn.Text = "Register";
            this.AdminRegbtn.UseSelectable = true;
            this.AdminRegbtn.Click += new System.EventHandler(this.AdminRegbtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Username";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegAdminPasstxtBox
            // 
            // 
            // 
            // 
            this.RegAdminPasstxtBox.CustomButton.Image = null;
            this.RegAdminPasstxtBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.RegAdminPasstxtBox.CustomButton.Name = "";
            this.RegAdminPasstxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegAdminPasstxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegAdminPasstxtBox.CustomButton.TabIndex = 1;
            this.RegAdminPasstxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegAdminPasstxtBox.CustomButton.UseSelectable = true;
            this.RegAdminPasstxtBox.CustomButton.Visible = false;
            this.RegAdminPasstxtBox.Lines = new string[0];
            this.RegAdminPasstxtBox.Location = new System.Drawing.Point(93, 122);
            this.RegAdminPasstxtBox.MaxLength = 32767;
            this.RegAdminPasstxtBox.Name = "RegAdminPasstxtBox";
            this.RegAdminPasstxtBox.PasswordChar = '*';
            this.RegAdminPasstxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegAdminPasstxtBox.SelectedText = "";
            this.RegAdminPasstxtBox.SelectionLength = 0;
            this.RegAdminPasstxtBox.SelectionStart = 0;
            this.RegAdminPasstxtBox.ShortcutsEnabled = true;
            this.RegAdminPasstxtBox.Size = new System.Drawing.Size(137, 23);
            this.RegAdminPasstxtBox.TabIndex = 7;
            this.RegAdminPasstxtBox.UseSelectable = true;
            this.RegAdminPasstxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegAdminPasstxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegAdminUsrtxtBox
            // 
            // 
            // 
            // 
            this.RegAdminUsrtxtBox.CustomButton.Image = null;
            this.RegAdminUsrtxtBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.RegAdminUsrtxtBox.CustomButton.Name = "";
            this.RegAdminUsrtxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegAdminUsrtxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegAdminUsrtxtBox.CustomButton.TabIndex = 1;
            this.RegAdminUsrtxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegAdminUsrtxtBox.CustomButton.UseSelectable = true;
            this.RegAdminUsrtxtBox.CustomButton.Visible = false;
            this.RegAdminUsrtxtBox.Lines = new string[0];
            this.RegAdminUsrtxtBox.Location = new System.Drawing.Point(93, 88);
            this.RegAdminUsrtxtBox.MaxLength = 32767;
            this.RegAdminUsrtxtBox.Name = "RegAdminUsrtxtBox";
            this.RegAdminUsrtxtBox.PasswordChar = '\0';
            this.RegAdminUsrtxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegAdminUsrtxtBox.SelectedText = "";
            this.RegAdminUsrtxtBox.SelectionLength = 0;
            this.RegAdminUsrtxtBox.SelectionStart = 0;
            this.RegAdminUsrtxtBox.ShortcutsEnabled = true;
            this.RegAdminUsrtxtBox.Size = new System.Drawing.Size(137, 23);
            this.RegAdminUsrtxtBox.TabIndex = 6;
            this.RegAdminUsrtxtBox.UseSelectable = true;
            this.RegAdminUsrtxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegAdminUsrtxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 314);
            this.Controls.Add(this.AdminInputTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.Resizable = false;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.AdminInputTabs.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.RegisterTab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl AdminInputTabs;
        private System.Windows.Forms.TabPage LoginTab;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TabPage RegisterTab;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroLabel PassLabel;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroTextBox PasswordtxtBox;
        private MetroFramework.Controls.MetroTextBox UsernametxtBox;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox RegAdminNametxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton AdminRegbtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox RegAdminPasstxtBox;
        private MetroFramework.Controls.MetroTextBox RegAdminUsrtxtBox;
        private MetroFramework.Controls.MetroLabel LoginAdminLabel;
        private MetroFramework.Controls.MetroLabel RegAdminLabel;
    }
}