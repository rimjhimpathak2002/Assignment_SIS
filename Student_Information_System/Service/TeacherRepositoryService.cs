using Student_Information_System.Exception;
using Student_Information_System.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Service
{
    public class TeacherRepositoryService
    {
        readonly ITeacherRepo _teacherrepository;

        public TeacherRepositoryService()
        {
            _teacherrepository = new TeacherRepo();
        }

        public void UpdateTeacherInfo()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("------------------ Welcome to Teacher Detail Updation --------------");
            Console.WriteLine("Teacher ID");
            teacher.TeacherID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Name");
            teacher.FirstName = (Console.ReadLine());
            Console.WriteLine("Last Name");
            teacher.LastName = (Console.ReadLine());
            Console.WriteLine("Email");
            teacher.Email = (Console.ReadLine());

            _teacherrepository.UpdateTeacherInfo(teacher);
        }


        public void DisplayTeacherInfo()
        { 
            Console.WriteLine("-------------------- Welcome To Teacher Management -----------------");
            Teacher teach1 = new Teacher();
            Console.WriteLine("Enter Teacher ID : ");
            teach1.TeacherID = Convert.ToInt32(Console.ReadLine());

            // Call service method to retrieve teachers
            Console.WriteLine(_teacherrepository.DisplayTeacherInfo(teach1));
        }

        public void GetAssignedCourses()
        {
            Console.WriteLine("----------------------- Welcome To Teacher Course Management --------------------------------- ");
            Teacher teacher = new Teacher();
            Console.WriteLine("Enter Teacher Id");
            teacher.TeacherID = Convert.ToInt32(Console.ReadLine());

            List<Course> courses = _teacherrepository.GetAssignedCourses(teacher.TeacherID);

            if (courses.Count > 0)
            {
                Console.WriteLine("--------------- List of Courses with Teacher ID: " + teacher.TeacherID );
                foreach (Course course in courses)
                {
                    Console.WriteLine($"{course.courseID} - {course.courseName} ({course.courseCode})"); 
                }
            }
            else
            {
                Console.WriteLine("No courses found with teacher ID: " + teacher.TeacherID);
            }
        }

    }
}
