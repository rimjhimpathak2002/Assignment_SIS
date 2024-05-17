using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Repository
{
    public interface IStudentRepo
    {

        int AddStudent(Student student);

        int DeleteStudent(Student student);

        int EnrollInCourse(Student student, Course course);

        int UpdateStudentInfo(Student student);

        int MakePayment(Student student, Payment payment);

        Student DisplayStudentInfo(Student student);

        List<Enrollment> GetEnrolledCourses(Student student);

        List<Payment> GetPaymentHistory(Student student);
    }
}
