using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabPerformance01.Models.Database
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Insert(Student s)
        {
            string query = "insert into Students values(@Name, @DOB, @Credit, @CGPA, @Dept_ID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@DOB", s.DOB);
            cmd.Parameters.AddWithValue("@Credit", s.Credit);
            cmd.Parameters.AddWithValue("@CGPA", s.CGPA);
            cmd.Parameters.AddWithValue("@Dept_ID", s.Credit);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }

        public Student Get(int id)
        {
            Student s = null;
            string query = $"select * from Students where ID = {id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    //DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
            }
            conn.Close();
            return s;
        }

        public void Update(Student s)
        {
            string query = $"Update Students set Name='{s.Name}', DOB='{s.DOB}', Credit={s.Credit}, CGPA={s.CGPA} where ID={s.ID}" ;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            string query = $"Delete from Students where ID = {id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}