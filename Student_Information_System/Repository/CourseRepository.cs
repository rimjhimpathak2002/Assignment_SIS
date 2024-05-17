using Student_Information_System.Utility;
using System;
using System.Data.SqlClient;


namespace Student_Information_System.Repository
{
    public class CourseRepository : ICourseRepository
    {
        Course course;
        Student student;

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public CourseRepository()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-2LFUD90;Database=SISDB;Trusted_Connection=True");
            cmd = new SqlCommand();

        }

        public int AssignTeacher(Teacher teacher, Course course) 
        {
            cmd.CommandText = "UPDATE Courses SET teacher_id = @tid WHERE course_id = @cid ";
            cmd.Parameters.AddWithValue("@tid", teacher.TeacherID);
            cmd.Parameters.AddWithValue("@cid", course.courseID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int returnLeaseStatus = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return returnLeaseStatus;  
            
        }

        public Course DisplayCourseInfo(Course course)  
        {

            cmd.CommandText = "SELECT course_id,course_name,credits,concat(t.first_name + ' ' , t.last_name) as Instructor_Name FROM Courses c JOIN Teacher t ON c.teacher_id = t.teacher_id WHERE course_id = @cid ";
            cmd.Parameters.AddWithValue("@cid", course.courseID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                course.courseID = (int)reader["course_id"];
                course.courseName = (string)reader["course_name"];
                course.instructorName = (string)reader["Instructor_Name"];
            }
            sqlConnection.Close();
            return course;

        }

        public List<Student> GetEnrollments(Course course)
        {
            List<Student> students = new List<Student>();
            cmd.CommandText = "SELECT first_name,last_name,date_of_birth,email,phone_number FROM Students s JOIN Enrollments e ON e.student_id = s.student_id WHERE course_id = @cid";
            cmd.Parameters.AddWithValue("@cid", course.courseID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.FirstName = (string)reader["first_name"];
                student.LastName = (string)reader["last_name"];
                student.DateOfBirth = (DateTime)reader["date_of_birth"]; 
                student.Email = (string)reader["email"];
                student.PhoneNumber = Convert.ToDouble(reader["phone_number"]);
                students.Add(student);
            }
            sqlConnection.Close();
            return students;
        }

        public string GetTeacher(Course course) 
        {
            cmd.CommandText = "select concat(t.first_name + ' ' , t.last_name) as Teacher_Name from Teacher t JOIN Courses c ON c.teacher_id = t.teacher_id WHERE course_id = @cid";
            cmd.Parameters.AddWithValue("@cid", course.courseID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            string TeacherName = Convert.ToString(cmd.ExecuteScalar()); ;
            sqlConnection.Close();
            return TeacherName;
        }

        public bool UpdateCourseInfo(int CourseCode, string CourseName, string instructor) 
        {

            cmd.CommandText = "UPDATE Courses SET course_code = @courseCode,course_Name = @courseName, ";
            cmd.Parameters.AddWithValue("@cid", course.courseID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();

            sqlConnection.Close();
            return true;

        }
    }
}

    

