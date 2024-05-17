using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
    public class Student
    {
        //Getter and Setter for Student class Attributes
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public double PhoneNumber { get; set; }

        //Making Constructors 
        public Student(int studentID, string firstName, string lastName, DateTime dateOfBirth, string email, double phoneNumber)
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
        public override string ToString()
        {
            return $"Id:: {StudentID}\t FirstName:: {FirstName} \tLast Name:: {LastName} DOB :: {DateOfBirth} \tEmail:: {Email} \tPhoneNumber:: {PhoneNumber}";
        }
    }
}
