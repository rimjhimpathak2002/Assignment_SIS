using Microsoft.VisualBasic;
using Student_Information_System.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Repository
{
    public class TeacherRepo : ITeacherRepo
    {

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        Teacher teacher;


        //constructor
        public TeacherRepo()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-2LFUD90;Database=SISDB;Trusted_Connection=True");
            sqlConnection = new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public int UpdateTeacherInfo(Teacher teacher)
        {
            cmd.CommandText = "UPDATE Teacher SET first_name = @first_name,last_name =@last_name,email =@email,expertise =@expertise WHERE teacher_id = @tid ";
            cmd.Parameters.AddWithValue("@tid", teacher.TeacherID);
            cmd.Parameters.AddWithValue("@first_name", teacher.FirstName);
            cmd.Parameters.AddWithValue("@last_name", teacher.LastName);
            cmd.Parameters.AddWithValue("@email", teacher.Email);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int updateinfo = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return updateinfo;


        }



        public Teacher DisplayTeacherInfo(Teacher teacher) 
        {
            cmd.CommandText = "select * from Teacher where teacher_id = @teacher_id";
            cmd.Parameters.AddWithValue("@teacher_id", teacher.TeacherID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Teacher teach = new Teacher();
            while (reader.Read())
            {
                teach.TeacherID = (int)(reader["teacher_id"]);
                teach.FirstName = (string)reader["first_name"];
                teach.LastName = (string)reader["last_name"];
                teach.Email = (string)reader["email"];
            }
            sqlConnection.Close();
            return teach;

        }



        public List<Course> GetAssignedCourses(int teacherId)
        {
            List<Course> courses = new List<Course>();
            cmd.CommandText = "SELECT c.course_id, c.course_name, c.credits FROM Courses c JOIN Teacher t ON c.teacher_id = t.teacher_id WHERE t.teacher_id = @tid";
            cmd.Parameters.AddWithValue("@tid", teacherId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course course = new Course();
                course.courseID= (int)reader["course_id"];
                course.courseName = (string)reader["course_name"];
                course.courseCode = (int)reader["credits"];
                courses.Add(course);
            }
            sqlConnection.Close();
            return courses;
        }

        public void UpdateTeacher()
        {
            throw new NotImplementedException();
        }
    }
}
