using Student_Information_System.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        StudentRepo Std;
        StudentRepo student;

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        //constructor
        public EnrollmentRepository()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-2LFUD90;Database=SISDB;Trusted_Connection=True");
            sqlConnection = new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public string GetStudent(Enrollment enroll)
        {
            cmd.CommandText = "select concat (s.first_name + ' ' , s.last_name) as Student_Name from Students s JOIN Enrollments e ON s.student_id = e.student_id WHERE enrollment_id = @eid";
            cmd.Parameters.AddWithValue("@eid", enroll.EnrollmentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();

            string StudentName = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
            return StudentName;
        }


        public string GetCourse(Enrollment enroll) 
        {
            cmd.CommandText = "SELECT course_name from Courses c JOIN Enrollments e ON c.course_id = e.course_id WHERE enrollment_id = @eid";
            cmd.Parameters.AddWithValue("@eid", enroll.EnrollmentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            string CName = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
            return CName;
        }



    }
}
