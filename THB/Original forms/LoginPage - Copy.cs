using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THB
{
    public partial class THBLogin : MaterialForm
    {
        public THBLogin()
        {
            Thread spl = new Thread(new ThreadStart(Splasher));
            spl.Start();
            Thread.Sleep(5500);
            InitializeComponent();
            spl.Abort();
        }

        public void Splasher()
        {
            Application.Run(new Splash());
        }
       
        private void THB_Load(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

       
        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void PassLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Dashboard main = new Dashboard();
            main.Show();
            this.Hide();
        }

        private void PasstxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
