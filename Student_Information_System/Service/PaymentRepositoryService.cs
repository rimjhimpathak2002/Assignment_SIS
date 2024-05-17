using Student_Information_System.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Service
{

    public class PaymentRepositoryService
    {
        readonly IPaymentRepository _paymentrepo;

        public PaymentRepositoryService()
        {
            _paymentrepo = new PaymentRepository();
        }

        public void GetStudent() 
        {
            Console.WriteLine(" ------------------- Welcome to Payment Department --------------------");
            Console.WriteLine("----------- Enter details : ");
            Console.WriteLine("Payment Id");
            int paymentId = int.Parse(Console.ReadLine());
            Console.WriteLine(_paymentrepo.GetStudent(paymentId));

        }


        public void GetPaymentAmount() 
        {

            Console.WriteLine("------------------ Welcome to Payment Department---------------------");
            Console.WriteLine("Enter details : ");
            Console.WriteLine("Payment Id");
            int paymentId = int.Parse(Console.ReadLine());

            // Retrieve payment amount
            decimal paymentAmount = _paymentrepo.GetPaymentAmount(paymentId);
            if (paymentAmount > 0)
            {
                Console.WriteLine("Payment amount for ID " + paymentId + ": " + paymentAmount);
            }
        }

        public void GetPaymentDate() 
        {
            Console.WriteLine("----------------- Welcome To Payment Department -------------------");
            Console.WriteLine("Enter details : ");
            Console.WriteLine("Payment Id");
            int paymentId = int.Parse(Console.ReadLine());

            decimal paymentAmount = _paymentrepo.GetPaymentAmount(paymentId);
            DateTime paymentDate = _paymentrepo.GetPaymentDate(paymentId);
            if (paymentDate != null)
            {
                Console.WriteLine("Payment date for given ID " + paymentId + ": " + "Payment Amount " + ": " + paymentAmount + "Payment Amount " + ": " + paymentDate.ToString("yyyy-MM-dd"));
            }


        }
    }
}
