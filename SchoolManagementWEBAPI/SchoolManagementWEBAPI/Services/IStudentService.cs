using SchoolManagementWEBAPI.Models;

namespace SchoolManagementWEBAPI.Services
{
    public interface IStudentService
    {
        Student GetStudent(int studentId);

        List<Student> GetAllStudents();
        void AddStudent(Student student);
    }
}
