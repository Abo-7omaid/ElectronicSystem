using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Components.Forms;

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


        //function to validate phone number and password
        private bool IsValid(string password, string phone)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long!", "Invalid Password", MessageBoxButtons.OK);
                return false;
            }
            else if (!phone.All(char.IsDigit) || phone.Length != 9 || !phone.StartsWith("7"))
            {
                MessageBox.Show("Phone number must be only 9 digits! , contain only numbers!, and should start with 7!", "Invalid Phone Number", MessageBoxButtons.OK);
                return false;
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter!", "Invalid Password", MessageBoxButtons.OK);
                return false;
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lowercase letter!", "Invalid Password", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }



        }




        private void createNewAccount_btn_Click(object sender, EventArgs e)
        {
                bool valid = IsValid(createPassword_txt.Text, createPhone_txt.Text);
        if (valid)
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
        else
            {
                return;
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

        private void createAccountForm_Shown(object sender, EventArgs e)
        {
            createUserName_txt.Focus();
        }
    }
}
