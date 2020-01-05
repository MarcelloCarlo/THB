using MetroFramework;
using System;
using System.Threading;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace THB
{
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        String SqlInit = "Data Source=SELENE-GAGA\\FRUITYSQLEXP19;Initial Catalog=THB;Integrated Security=True ";

       
        public AdminLogin()
        {   
            // main objective ko dito is if galing ka na sa dashboard (after logout) dapat wala si splash!
            Thread spl = new Thread(new ThreadStart(Splasher));
            spl.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            spl.Abort();
            this.Show();
        }

        static string Encryptor(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);           
            }
        }
        public void Splasher()
        {
            Application.Run(new Splash());
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlInit);
            con.Open();
            // if match ang credentials.... edi wow! pasok na sa dashboard, else...error!!
            if (string.IsNullOrEmpty(UsernametxtBox.Text) || string.IsNullOrEmpty(PasswordtxtBox.Text))
            {
                MetroMessageBox.Show(this, "Please fill out missing fields", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    PasswordtxtBox.Text = Encryptor(PasswordtxtBox.Text);
                    SqlCommand Logincmd = new SqlCommand("SELECT Admin_Username,Admin_Password,Admin_Status FROM ADMIN_ACCOUNTS WHERE Admin_Username='" + UsernametxtBox.Text + "'and Admin_Password='" + PasswordtxtBox.Text + "'and Admin_Status =1", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(Logincmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        UsernametxtBox.Text = "";
                        PasswordtxtBox.Text = "";
                        MetroMessageBox.Show(this, "Login Success! ", "Login");
                        Dashboard main = new Dashboard();
                        main.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        PasswordtxtBox.Text = "";
                        MetroMessageBox.Show(this, "Login failed! Please try again ", "Login");
           
                    }

                   
                }
                catch (Exception ex)
                {
                    PasswordtxtBox.Text = "";
                    MetroMessageBox.Show(this, "Error occured. Please try again. Details: "+ ex, "Error");
                }
            }
            con.Close();
        }
        private void AdminRegbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlInit);
            con.Open();
            // if match ang credentials.... edi wow! pasok na sa dashboard, else...error!!
            if (string.IsNullOrEmpty(RegAdminNametxtBox.Text) || string.IsNullOrEmpty(RegAdminPasstxtBox.Text) || string.IsNullOrEmpty(RegAdminUsrtxtBox.Text))
            {
                MetroMessageBox.Show(this, "Please fill out missing fields", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                   
                  
                    RegAdminPasstxtBox.Text = Encryptor(RegAdminPasstxtBox.Text);
                    SqlCommand RegCmd = new SqlCommand("INSERT INTO ADMIN_ACCOUNTS(Admin_Username,Admin_Password,Admin_Status,Admin_Name) VALUES('" + RegAdminUsrtxtBox.Text + "','" + RegAdminPasstxtBox.Text + "',1,'" + RegAdminNametxtBox.Text + "')",con);
                    RegCmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "Registration Success! ", "Register");
                    RegAdminNametxtBox.Text = "";
                    RegAdminPasstxtBox.Text = "";
                    RegAdminUsrtxtBox.Text = "";
                    

                }
                catch (Exception)
                {
                    RegAdminPasstxtBox.Text = "";
                    MetroMessageBox.Show(this, "Error occured. Please try again. ", "Error");                   
                    return;
                }
            }
            con.Close();

        }
    }
}
