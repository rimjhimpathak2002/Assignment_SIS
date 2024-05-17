using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
     public class Payment
    {
        public int PaymentID { get; set; }
        public int StudentID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        
        //Constructor
        public Payment(int paymentID, int studentID, decimal amount, DateTime paymentDate)
        {
            PaymentID = paymentID;
            StudentID = studentID;
            Amount = amount;
            PaymentDate = paymentDate;
        }

        public Payment()
        {

        }

        public Student student

        {
            get { return student; } //read only property
            set { student = value; } //write only property
        }

        //public Payment(int studentID, decimal amount, DateTime paymentDate)
        //{
        //    StudentID = studentID;
        //    Amount = amount;
        //    PaymentDate = paymentDate;
        //}

        // Retrieve the student associated with the payment
        //public Student GetStudent()
        //{
        //    // Retrieve student from database
        //    return null;
        //}

        //// Retrieve the payment amount
        //public decimal GetPaymentAmount()
        //{
        //    return Amount;
        //}

        //// Retrieve the payment date
        //public DateTime GetPaymentDate()
        //{
        //    return PaymentDate;
        //}
    }
}
