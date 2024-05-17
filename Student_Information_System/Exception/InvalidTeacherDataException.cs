using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class InvalidTeacherDataException : ApplicationException   
    {
        public InvalidTeacherDataException() : base("Invalid teacher data.")
        {

        }
    }
}
