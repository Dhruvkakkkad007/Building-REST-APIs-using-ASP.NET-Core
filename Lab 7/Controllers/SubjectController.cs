using Lab_7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private static readonly List<Subject> sub =
        [
            new Subject{Id = 1,Subject_Name = ".Net"},
            new Subject{Id = 2, Subject_Name = "DAA"}
        ];


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(sub);
        }

        [HttpPut("{Id}")]

        public IActionResult UpdateSubject(int Id, Subject updatedSuject)
        {
            Subject s = sub.FirstOrDefault(s => s.Id == Id);

            if (s == null)
            {
                return BadRequest();
            }

            s.Subject_Name = updatedSuject.Subject_Name;
            return Ok(s);
        }

        [HttpDelete("{Id}")]

        public IActionResult DeleteSubject(int Id)
        {
            Subject s = sub.FirstOrDefault(s => s.Id == Id);

            if (s == null)
            {
                return BadRequest();
            }
            sub.Remove(s);
            return Ok("Deleted");
        }

        [HttpPost]
        public IActionResult AddSubject(Subject s)
        {
            s.Id = sub.Count == 0 ? 1 : sub.Max(submax => submax.Id) + 1;

            sub.Add(s);

            return Ok("Added");

        }

        
    }


}
