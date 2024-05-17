using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class InvalidStudentDataException : ApplicationException
    {

        public InvalidStudentDataException() : base("Invalid student data.")
        {

        }
        public InvalidStudentDataException(string message) : base(message)
        {

        }

    }
}
