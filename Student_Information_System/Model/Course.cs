using System;
namespace Student_Information_System
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseName { get; set; }
        public int courseCode { get; set; }
        public string instructorName{ get; set; }

        //Making Constructors
        public Course(int CourseID, string CourseName, int CourseCode, string Instructor_Name)
        {
            courseID = CourseID;
            courseName = CourseName;
            courseCode = CourseCode;
            instructorName = Instructor_Name;
        }

        public Course()
        {

        }

        public override string ToString()
        {
            return $"Id::{courseID}\t Name::{courseName}\tPrice::{courseCode}\tCategoryId::{instructorName}";
        }
    }
}
