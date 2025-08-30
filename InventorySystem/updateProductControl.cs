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

namespace InventorySystem
{
    public partial class updateProductControl : UserControl
    {
        public updateProductControl()
        {
            InitializeComponent();
            LoadSupplierName();
        }


        public int ProductId
        {
            get;
            set;
        }
        public string ProductName
        {
            get => upd_productName_txt.Text;
            set => upd_productName_txt.Text = value;
        }

        public string ProductPrice
        {
            get => upd_productPrice_txt.Text;
            set => upd_productPrice_txt.Text = value;
        }

        public string ProductQuantity
        {
            get => upd_productQuantity_txt.Text;
            set => upd_productQuantity_txt.Text = value;
        }
        public string SupplierName
        {
            get => suuuup.Text ;
            set => suuuup.Text = value;
        }

        public int SupplierId
        {
            get;
            set;
        }



        private void LoadSupplierName()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Inventory_DB_Conn))
            {
                con.Open();
                string query = "SELECT sup_id, sup_name FROM suppliers ORDER BY sup_name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    // Add default row at the beginning
                    DataRow defaultRow = dt.NewRow();
                    defaultRow["sup_id"] = SupplierId; // Special value for "not selected"
                    defaultRow["sup_name"] = SupplierName;
                    dt.Rows.InsertAt(defaultRow, 0); // Insert at position 0 (top)

                    // Set default choice

                    upd_SupplierName_cb.DisplayMember = "sup_name";
                    upd_SupplierName_cb.ValueMember = "sup_id";
                    upd_SupplierName_cb.DataSource = dt;

                    upd_SupplierName_cb.SelectedIndex = 0; // Select the default item


                }

            }

        }



        private bool ValidateProductsFields()
        {
            bool isValid = true;
            int cb_selected_value = (int)upd_SupplierName_cb.SelectedValue;
            errorProvider1.Clear();

          

            if (String.IsNullOrWhiteSpace(upd_productName_txt.Text.Trim()))
            {
                errorProvider1.SetError(upd_productName_txt, " Valid Product Name is required!");
                isValid = false;
            }
            if (!Decimal.TryParse(upd_productPrice_txt.Text.Trim(), out decimal price) || price <= 0)
            {
                errorProvider1.SetError(upd_productPrice_txt, "Valid price is required!");
                isValid = false;

            }
            if (!int.TryParse(upd_productQuantity_txt.Text.Trim(), out int quantity) || quantity <= 0)
            {
                errorProvider1.SetError(upd_productQuantity_txt, "Valid quantity is required!");
                isValid = false;
            }
            if ((int)upd_SupplierName_cb.SelectedValue == -1 || (int)upd_SupplierName_cb.SelectedValue == 0 )
            {
                errorProvider1.SetError(upd_SupplierName_cb, "Valid supplier is required!");
                isValid = false;

            }
            return isValid;

        }







public void FillData(string name, string price, string qty, string supName)
        {
            upd_productName_txt.Text = name;
            upd_productPrice_txt.Text = price.ToString();
            upd_productQuantity_txt.Text = qty.ToString();
            //upd_supplierName_txt.Text = supName;

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            ProductName = "";
            ProductPrice = "";
            ProductQuantity = "";
            SupplierName = "";
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (ValidateProductsFields())
            {

                bool result = db_class.UpdateProduct(ProductId, upd_productName_txt.Text,
                    decimal.Parse(upd_productPrice_txt.Text),
                    int.Parse(upd_productQuantity_txt.Text),
                    (int)upd_SupplierName_cb.SelectedValue);
                ;
                if (result)
                {
                    MessageBox.Show("Product updated successfully.");
                    // Clear fields  and refresh table after update
                    ProductName = "";
                    ProductPrice = "";
                    ProductQuantity = "";
                    SupplierName = "";
                }
                else
                {
                    MessageBox.Show("Failed to update product. Please try again.");

                }
            }



        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete" + SupplierName + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    bool result = db_class.DeleteProduct(ProductId);
                    if (result)
                    {
                        MessageBox.Show("Product deleted successfully.");
                        // Clear fields  and refresh table after delete
                        ProductName = "";
                        ProductPrice = "";
                        ProductQuantity = "";
                        SupplierName = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product. Please try again.");
                    }
                }
        }

        private void updateProductControl_Load(object sender, EventArgs e)
        {
          
        }
    }
}
