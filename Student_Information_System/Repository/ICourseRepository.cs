namespace Student_Information_System.Repository;


    public interface ICourseRepository
    {

        int AssignTeacher(Teacher teacher, Course course);
        bool UpdateCourseInfo(int CourseCode, string CourseName, string instructor);
        Course DisplayCourseInfo(Course course);
        List<Student> GetEnrollments(Course course);
        string GetTeacher(Course course);

    }


