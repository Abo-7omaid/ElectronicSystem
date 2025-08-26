using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;



namespace InventorySystem
{
    public partial class loginForm : Form
    {
        public static class Global
        {
            public static string Username { get; set; }
        }








        public loginForm()
        {
            InitializeComponent();
             string myConn = Properties.Settings.Default.Inventory_DB_Conn;
            SqlConnection conn = new SqlConnection(myConn);
            conn.Open();




        }
        bool opened = false;

        private void createAccount_btn_Click(object sender, EventArgs e)
        {

            createAccountForm create_account_form = new createAccountForm();
            create_account_form.ShowDialog();
            //to make the loginForm disable when the createAccountForm is opened



        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            string myConn = Properties.Settings.Default.Inventory_DB_Conn;  
            SqlConnection conn = new SqlConnection(myConn);
            conn.Open();
            string sql = "SELECT user_name FROM Users WHERE user_name = @username AND user_password = @password";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", user_txt.Text);
                cmd.Parameters.AddWithValue("@password", password_txt.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {

                    string userRole = result.ToString();
                    MessageBox.Show("Login successful! User role: " + userRole);
                    this.DialogResult = DialogResult.OK;
                    Global.Username = user_txt.Text;
                    // we take the username and store it in a global variable to display it in the dashboard
                    this.Close();
                    // Here you can redirect to the main application form based on the user role
                  
                }
                else
                {
                    MessageBox.Show("Invalid username or password." + user_txt.Text );
                    user_txt.AcceptsReturn = true;
                    user_txt.Focus();
                }
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void username_validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if(((Control)sender).Text.Trim().Length == 0)
            {
                error = "Enter UserName!";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginForm_Shown(object sender, EventArgs e)
        {
            user_txt.Focus();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            bool isPasswordVisible = password_txt.UseSystemPasswordChar;
            if (password_txt.UseSystemPasswordChar)
            {
                password_txt.UseSystemPasswordChar = false;
                eyeImage_btn.Image = Properties.Resources.icons8_hide_25;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
                eyeImage_btn.Image = Properties.Resources.icons8_eye_25;
            }
        }
    }
}
