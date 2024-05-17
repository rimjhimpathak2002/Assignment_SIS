using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    public class TeacherNotFoundException : ApplicationException
    {
        public TeacherNotFoundException() : base("Teacher not found.")
        {  

        }
    }
}
