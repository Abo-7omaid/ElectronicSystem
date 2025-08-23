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
            // TODO: This line of code loads data into the 'inventoryDBDataSet.products' table. You can move, or remove it, as needed.

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            //db_class db = new db_class();
           //product_dgv.DataSource =  db_class.GetProducts();
        }
    }
}
