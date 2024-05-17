using Student_Information_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Service
{
    public class EnrollmentRepositoryService
    {
        readonly IEnrollmentRepository enrollrepository;
        public EnrollmentRepositoryService()
        {
            enrollrepository = new EnrollmentRepository();
        }

        public void GetStudent()
        {
            Enrollment enrollment = new Enrollment();
            Console.WriteLine("------------------ Welcome to Enrollment Department -----------------");
            Console.WriteLine("----------------- Enter details --------------------");
            Console.WriteLine("Enrollment Id");
            enrollment.EnrollmentID = int.Parse(Console.ReadLine());
            Console.WriteLine(enrollrepository.GetStudent(enrollment));
        }
        public void GetCourse()
        {
            Enrollment enrollment = new Enrollment();
            Console.WriteLine(" ----------------- Welcome to Enrollment Department -----------------");
            Console.WriteLine("Enter details  : ");
            Console.WriteLine("Enrollment Id");
            enrollment.CourseID = int.Parse(Console.ReadLine());
            Console.WriteLine($"Abc {enrollrepository.GetCourse(enrollment)}");
        }

    }
}
