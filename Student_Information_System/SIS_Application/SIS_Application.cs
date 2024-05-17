using Student_Information_System.Repository;
using Student_Information_System.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
    public class SIS_Application
    {
        readonly StudentRepositoryService _studentrepo;
        readonly EnrollmentRepositoryService _enrollmentrepo;
        readonly PaymentRepositoryService _paymentrepo;
        readonly TeacherRepositoryService _teacherrepo;
        readonly CourseRepositoryService _courserepo;


        public SIS_Application()
        {
            _studentrepo = new StudentRepositoryService();
            _enrollmentrepo = new EnrollmentRepositoryService();
            _paymentrepo = new PaymentRepositoryService();
            _courserepo = new CourseRepositoryService();
            _teacherrepo = new TeacherRepositoryService();
        }
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("----------------  WELCOME TO STUDENT INFORMATION SYSTEM ------------------");
                Console.WriteLine("ENTER 1 : STUDENT SERVICES");
                Console.WriteLine("ENTER 2 : COURSES SERVICES");
                Console.WriteLine("ENTER 3 : TEACHER  SERVICES");
                Console.WriteLine("ENTER 4 : ENROLLMENT SERVICES");
                Console.WriteLine("ENTER 5 : PAYMENT SERVICES");
                Console.WriteLine("ENTER 6 : TO EXIT");
                Console.WriteLine("-------------------- ENTER YOUR CHOICE ------------");
                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        ManageStudents();
                        break;
                    case 2:
                        ManageCourses();
                        break;

                    case 3:
                        ManageTeacher();
                        break;

                    case 4:
                        ManageEnrollment();
                        break;
                    case 5:
                        ManagePayment();
                        break;

                    case 6:
                        exit = true;

                        Console.WriteLine("exited");
                        break;

                    default:
                        Console.WriteLine("ENTER CORRECT INPUT ");
                        break;
                }

            }



            }
            private void ManageStudents()
            {
                Console.WriteLine("----------------- WELCOME TO STUDENT SERVICE SECTION ---------------------");
                Console.WriteLine("ENTER 1 : TO ENROLL IN COURSE");
                Console.WriteLine("ENTER 2 : TO UPDATE STUDENT INFORMATION");

                Console.WriteLine("ENTER 3 : TO MAKE PAYMENT");

                Console.WriteLine("ENTER 4 : TO DISPLAY STUDENT INFORMATION");
                Console.WriteLine("ENTER 5 : TO GET ENROLLED COURSES");
                Console.WriteLine("ENTER 6 : TO GET PAYMENT HISTORY ");


                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _studentrepo.EnrollInCourse();
                        break;
                    case 2:
                        _studentrepo.UpdateStudentInfo();
                        break;
                    case 3:
                        _studentrepo.MakePayment();
                        break;
                    case 4:
                        _studentrepo.DisplayStudentInfo();
                        break;
                    case 5:
                        _studentrepo.GetEnrolledCourses();
                        break;
                    case 6:
                        _studentrepo.GetPaymentHistory();
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT DETAILS ");
                        break;
                }
            }

            private void ManageCourses()
            {
                Console.WriteLine("**********COURSES SERVICE MENU**********");
                Console.WriteLine("PRESS 1 TO ASSIGN TEACHER");
                Console.WriteLine("PRESS 2 TO UPDATE COURSE INFO");

                Console.WriteLine("PRESS 3 DISPLAY COURSE INFO");

                Console.WriteLine("PRESS 4 TO GET ENROLLMENTS");

                Console.WriteLine("PRESS 5 TO GET TEACHER DETAILS ");

                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _courserepo.AssignTeacher();
                        break;
                    case 2:
                        _courserepo.AssignTeacher();
                        break;
                    case 3:
                        _courserepo.DisplayCourseInfo();
                        break;
                    case 4:
                        _courserepo.GetEnrollments();
                        break;
                    case 5:
                        _courserepo.GetTeacher();
                        break;

                    default:
                        Console.WriteLine("HELLO USER !! PLEASE ENTER CORRECT DETAILS ");
                        break;
                }



            }
            private void ManageTeacher()
            {
                Console.WriteLine("------------------- TEACHER SERVICE MENU ----------------------");
                Console.WriteLine("ENTER 1 : TO UPDATE TEACHER INFORMATION");


                Console.WriteLine("ENTER 2 : TO DISPLAY TEACHER INFORMATION");

                Console.WriteLine("ENTER 3 : TO GET ASSIGNED COURSES");



                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _teacherrepo.UpdateTeacherInfo();
                        break;
                    case 2:
                        _teacherrepo.DisplayTeacherInfo();
                        break;
                    case 3:
                        _teacherrepo.GetAssignedCourses();
                        break;


                    default:
                        Console.WriteLine("HELLO USER !!! PLEASE ENTER CORRECT DETAILS ");
                        break;
                }



            }
            private void ManageEnrollment()
            {
                Console.WriteLine("----------------- ENROLLMENT SERVICE MENU -------------- ");
                Console.WriteLine("ENTER 1 : TO GET STUDENT ASSOCIATED WITH ENROLLMENT");


                Console.WriteLine("ENTER 2 : TO GET ENROLLED COURSE");




                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _enrollmentrepo.GetStudent();
                        break;
                    case 2:
                        _enrollmentrepo.GetCourse();
                        break;



                    default:
                        Console.WriteLine("HELLO USER !!!! PLEASE ENTER CORRECT DETAILS ");
                        break;
                }



            }
            private void ManagePayment()
            {
                Console.WriteLine("------------------- WELCOME TO PAYMENT SERVICE MENU ----------------");
                Console.WriteLine("ENTER 1 : TO GET STUDENT ASSOCIATED WITH PAYMENT");
                Console.WriteLine("ENTER 2 : TO GET PAYMENT AMOUNT");
                Console.WriteLine("ENTER 3 : TO GET PAYMENT DATE");




                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _paymentrepo.GetStudent();
                        break;
                    case 2:
                        _paymentrepo.GetPaymentAmount();
                        break;
                    case 3:
                        _paymentrepo.GetPaymentDate();
                        break;



                    default:
                        Console.WriteLine("HELLO USER !! PLEASE ENTER CORRECT DETAILS ");
                        break;
                }



            }
        }

}
