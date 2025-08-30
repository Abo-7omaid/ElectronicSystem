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
    public partial class updateProduct : UserControl
    {
        public updateProduct()
        {
            productForm productPage = new productForm();
            InitializeComponent();
            
        }
        public string prodName
        {
            get => upd_productName_txt.Text;
            set => upd_productName_txt.Text = value;
        }


        public void FillData( string name, string price, string qty)
        {
            upd_productName_txt.Text = name;
            upd_productPrice_txt.Text = price.ToString();
            upd_productQuantity_txt.Text = qty.ToString();
        }







    }
}
