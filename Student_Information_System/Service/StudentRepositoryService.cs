using Student_Information_System.Exception;
using Student_Information_System.Repository;
using System;
using System.Collections.Generic;
//using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Service
{
    public class StudentRepositoryService
    {
        readonly IStudentRepo _studentrepo;


        public StudentRepositoryService()
        {
            _studentrepo = new StudentRepo();
        }

        public void AddStudent()  
        {
            Student student = new Student();
            Console.WriteLine("------------------- Welcome To Student Department---------------------");
            Console.WriteLine("------------------  Fill required details of the Student below --------------");
            Console.WriteLine(" First Name");
            student.FirstName = Console.ReadLine();
            Console.WriteLine(" Last Name");
            student.LastName = Console.ReadLine();
            Console.WriteLine(" Date of Birth (format: dd-MM-yyyy)");
            student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(" Email ");
            student.Email = Console.ReadLine();
            if (!student.Email.Contains("@"))
            {
                throw new InvalidStudentDataException("Invalid email format. Please use the format: abc@example.com");
            }

            Console.WriteLine(" Phone Number ");
            student.PhoneNumber = int.Parse(Console.ReadLine());
            //if (student.PhoneNumber.Length > 10)
            //{
            //    throw new InvalidStudentDataException("Phone Number Contains more than 10 digits");
            //}


            _studentrepo.AddStudent(student);
        }


        public void DeleteStudent()
        {
            Student student = new Student();
            Console.WriteLine("---------------------- Welcome to Student Deletion Department --------------");
            Console.WriteLine("---------------- Enter details of the Student below -------------");
            Console.WriteLine("Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());
            _studentrepo.DeleteStudent(student);

        }


        public void EnrollInCourse()
        {
            Student student = new Student();
            Course course = new Course();
            Console.WriteLine(" -------------------- Welcome To Course Enrollment Department -------------------");
            Console.WriteLine("---------------- Enter details of the Student below -----------------");
            Console.WriteLine("Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Course Id");
            course.courseID = Convert.ToInt32(Console.ReadLine());

            _studentrepo.EnrollInCourse(student, course);

        }



        public void MakePayment()
        {
            Student student = new Student();
            Payment pay = new Payment();
            Console.WriteLine(" --------------------- Welcome To Payments Department ---------------------");
            Console.WriteLine("------------------- Fill below details ------------------- ");
            Console.WriteLine("Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amount");
            pay.Amount = Convert.ToInt32(Console.ReadLine());

            _studentrepo.MakePayment(student, pay);

        }

        public void DisplayStudentInfo()
        {
            Student student = new Student();
            Console.WriteLine("------------------------ Welcome To Student Information Department----------------------------");
            Console.WriteLine("-------------------- Enter details of the Student below ----------------------------");
            Console.WriteLine("Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(_studentrepo.DisplayStudentInfo(student));

        }

        public void UpdateStudentInfo()
        {
            Student student = new Student();
            Console.WriteLine("------------------------------- Welcome To Student Updatation Department--------------------------");
            Console.WriteLine("--------------------- Fill details of the Student below ------------------------- ");
            Console.WriteLine(" Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" First Name");
            student.FirstName = Console.ReadLine();
            Console.WriteLine(" Last Name");
            student.LastName = Console.ReadLine();
            Console.WriteLine(" Date of Birth (format: dd-MM-yyyy)");
            student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(" Email ");
            student.Email = (Console.ReadLine());
            if (!student.Email.Contains("@"))
            {
                throw new InvalidStudentDataException("Invalid email format!!! Please use the format: abc@example.com");
            }

            Console.WriteLine(" Phone Number ");
            student.PhoneNumber = int.Parse(Console.ReadLine());
            //if (student.PhoneNumber.Length > 10)
            //{
            //    throw new InvalidStudentDataException("Phone Number Contains more than 10 digits");
            //}


            _studentrepo.UpdateStudentInfo(student);
        }

        public void GetPaymentHistory()
        {
            Student student = new Student();
            Console.WriteLine("---------------------- Welcome To Payments Department ------------------------------- ");
            Console.WriteLine(" -------------------- Fill below details of student--------------------------- ");
            Console.WriteLine("Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());
            List<Payment> stu = _studentrepo.GetPaymentHistory(student); ;
            foreach (Payment item in stu)
            {
                Console.WriteLine(item);
            }
        }


        public void GetEnrolledCourses()
        {
            Student student = new Student();
            Console.WriteLine("---------------------- Welcome To Enrollments Department ----------------------");
            Console.WriteLine(" --------------------- Fill below details of Student------------------ ");
            Console.WriteLine("Student Id");
            student.StudentID = Convert.ToInt32(Console.ReadLine());

            List<Enrollment> stu = _studentrepo.GetEnrolledCourses(student);
            foreach (Enrollment item in stu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
