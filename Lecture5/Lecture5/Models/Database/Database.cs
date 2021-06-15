using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Lecture5.Models.Database;

namespace Lecture5.Models.Database
{
    public class Database
    {
        public Products Products { get; set; }
        public Categories Categories { get; set; }

        public Database()
        {
            string conString = @"Data Source=LAPTOP-DK7TKAJO\SQLEXPRESS;Initial Catalog=PMS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);

            Products = new Products(conn);
            Categories = new Categories(conn);
        }
    }
}