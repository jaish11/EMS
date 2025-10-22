using EMS.Application.Services;
using EMS.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult GetAllstudents()
        {
            return Ok(_studentService.GetAllStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetstudentById(int id) { 
            return Ok(_studentService.GetStudentById(id));
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentDTO dto)
        {
            _studentService.AddStudent(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStudent([FromBody] StudentDTO dto)
        {
            _studentService.UpdateStudent(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}
