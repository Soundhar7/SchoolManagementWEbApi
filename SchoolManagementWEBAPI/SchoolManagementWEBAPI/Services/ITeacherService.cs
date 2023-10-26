using SchoolManagementWEBAPI.Models;

namespace SchoolManagementWEBAPI.Services
{
    public interface ITeacherService
    {
        Teacher GetTeacher(int TeacherId);

        List<Teacher> GetAllTeachers();
        void AddTeacher(Teacher teacher);
    }
}
