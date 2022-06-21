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
        [HttpGet("{MSSV}")]
        public ActionResult GetPower(int MSSV)
        {
            var st = _istudent.Get(MSSV);
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
        [HttpDelete("{MSSV}")]
        public ActionResult Delete(int MSSV)
        {
            _istudent.Delete(MSSV);
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
