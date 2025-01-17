﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS2
{
    internal class Students
    {
        public class Student
        {
            //Getter and Setter for Student class Attributes
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            //Making Constructors 
            public Student(int studentID, string firstName, string lastName, DateTime dateOfBirth, string email, string phoneNumber)
            {
                StudentID = studentID;
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                Email = email;
                PhoneNumber = phoneNumber;
            }

            public Student()
            {

            }

        }
    }
}
