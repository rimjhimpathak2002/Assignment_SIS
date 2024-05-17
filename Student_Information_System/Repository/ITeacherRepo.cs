using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System.Repository
{
      public interface ITeacherRepo
    {
        public int UpdateTeacherInfo(Teacher teacher);
        public Teacher DisplayTeacherInfo(Teacher teacher);
        public List<Course> GetAssignedCourses(int TeacherID);
    }
}
