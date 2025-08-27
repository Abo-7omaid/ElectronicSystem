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
                string query = "select prod_id , prod_name, prod_price, prod_qty, sup_id from products";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;

        }// end of GetProducts

        public static DataTable SearchProduct(string productName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                //string query = "select prod_id , prod_name, prod_price, prod_qty, sup_id from products where prod_name = @productName ";

                string query = "SELECT prod_id , prod_name, prod_price, prod_qty, sup_id FROM products WHERE LOWER(prod_name) LIKE LOWER(@ProductName)";


                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@ProductName", "%" + productName + "%");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;

        }// end of SearchProduct

       
        public static int  AddProduct(string name, decimal price, int quantity, int supplierId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    string query = "INSERT INTO products (prod_name, prod_price, prod_qty, sup_id) VALUES (@Name, @Price, @Quantity, @SupplierId)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                        cmd.ExecuteNonQuery();
                    }
                }
                int rowsAffected = 1; // Simulate rows affected
                return rowsAffected; // Indicate success
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new ApplicationException("An error occurred while adding the product.", ex);

            }

        }






    }
}
