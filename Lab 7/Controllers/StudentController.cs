using Lab_7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {  
        private static readonly List<Student> stu =
        [
            new Student{id = 1,name ="Meet"},
             new Student{id = 2,name ="Dhruv"}
        ];

        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(stu);
        }


        [HttpPost]
        public IActionResult PostStudent(Student student)
        {
            stu.Add(student);
            return Ok(student);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Student student = stu.Find(s => s.id == id);

            if(student == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id,Student updatedstudent)
        {
            Student student = stu.Find(s => s.id == id);

            if(student == null)
            {
                return NotFound();
            }

            student.name = updatedstudent.name;
            return Ok(student);
        }
    }
}
