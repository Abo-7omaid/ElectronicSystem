using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
            product_dgv.DataSource = db_class.GetProducts();

        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void cuiSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void productForm_Load(object sender, EventArgs e)
        {
            product_dgv.Columns[0].HeaderText = "ID";
            product_dgv.Columns[1].HeaderText = "Name";
            product_dgv.Columns[2].HeaderText = "Price";
            product_dgv.Columns[3].HeaderText = "Quantity";
            product_dgv.Columns[4].HeaderText = "Supplier";
            search_txt.Focus();


            // TODO: This line of code loads data into the 'inventoryDBDataSet.products' table. You can move, or remove it, as needed.

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            //db_class.AddProduct(Add_productName_txt.Text.Trim(), decimal.Parse(Add_productQuantity_txt.Text.Trim()), int.Parse(Add_productPrice_txt.Text.Trim()), int.Parse(supplierName_txt.Text.Trim()));
            
           


        }

        private void addProduct_btn_Click_1(object sender, EventArgs e)
        {
            string name = Add_productName_txt.Text.Trim();
            decimal price = decimal.Parse(Add_productPrice_txt.Text.Trim());
            int quantity = int.Parse(Add_productQuantity_txt.Text.Trim());
            int supplierId = int.Parse(supplierName_txt.Text.Trim());
            int result = db_class.AddProduct(name, price, quantity, supplierId);
            if (result > 0)
            {
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                product_dgv.DataSource = db_class.GetProducts(); // Refresh the DataGridView to show the new product
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
