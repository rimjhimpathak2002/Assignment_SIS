using Student_Information_System.Utility;
using System.Data.SqlClient;
namespace Student_Information_System.Repository
{
    public class StudentRepo : IStudentRepo
    {
        Student stud1 = new Student();
     


        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        //constructor
        public StudentRepo()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-2LFUD90;Database=SISDB;Trusted_Connection=True");
            sqlConnection = new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public int AddStudent(Student student) 

        {
            cmd.CommandText = "INSERT INTO Students VALUES(@first_name,@last_name,@date_of_birth,@email,@phone_number)";
            cmd.Parameters.AddWithValue("@first_name", student.FirstName);
            cmd.Parameters.AddWithValue("@last_name", student.LastName);
            cmd.Parameters.AddWithValue("@date_of_birth", student.DateOfBirth);
            cmd.Parameters.AddWithValue("@email", student.Email);
            cmd.Parameters.AddWithValue("@phone_number", student.PhoneNumber);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int addStudentStatus = cmd.ExecuteNonQuery();

            if (addStudentStatus > 0)
                Console.WriteLine("Student Addititon Sucessful");

            sqlConnection.Close();
            return addStudentStatus;

        }


        public int DeleteStudent(Student student) 
        {

            cmd.CommandText = "DELETE FROM Students where student_id = @student_id";
            cmd.Parameters.AddWithValue("@student_id", student.StudentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int deleteStudentStatus = cmd.ExecuteNonQuery();
            if (deleteStudentStatus > 0)
                Console.WriteLine("Student Deletion Sucessful");
            sqlConnection.Close();
            return deleteStudentStatus;

        }

        public int EnrollInCourse(Student student, Course course)  
        {

            cmd.CommandText = "INSERT INTO Enrollments VALUES(@course_name,@student_id,@course_id,@enrollment_date)";
            cmd.Parameters.AddWithValue("@course_name", course.courseName);
            cmd.Parameters.AddWithValue("@student_id", stud1.StudentID);
            cmd.Parameters.AddWithValue("@course_id", course.courseID);
            cmd.Parameters.AddWithValue("@enrollment_date", DateTime.Now);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int addProduct = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return addProduct;

        }

        public int MakePayment(Student student, Payment payment) 
        {
         
            cmd.CommandText = "INSERT INTO Payments VALUES(@student_id,@amount,@payment_date)";
            cmd.Parameters.AddWithValue("@student_id", stud1.StudentID);
            cmd.Parameters.AddWithValue("@amount", payment.Amount);
            cmd.Parameters.AddWithValue("@payment_date", DateTime.Now);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int addPaymentStatus = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return addPaymentStatus;
        }

        public Student DisplayStudentInfo(Student student)
        {

            cmd.CommandText = "SELECT * FROM Students where student_id = @student_id";
            cmd.Parameters.AddWithValue("@student_id", student.StudentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                student.StudentID = (int)reader["student_id"];
                student.FirstName = (string)reader["first_name"];
                student.LastName = (string)reader["last_name"];
                student.DateOfBirth= (DateTime)reader["date_of_birth"];
                student.Email = (string)reader["email"];
                student.PhoneNumber = Convert.ToDouble(reader["phone_number"]);


            }
            sqlConnection.Close();
            return student;
        }

        public int UpdateStudentInfo(Student student) 
        {

            cmd.CommandText = "UPDATE Students SET first_name = @first_name,last_name =@last_name,date_of_birth =@date_of_birth,email =@email,phone_number=@phone_number  WHERE student_id = @student_id ";
            cmd.Parameters.AddWithValue("@first_name", student.FirstName);
            cmd.Parameters.AddWithValue("@last_name", student.LastName);
            cmd.Parameters.AddWithValue("@date_of_birth", student.DateOfBirth);
            cmd.Parameters.AddWithValue("@email", student.Email);
            cmd.Parameters.AddWithValue("@phone_number", student.PhoneNumber); 
            cmd.Parameters.AddWithValue("@student_id", student.StudentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int updateinfo = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return updateinfo;


        }
        public List<Payment> GetPaymentHistory(Student student) 
        {

            List<Payment> pay = new List<Payment>();
            cmd.CommandText = "SELECT * FROM Payments where student_id = @student_id ";
            cmd.Parameters.AddWithValue("@student_id", student.StudentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Payment payments = new Payment();
                payments.PaymentID = (int)reader["payment_id"];
                payments.StudentID = (int)reader["student_id"];
                payments.Amount = (int)reader["amount"];
                payments.PaymentDate = (DateTime)reader["payment_date"];
                pay.Add(payments);

            }
            sqlConnection.Close();
            return pay;

        }


        public List<Enrollment> GetEnrolledCourses(Student student) 
        {
            List<Enrollment> enroll = new List<Enrollment>();
            cmd.CommandText = "SELECT * FROM Enrollments where student_id = @student_id ";
            cmd.Parameters.AddWithValue("@student_id", student.StudentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Enrollment enrol = new Enrollment();
                enrol.EnrollmentID = (int)reader["enrollment_id"];
                enrol.CourseID = (int)reader["course_id"];
                enrol.EnrollmentDate = (DateTime)reader["enrollment_date"];
                enroll.Add(enrol);
            }
            sqlConnection.Close();
            return enroll;
        }

        
    }






   

}

