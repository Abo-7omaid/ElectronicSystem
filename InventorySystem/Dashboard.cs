using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventorySystem
{
    public partial class Dashboard : Form
    {

        int panelWidth; // Width of the menu panel when expanded
        bool isCollapsed; // State of the menu panel


        public Dashboard()
        {
        InitializeComponent();
            // Initialize the panel width for the expanded state
            panelWidth = sidebar_pnl.Width; // Set the initial width of the main panel
            isCollapsed = false; // Initially, the panel is not collapsed
            user_lbl.Text = loginForm.Global.Username;


        }

        private void sale_btn_Click(object sender, EventArgs e)
        {

        }

       
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                // Expand the menu
                sidebar_pnl.Width = panelWidth;
                isCollapsed = false;
            }
            else
            {
                // Collapse the menu
                sidebar_pnl.Width = 0;
                isCollapsed = true;

            }
        }

       

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            main_pnl.Controls.Clear();
            Sales salePage = new Sales();
            // Collapse the menu
            //sidebar_pnl.Width = 0;
            //isCollapsed = true;

            salePage.TopLevel = false;
            main_pnl.Controls.Add(salePage);
            salePage.Dock = DockStyle.Fill;
            salePage.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //loginForm loginPage = new loginForm();
            //loginPage.Show();
            //loginForm loginPage = new loginForm();
            //user_lbl.Text = this.currentUser;

        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            //loginForm loginPage = new loginForm();
            //loginPage.Show();
            //this.Hide();
            //loginForm.opened
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            productForm productPage = new productForm();
            //productPage.Show();

            main_pnl.Controls.Clear();
            productPage.TopLevel = false;
            main_pnl.Controls.Add(productPage);
            productPage.Dock = DockStyle.Fill;
            productPage.Show();





        }

        private void main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void cuiLabel4_Load(object sender, EventArgs e)
        {

        }

        private void sale_btn_Click_1(object sender, EventArgs e)
        {
            main_pnl.Controls.Clear();
            Sales salePage = new Sales();
            // Collapse the menu
            //sidebar_pnl.Width = 0;
            //isCollapsed = true;

            salePage.TopLevel = false;
            main_pnl.Controls.Add(salePage);
            salePage.Dock = DockStyle.Fill;
            salePage.FormBorderStyle = FormBorderStyle.None; // Optional: Set the form border style

            salePage.Show();
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            productForm productPage = new productForm();
            //productPage.Show();

            main_pnl.Controls.Clear();
            productPage.TopLevel = false;
            main_pnl.Controls.Add(productPage);
            productPage.Dock = DockStyle.Fill;
            productPage.FormBorderStyle = FormBorderStyle.None; // Optional: Set the form border style
            productPage.Show();
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {
       
        }

        private void user_lbl_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

