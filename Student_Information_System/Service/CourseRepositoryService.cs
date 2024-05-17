using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Information_System.Exception;
using Student_Information_System.Repository;
//using Student_Information_System.Exception;
namespace Student_Information_System.Service
{
    public class CourseRepositoryService

    {
        readonly ICourseRepository courserepository;

        public CourseRepositoryService()
        {
            courserepository = new CourseRepository();
        }



        public void AssignTeacher()
        {
            Course course = new Course();
            try
            {
                Teacher teacher = new Teacher();
                //Course course = new Course();
                Console.WriteLine("----------- Welcome To Teacher Assignment Department -------------");
                Console.WriteLine("-------- Enter below details ------------- ");
                Console.WriteLine("Teacher Id");
                teacher.TeacherID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Course Id");
                course.courseID = Convert.ToInt32(Console.ReadLine());
                courserepository.AssignTeacher(teacher, course);
            }
            catch (CourseNotFoundException ex)
            {
                Console.WriteLine($"CourseNotFound {ex.Message}");
            }
        }

        public void DisplayCourseInfo()
        {
            Course course = new Course();
            Console.WriteLine("--------------- Welcome To Course Department ------------------");
            Console.WriteLine("--------- Enter below details --------------");
            Console.WriteLine("Course Id");
            course.courseID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(courserepository.DisplayCourseInfo(course));
        }

        public void GetEnrollments()
        {
            Course course = new Course();
            Console.WriteLine("------------------- Welcome To Course Department -------------- ");
            Console.WriteLine("--------------- Enter below details ----------------- ");
            Console.WriteLine("Course Id");
            course.courseID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(courserepository.GetEnrollments(course));
        }


        public void GetTeacher()
        {
            Course course = new Course();
            Console.WriteLine("------------- Welcome To Course Department -----------------");
            Console.WriteLine("---------------- Enter below details ----------------");
            Console.WriteLine("Course Id");
            course.courseID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(courserepository.GetTeacher(course));

        }


    }
}
    

