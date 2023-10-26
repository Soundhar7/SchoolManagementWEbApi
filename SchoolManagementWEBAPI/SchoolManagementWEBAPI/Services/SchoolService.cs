using SchoolManagementWEBAPI.Models;

namespace SchoolManagementWEBAPI.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;

        public SchoolService(IStudentService studentService, ITeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }

        public void EnrollStudent(Student student)
        {
            _studentService.AddStudent(student);
        }

        public void RegisterTeacher(Teacher teacher)
        {
            _teacherService.AddTeacher(teacher);
        }
    }
}
