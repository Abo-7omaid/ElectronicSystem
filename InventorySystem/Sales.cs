using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Properties;

namespace InventorySystem
{
    public partial class Sales : Form
    {


        public Sales()
        {
            InitializeComponent();
            product_dgv.DataSource = db_class.GetProducts();
           

        }
        

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiTextBox7_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiTextBox8_ContentChanged(object sender, EventArgs e)
        {

        }

        private void SalesSearch_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = db_class.SearchProduct(search_txt.Text.Trim());
            product_dgv.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Product not found!", "Search result", MessageBoxButtons.OK);
                product_dgv.DataSource = db_class.GetProducts(); // Reload all products
            }

        }

        private void Sales_Shown(object sender, EventArgs e)
        {
            search_txt.Text = "";
            product_dgv.Columns[0].HeaderText = "ID";
            product_dgv.Columns[1].HeaderText = "Name";
            product_dgv.Columns[2].HeaderText = "Price";
            product_dgv.Columns[3].HeaderText = "Quantity";
            product_dgv.Columns[4].HeaderText = "Supplier";
            search_txt.Focus();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = db_class.SearchProduct(search_txt.Text.Trim());
            product_dgv.DataSource = dt;
        }

        private void productName_cb_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Settings.Default.Inventory_DB_Conn))
            {
                con.Open();
                string query = "SELECT prod_name FROM products";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        productName_cb.Items.Clear();
                        while (reader.Read())
                        {
                            productName_cb.Items.Add(reader["prod_name"].ToString());
                        }
                    }
                }
            }
        }


        private void productName_cb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

