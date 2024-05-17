using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS2
{
    internal class StudentRepo
    {
        Students stud1 = new Students();

        public List<Students> DisplayStudentInfo()
        {
            List<Students> student = new List<Students>();
            cmd.CommandText = "SELECT * FROM Students";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stud1 = new Students();
                stud1.StudentID= (int)reader["student_id"];
                stud1.FirstName = (string)reader["first_name"];
                stud1.LastName = (string)reader["last_name"];
                stud1.DateOfBirth = (DateTime)reader["date_of_birth"];
                stud1.Email = (string)reader["email"];
                stud1.PhoneNumber = (string)reader["phone_number"];

                student.Add(stud1);
            }
            return student;
            sqlConnection.Close();
        }
    }
}
