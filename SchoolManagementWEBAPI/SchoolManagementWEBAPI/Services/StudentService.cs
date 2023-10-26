using SchoolManagementWEBAPI.Models;

namespace SchoolManagementWEBAPI.Services
{
    public class StudentService: IStudentService
    {
        private List<Student> _students = new List<Student>();

        public StudentService()
        {
            _students.Add(new Student { StudentId = 1, Name = "Alice", Age = 16 });
            _students.Add(new Student { StudentId = 2, Name = "Bob", Age = 17 });
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public Student GetStudent(int studentId)
        {

            return _students.FirstOrDefault(s => s.StudentId == studentId);

        }
        public List<Student> GetAllStudents()
        {
            return _students;
        }

    }
}
