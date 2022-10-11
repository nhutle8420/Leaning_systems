using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudent _istudent;
        public StudentController(IStudent student)
        {
            _istudent = student;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var st = _istudent.getAll();
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpGet("{usernameHV}")]
        public ActionResult GetPower(string usernameHV)
        {
            var st = _istudent.Get(usernameHV);
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpPost]
        public ActionResult PostPower(Student st)
        {
            _istudent.Create(st);
            return Ok();

        }
        [HttpDelete("{usernameHV}")]
        public ActionResult Delete(string usernameHV)
        {
            _istudent.Delete(usernameHV);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutST(Student st)
        {
            _istudent.Update(st);
            return NoContent();
        }
    }
}
