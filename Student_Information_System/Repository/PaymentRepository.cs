using Student_Information_System.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        public PaymentRepository()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-2LFUD90;Database=SISDB;Trusted_Connection=True");
            sqlConnection = new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public Student GetStudent(int paymentId)
        {
            Student student = new Student();
            cmd.CommandText = "SELECT s.student_id, s.first_name, s.last_name FROM Students s JOIN Payments p ON s.student_id = p.student_id WHERE p.payment_id = @pid";
            cmd.Parameters.AddWithValue("@pid", paymentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                student.StudentID = (int)reader["student_id"];
                student.FirstName = (string)reader["first_name"];
                student.LastName = (string)reader["last_name"];

            }
            sqlConnection.Close();
            return student;
        }

        public decimal GetPaymentAmount(int paymentId)
        {
            // Retrieve payment amount from the database
            cmd.CommandText = "SELECT amount FROM Payments WHERE payment_id = @pid";
            cmd.Parameters.AddWithValue("@pid", paymentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            decimal amount = Convert.ToDecimal(cmd.ExecuteScalar());
            sqlConnection.Close();
            return amount;
        }


        public DateTime GetPaymentDate(int paymentId)
        {
            // Retrieve payment date from the database
            cmd.CommandText = "SELECT payment_date FROM Payments WHERE payment_id = @cid";
            cmd.Parameters.AddWithValue("@cid", paymentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            DateTime paymentDate = (DateTime)cmd.ExecuteScalar();
            sqlConnection.Close();
            return paymentDate;
        }

    

    }
}

