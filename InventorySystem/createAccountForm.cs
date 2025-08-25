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
    public partial class createAccountForm : Form
    {
        public createAccountForm()
        {
            InitializeComponent();
            string myConn = Properties.Settings.Default.Inventory_DB_Conn;
            SqlConnection conn = new SqlConnection(myConn);
            conn.Open();
        }

        private void createNewAccount_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myConn = Properties.Settings.Default.Inventory_DB_Conn;
                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();
                    string sql = "INSERT INTO Users (user_name, user_password, user_phone, user_role  ) VALUES (@username, @password, @phone, @role)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", createUserName_txt.Text);
                        cmd.Parameters.AddWithValue("@password", createPassword_txt.Text);
                        cmd.Parameters.AddWithValue("@phone", createPhone_txt.Text);
                        cmd.Parameters.AddWithValue("@role", createRole_cb.SelectedItem);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Account created successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
            }
        }

        private void user_validation(object sender, CancelEventArgs e)
        {
            string error = null;
            if (((Control)sender).Text.Trim().Length == 0)
            {
                error = "This field can't be empty!";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);

        }
    }
}
