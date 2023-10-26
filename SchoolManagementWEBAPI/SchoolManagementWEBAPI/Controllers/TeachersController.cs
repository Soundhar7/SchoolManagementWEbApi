using Microsoft.AspNetCore.Mvc;
using SchoolManagementWEBAPI.Models;
using SchoolManagementWEBAPI.Services;
using System;
using System.Collections.Generic;

namespace SchoolManagementWEBAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetAllTeachers()
        {
            var teachers = _teacherService.GetAllTeachers();
            return Ok(teachers);
        }

        [HttpGet("{id}")]
        public ActionResult<Teacher> GetTeacher(int id)
        {
            var teacher = _teacherService.GetTeacher(id);
            if (teacher == null)
                return NotFound();

            return Ok(teacher);
        }

        [HttpPost]
        public ActionResult<Teacher> AddTeacher([FromBody] Teacher teacher)
        {
            _teacherService.AddTeacher(teacher);
            return CreatedAtAction("GetTeacher", new { id = teacher.TeacherId }, teacher);
        }
    }
}
