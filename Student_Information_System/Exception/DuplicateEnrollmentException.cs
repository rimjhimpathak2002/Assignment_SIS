using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class DuplicateEnrollmentException : ApplicationException
    {
        public DuplicateEnrollmentException() : base("Duplicate enrollment.")
        {

        }
    }
}
