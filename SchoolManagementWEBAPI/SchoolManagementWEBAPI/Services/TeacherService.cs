using SchoolManagementWEBAPI.Models;

namespace SchoolManagementWEBAPI.Services
{
    public class TeacherService : ITeacherService
    {
        private List<Teacher> _teachers= new List<Teacher>();

        public TeacherService() 
        { 
        
          _teachers.Add(new Teacher { TeacherId=1,Name="Kumar",Subject="Maths"});
          _teachers.Add(new Teacher { TeacherId = 2, Name = "Fathi", Subject = "C#" });
        
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public Teacher GetTeacher(int teacherId)
        {
            return _teachers.FirstOrDefault(t => t.TeacherId == teacherId);
        }
        public List<Teacher> GetAllTeachers()
        {
            return _teachers;
        }
    }
}
