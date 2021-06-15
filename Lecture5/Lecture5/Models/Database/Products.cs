using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Lecture5.Models.Database
{
    public class Products
    {
        SqlConnection conn;

        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public List<Product> getAll()
        {
            List<Product> products = new List<Product>();
            string query = "select * from Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Qty = reader.GetInt32(reader.GetOrdinal("Qty")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                };
                products.Add(p);
            }
            conn.Close();
            return products;
        }
        public void Insert(Product p)
        {
            string query = "insert into Products values(@Name, @Price, @Qty, @Description)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@Price", p.Price);
            cmd.Parameters.AddWithValue("@Qty", p.Qty);
            cmd.Parameters.AddWithValue("@Description", p.Description);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void Delete(Product p)
        {

        }
        public Product Edit(int id)
        {
            Product p = null;
            string query = $"select * from Products where Id = {id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Qty = reader.GetInt32(reader.GetOrdinal("Qty")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                };
            }
            conn.Close();
            return p;
        }

        public void Update()
        {

        }
    }
}