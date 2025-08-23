using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class db_class
    {
      static string ConString = Properties.Settings.Default.Inventory_DB_Conn;

        public static DataTable GetProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select prod_id , prod_name, prod_price, prod_qty, sup_id from products ", con))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;

        }









    }
}
