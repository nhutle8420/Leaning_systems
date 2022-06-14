using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _iteacher;
        public TeacherController(ITeacher iteacher)
        {
            _iteacher = iteacher;
        }
        [HttpGet]
        public ActionResult get()
        {
            var i= _iteacher.getAll();
            return Ok(i);
        }
        [HttpGet("{usernameGV}")]
        public ActionResult GetPower(string usernameGV)
        {
            var t = _iteacher.Get(usernameGV);
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpPost]
        public ActionResult PostTeach(Teacher pt)
        {
            
            _iteacher.Create(pt);
            return Ok();

        }
        [HttpDelete("{usernameGV}")]
        public ActionResult Delete(string usernameGV)
        {
            _iteacher.Delete(usernameGV);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Put(Teacher p)
        {
            _iteacher.Update(p);
            return NoContent();
        }
    }
}
