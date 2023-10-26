using SchoolManagementWEBAPI.Models;

namespace SchoolManagementWEBAPI.Services
{
    public interface ISchoolService
    {

        void EnrollStudent(Student student);

        void RegisterTeacher(Teacher teacher);
    }
}
