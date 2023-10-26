using Microsoft.AspNetCore.Mvc;
using SchoolManagementWEBAPI.Models;
using SchoolManagementWEBAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagementWEBAPI.Controllers
{

    


    [Route("/api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;

        }
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }


        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _studentService.GetStudent(id);
            if (student == null)
            {
                return NotFound();

            }
            return Ok(student);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public ActionResult <Student>AddStudent([FromBody] Student students)
        {
            _studentService.AddStudent(students);
            return CreatedAtAction("GetStudent",new {id=students.StudentId},students);
        }

        //        // PUT api/<StudentsController>/5
        //        [HttpPut("{id}")]
        //        public void Put(int id, [FromBody] string value)
        //        {
        //        }

        //        // DELETE api/<StudentsController>/5
        //        [HttpDelete("{id}")]
        //        public void Delete(int id)
        //        {
    }
   }
//}
