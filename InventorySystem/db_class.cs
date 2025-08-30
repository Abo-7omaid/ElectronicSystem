using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //@ to allow us writing the query in multiple lines
                string query = @"select prod_id,
                     p.prod_name,
                     p.prod_price, 
                    p.prod_qty,
                    s.sup_name from products p
                INNER JOIN suppliers s ON p.sup_id = s.sup_id
                ORDER BY p.prod_name";
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
                //FROM + JOIN first
                //Then WHERE
                //Then ORDER BY


                string query = @"select prod_id,
                     p.prod_name,
                     p.prod_price, 
                    p.prod_qty,
                    s.sup_name from products p
                INNER JOIN suppliers s ON p.sup_id = s.sup_id
                WHERE LOWER(p.prod_name) LIKE LOWER(@ProductName)
                ORDER BY p.prod_name";
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
        }// end of AddProduct


        public static int AddSupplier(string name, string email, int phone)
        {
            int newId; // return the new id 
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    string query = "Insert into suppliers (sup_name, sup_email, sup_phone)" +" OUTPUT INSERTED.sup_id " +" Values (@SupplierName , @SupplierEmail, @SupplierPhone)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", name);
                        cmd.Parameters.AddWithValue("@SupplierEmail", email);
                        cmd.Parameters.AddWithValue("@SupplierPhone", phone);
                        newId =(int) cmd.ExecuteScalar();
                    }
                }
                return newId; // Indicate success
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }// end of AddSupplier


        public static bool UpdateProduct(int id, string name, decimal price, int quantity, int supplierId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    string query = "UPDATE products SET prod_name = @Name, prod_price = @Price, prod_qty = @Quantity, sup_id = @SupplierId WHERE prod_id = @Id ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if at least one row was updated
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new ApplicationException("An error occurred while updating the product.", ex);
            }
        }// end of UpdateProduct



        public static int GetSupplierIdByName(string supplierName)
        {
            int supplierId = -1; // Default value if not found
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    string query = "SELECT sup_id FROM suppliers WHERE sup_name = @SupplierName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            supplierId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new ApplicationException("An error occurred while retrieving the supplier ID.", ex);
            }
            return supplierId;
        }// end of GetSupplierIdByName



        public static bool DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    string query = "DELETE FROM products WHERE prod_id = @ProductId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if at least one row was deleted
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new ApplicationException("An error occurred while deleting the product.", ex);
            }
        }// end of DeleteProduct


        public static bool CheckUserRole(string username)
        {
           string role = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    string query = "SELECT user_role FROM Users WHERE user_name = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        object result = cmd.ExecuteScalar();

                        if (result != null) // User found
                        {
                            role = result.ToString();
                            if(role == "Admin")
                            {
                                return true;
                            }
                            
                        }
                        else
                        {
                            return false; // No such user
                        }
                    }
                }
                return false; // Default to false if not admin
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking the user role.", ex);
            }
        }// end of CheckUserRole


    }
}
