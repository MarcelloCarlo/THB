using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THB
{

    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
       String SqlInit = "Data Source=SELENE-GAGA\\FRUITYSQLEXP19;Initial Catalog=THB;Integrated Security=True ";

        string prodID = "";
        string imgLoc = "";
        int cond = 0;
        public Dashboard()
        {
            InitializeComponent();
            ProdTypetxtBox.Enabled = false;
            ProdPricetxtBox.Enabled = false;
            ProdTypetxtBox.Enabled = false;
            BrowseImgBtn.Enabled = false;
            AddProdBtn.Enabled = true;
            EditProdBtn.Enabled = true;

            SaveProdBtn.Enabled = false;
            CancelProdButton.Enabled = false;

            bindgrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void bindgrid()
        {

            try
            {
                SqlConnection con = new SqlConnection(SqlInit);

                con.Open();

                string sql = "SELECT Product_ID AS ID,Product_Name AS Name,Product_Price AS Price ,Product_Type AS Type FROM PRODUCTS";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter dAdapter = new SqlDataAdapter();

                dAdapter.SelectCommand = cmd;

                DataSet ds = new DataSet();

                dAdapter.Fill(ds);

                DataTable dt;

                dt = ds.Tables[0];

                ProductsGrid.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Error occured. Please try again. ", "BindGrid Error");
                return;
            }
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);

            prodID = ProductsGrid.Rows[index].Cells[0].Value.ToString();
            ProdNametxtBox.Text = ProductsGrid.Rows[index].Cells[1].Value.ToString();
            ProdPricetxtBox.Text = ProductsGrid.Rows[index].Cells[2].Value.ToString();
            ProdTypetxtBox.Text = ProductsGrid.Rows[index].Cells[3].Value.ToString();



        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            cond = 1;
            ProdTypetxtBox.Enabled = true;
            ProdPricetxtBox.Enabled = true;
            ProdTypetxtBox.Enabled = true;
            BrowseImgBtn.Enabled = true;
            ProdNametxtBox.Text = "";
            ProdPricetxtBox.Text = "";
            ProdTypetxtBox.Text = "";
            //txtEmp.Text = "";

            AddProdBtn.Enabled = false;
            EditProdBtn.Enabled = false;

            SaveProdBtn.Enabled = true;
            CancelProdButton.Enabled = true;
        }

        private void EditProdBtn_Click(object sender, EventArgs e)
        {
            cond = 2;
            ProdTypetxtBox.Enabled = true;
            ProdPricetxtBox.Enabled = true;
            ProdTypetxtBox.Enabled = true;
            BrowseImgBtn.Enabled = true;
            AddProdBtn.Enabled = false;
            EditProdBtn.Enabled = false;

            SaveProdBtn.Enabled = true;
            CancelProdButton.Enabled = true;
        }

        private void SaveProdBtn_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(SqlInit);
                con.Open();

                if (string.IsNullOrEmpty(ProdTypetxtBox.Text) || string.IsNullOrEmpty(ProdNametxtBox.Text) || string.IsNullOrEmpty(ProdPricetxtBox.Text))
                {
                    MetroMessageBox.Show(this, "Please fill out missing fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (cond == 1)
                {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "INSERT INTO PRODUCTS (Product_Name,Product_Price,Product_Type,Product_Image)";
                    string sql1 = " VALUES('" + ProdNametxtBox.Text + "','" + ProdPricetxtBox.Text + "','" + ProdTypetxtBox.Text + "','" + img + "')";
                    SqlCommand sqlcmd = new SqlCommand(sql + sql1, con);
                   // sqlcmd.Parameters.Add(ProdPricetxtBox.Text, SqlDbType.SmallMoney).Value = ProdPricetxtBox.Text;

                    sqlcmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "Added Successfully! ", "Done");
                    ProdNametxtBox.Text = "";
                    ProdPricetxtBox.Text = "";
                    ProdTypetxtBox.Text = "";
                    ProdTypetxtBox.Enabled = false;
                    ProdPricetxtBox.Enabled = false;
                    ProdTypetxtBox.Enabled = false;

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error occured. Please try again. Details: "+ ex, "Product Insert Error");
                   
                    return;
                }

            }
                else
                {
                try
                {
                    string sql = "UPDATE Product_Name,Product_Price,Product_Type SET Product_Name = '" + ProdNametxtBox.Text + "', Product_Price ='" + ProdPricetxtBox.Text + "', Product_Type = '" + ProdTypetxtBox.Text + "' WHERE Product_ID = '" + prodID + "'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(ProdPricetxtBox.Text, SqlDbType.SmallMoney).Value = ProdPricetxtBox.Text;
                    cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "Updated Successfully! ", "Done");
                    ProdNametxtBox.Text = "";
                    ProdPricetxtBox.Text = "";
                    ProdTypetxtBox.Text = "";
                    ProdTypetxtBox.Enabled = false;
                    ProdPricetxtBox.Enabled = false;
                    ProdTypetxtBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error occured. Please try again. Details: " + ex, "Product Update Error");
                    return;
                }
            }

                con.Close();
                AddProdBtn.Enabled = true;
                EditProdBtn.Enabled = true;
                
                SaveCustomerBtn.Enabled = false;
                CancelProdButton.Enabled = false;

                bindgrid();
            
           
            {

            }
        }

        private void CancelProdButton_Click(object sender, EventArgs e)
        {
            prodID = "";
            ProdNametxtBox.Text = "";
            ProdPricetxtBox.Text = "";
            ProdTypetxtBox.Text = "";

            AddProdBtn.Enabled = true;
            EditProdBtn.Enabled = true;
           
            SaveProdBtn.Enabled = false;
            CancelProdButton.Enabled = false;

            bindgrid();
        }

        private void BrowseImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog bimg = new OpenFileDialog();
                bimg.Filter ="JPG Files (*jpg)|*jpg|PNG Files (*png)|*png|All Files (*.*)|*.*";
                bimg.Title = "Select Product Image";
                if(bimg.ShowDialog() ==DialogResult.OK)
                {
                    imgLoc = bimg.FileName.ToString();
                    ProdSetpicBox.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Error occured. Please try again. ", "Insert Product Image Error");
                return;
            }
        }
    }
}
