using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class CourseNotFoundException : ApplicationException
    {
        public CourseNotFoundException() : base("Course not found.")
        { 

        }
        public CourseNotFoundException(string message) : base(message)
        {

        }
    }
}
