using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Repository
{
    public interface IEnrollmentRepository
    {
        string GetStudent(Enrollment enroll);
        string GetCourse(Enrollment enrollment);
    }
}
