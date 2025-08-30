using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Components.Forms;


namespace InventorySystem
{
    public partial class productForm : Form
    {

        public productForm()
        {
            InitializeComponent();
            product_dgv.DataSource = db_class.GetProducts();



        }
        //Functions

        //to load suppliers name to the cb and return the values of the supplier id
        private void LoadSupplierName()
        {
            //try
            //{
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
                    defaultRow["sup_id"] = -1; // Special value for "not selected"
                    defaultRow["sup_name"] = "-Please Choose-";
                    dt.Rows.InsertAt(defaultRow, 0); // Insert at position 0 (top)

                    // Set default choice

                    Add_SupplierName_cb.DisplayMember = "sup_name";
                    Add_SupplierName_cb.ValueMember = "sup_id";
                    Add_SupplierName_cb.DataSource = dt;

                    Add_SupplierName_cb.SelectedIndex = 0; // Select the default item


                }

            }
            //}

        }













        private bool ValidateProductsFields()
        {
            bool isValid = true;
            int cb_selected_value = (int)Add_SupplierName_cb.SelectedValue;
            errorProvider1.Clear();

            //

            if (String.IsNullOrWhiteSpace(Add_productName_txt.Text.Trim()))
            {
                errorProvider1.SetError(Add_productName_txt, " Valid Product Name is required!");
                isValid = false;
            }
            if (!Decimal.TryParse(Add_productPrice_txt.Text.Trim(), out decimal price) || price <= 0)
            {
                errorProvider1.SetError(Add_productPrice_txt, "Valid price is required!");
                isValid = false;

            }
            if (!int.TryParse(Add_productQuantity_txt.Text.Trim(), out int quantity) || quantity <= 0)
            {
                errorProvider1.SetError(Add_productQuantity_txt, "Valid quantity is required!");
                isValid = false;
            }
            //Supplier combobox field (Add_SupplierName_cb.Enabled)
            if (Add_SupplierName_cb.Enabled)
            {
                //Add_SupplierName_cb.Enabled = false;


                if ((int)Add_SupplierName_cb.SelectedValue == -1 || Add_SupplierName_cb.SelectedValue == null)
                {
                    errorProvider1.SetError(Add_SupplierName_cb, "Valid supplier is required!");
                    isValid = false;

                }
            }

            else
            {
                if (String.IsNullOrWhiteSpace(Create_supplierName_txt.Text.Trim()))
                {
                    errorProvider1.SetError(Create_supplierName_txt, " Valid Supplier Name is required!");
                    isValid = false;

                }
                if (!String.IsNullOrWhiteSpace(Create_supplierEmail_txt.Text.Trim()))
                {
                    try
                    {
                        new MailAddress(Create_supplierEmail_txt.Text);
                    }
                    catch (Exception)
                    {
                        errorProvider1.SetError(Create_supplierEmail_txt, " Valid Supplier Email is required!");
                        isValid = false;
                    }
                }
                if (!int.TryParse(Create_supplierContact_txt.Text.Trim(), out int phone) || (phone <= 0 && phone <= 9))
                {
                    errorProvider1.SetError(Create_supplierContact_txt, "Supplier's Contact must be valid 9 digits!");
                    isValid = false;


                }
            }





            return isValid;
        }
        //Clear
        private void ClearControls()
        {
            Add_productName_txt.Clear();
            Add_productPrice_txt.Clear();
            Add_productQuantity_txt.Clear();
            Add_SupplierName_cb.SelectedValue = -1;
            Create_supplierContact_txt.Clear();
            Create_supplierName_txt.Clear();
            Create_supplierEmail_txt.Clear();
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
            product_dgv.Columns[0].HeaderText = "ID";
            product_dgv.Columns[1].HeaderText = "Name";
            product_dgv.Columns[2].HeaderText = "Price";
            product_dgv.Columns[3].HeaderText = "Quantity";
            product_dgv.Columns[4].HeaderText = "Supplier";
            search_txt.Focus();

            LoadSupplierName();



        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {


        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {




        }

        private void addProduct_btn_Click_1(object sender, EventArgs e)
        {


            //try
            //{

            if (ValidateProductsFields())
            {



                if (Create_supplierName_txt.Enabled)
                {
                    string name = Add_productName_txt.Text.Trim();
                    decimal price = decimal.Parse(Add_productPrice_txt.Text.Trim());
                    int quantity = int.Parse(Add_productQuantity_txt.Text.Trim());
                    //Adding new suppliers fields
                    string supplierName = Create_supplierName_txt.Text.Trim();
                    string supplierEmail = Create_supplierEmail_txt.Text.Trim();
                    int supplierPhone = int.Parse(Create_supplierContact_txt.Text.Trim());
                    //Add new supplier and get the new id
                    int supplierResult = db_class.AddSupplier(supplierName, supplierEmail, supplierPhone);
                    if (supplierResult > 0)
                    {
                        DialogResult dialresult = MessageBox.Show(
                              "New Supplier added successfully is: " + supplierName,
                              "Confirmation",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information,
                              MessageBoxDefaultButton.Button1
                              );
                        LoadSupplierName();
                        //Add the product with the new supplier id
                        int result = db_class.AddProduct(name, price, quantity, supplierResult);
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


                if (Add_SupplierName_cb.Enabled)
                {
                    //Adding with recorded supplier
                    string name = Add_productName_txt.Text.Trim();
                    decimal price = decimal.Parse(Add_productPrice_txt.Text.Trim());
                    int quantity = int.Parse(Add_productQuantity_txt.Text.Trim());
                    int supplierId = (int)Add_SupplierName_cb.SelectedValue;
                    int result = db_class.AddProduct(name, price, quantity, supplierId);
                    if (result > 0)
                    {
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        product_dgv.DataSource = db_class.GetProducts(); // Refresh the DataGridView to show the new product
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }











                //int result  = db_class.AddProduct(name, price, quantity, supplierId);

                // = db_class.
                //db_class.AddProduct(Add_productName_txt.Text.Trim(), decimal.Parse(Add_productQuantity_txt.Text.Trim()), int.Parse(Add_productPrice_txt.Text.Trim()), int.TryParse(Add_SupplierName_cb.SelectedValue );



            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

     

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void AddSupplier_btn_Click(object sender, EventArgs e)
        {

            if (Add_SupplierName_cb.Enabled)
            {
                AddSupplier_btn.Image = Properties.Resources.icons8_search_50;
                Add_SupplierName_cb.Enabled = false;
                Create_supplierName_txt.Enabled = true;
                Create_supplierEmail_txt.Enabled = true;
                Create_supplierContact_txt.Enabled = true;
                Create_supplierName_txt.BorderColor = Color.Red;
                Create_supplierEmail_txt.BorderColor = Color.Red;
                Create_supplierContact_txt.BorderColor = Color.Red;

            }
            else
            {
                AddSupplier_btn.Image = Properties.Resources.icons8_add_64;
                Add_SupplierName_cb.Enabled = true;
                Create_supplierName_txt.Enabled = false;
                Create_supplierEmail_txt.Enabled = false;
                Create_supplierContact_txt.Enabled = false;
            }

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void UpdatePage_btn_Click(object sender, EventArgs e)
        {
            loginForm loginPage = new loginForm();
            loginPage.ShowDialog();
            string authenticatedUser = loginForm.Global.Username;
            if (db_class.CheckUserRole(authenticatedUser))
            { // User is admin, proceed with deletion
                MessageBox.Show("Authentication successful. You can proceed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddProduct_groupbox.Visible = false;
                AddProduct_pnl.Controls.Clear();
                updateProductControl updatePage = new updateProductControl();
                AddProduct_pnl.Controls.Add(updatePage);
                updatePage.BringToFront();
                updatePage.Dock = DockStyle.Fill;
                updatePage.Show();

            }
            else
            {
                MessageBox.Show("Authentication failed! Only Admins can access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }


            
        }

        private void addPage_btn_Click(object sender, EventArgs e)
        {
            AddProduct_pnl.Controls.Clear();
            AddProduct_pnl.Controls.Add(AddProduct_groupbox);
            AddProduct_groupbox.Visible = true;
        }

        private void product_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = product_dgv.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string name = row.Cells[1].Value.ToString();
            string price = row.Cells[2].Value.ToString();
            string qty = row.Cells[3].Value.ToString();
            string supName = row.Cells[4].Value.ToString();
            int supId = db_class.GetSupplierIdByName(supName);
            updateProductControl updateForm = AddProduct_pnl.Controls["updateProductControl"] as updateProductControl;
            // as here attempts to cast the control to updateProductControl without throwing an exception if it fails , beacause if it fails it will return null
            if (updateForm != null)
            {
                updateForm.ProductId = id;
                updateForm.ProductName = name;
                updateForm.ProductPrice = price;
                updateForm.ProductQuantity = qty;
                updateForm.upd_SupplierName_cb.SelectedValue = supId;
                updateForm.SupplierId = supId;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            product_dgv.DataSource = db_class.GetProducts();
            
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
           DataTable dt=  db_class.SearchProduct(search_txt.Text.Trim());
            product_dgv.DataSource = dt;

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
