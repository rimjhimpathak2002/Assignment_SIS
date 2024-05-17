using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class PaymentValidationException : ApplicationException
    {
        public PaymentValidationException() : base("Payment validation failed.")
        {

        }
    }
}
