namespace SIS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // SIS_Application sis_app = new SIS_Application();
            //sis_app.Run();

          //  IStudentRepo stdRepository = new StudentRepo();

            //List<Course> allCourses = courseRepository.DisplayCourseInfo();
            List<Students> allstd = stdRepository.DisplayStudentInfo();
            foreach (Students item in allstd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
