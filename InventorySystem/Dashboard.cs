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
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void cuiPictureBox1_Load(object sender, EventArgs e)
        {

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
            //productPage.FormBorderStyle = FormBorderStyle.None; // Optional: Set the form border style
            productPage.Show();





        }
    }
    }

