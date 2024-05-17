﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Exception
{
    internal class StudentNotFoundException : ApplicationException
    {
        public StudentNotFoundException() : base("Student not found.")
        {

        }
    }
}
