using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class InvalidEnrollmentDataException : ApplicationException
    {
        public InvalidEnrollmentDataException() : base("Invalid enrollment data.")
        {

        }
    }
}


