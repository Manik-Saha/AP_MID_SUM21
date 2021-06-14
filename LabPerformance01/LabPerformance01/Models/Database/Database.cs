using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabPerformance01.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Admins Admins { get; set; }
        public Department Department { get; set; }
        public Database()
        {
            string conString = @"Data Source=LAPTOP-DK7TKAJO\SQLEXPRESS;Initial Catalog=LabPerformance01;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);

            Students = new Students(conn);
            Admins = new Admins(conn);
        }
    }
}