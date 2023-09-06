
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace PP3.Models
{
    public class StudentMarks
       {
        string connectionString = "data source=HP\\SQLEXPRESS;initial catalog=School1;integrated security=True;MultipleActiveResultSets=True;";

        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> lstStudents = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Students2", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student student = new Student();

                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.StudentsName = rdr["StudentsName"].ToString();
                    student.StudentClass = Convert.ToInt32(rdr["StudentClass"]);
                    student.StudentsObtainMarks = Convert.ToInt32(rdr["StudentsObtainMarks"]); ;
                    lstStudents.Add(student);
                }
                con.Close();
            }
            return lstStudents;
        }
    }
}

