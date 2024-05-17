using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class InvalidCourseDataException : ApplicationException
    {
        public InvalidCourseDataException() : base("Invalid course data.")
        {

        }
    }
}
