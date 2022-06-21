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
        [HttpGet("{MaGV}")]
        public ActionResult GetPower(int MaGV)
        {
            var t = _iteacher.Get(MaGV);
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
        [HttpDelete("{MaGV}")]
        public ActionResult Delete(int MaGV)
        {
            _iteacher.Delete(MaGV);
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
