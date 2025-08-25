using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace InventorySystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
            loginForm loginPage = new loginForm();

            //if (loginPage.ShowDialog() == DialogResult.OK)   // login successful
            //{
            //    Application.Run(new Dashboard());    // start app with Dashboard
            //}
            //else
            //{
            //    // Exit if login failed or canceled
            //    Application.Exit();
            //}

        }
    }
}
