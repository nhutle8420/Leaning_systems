using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubject _isubject;
        public SubjectsController(ISubject isubject)
        {
            _isubject = isubject;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var s = _isubject.getAll();
            if (s == null)
            {
                return NotFound();
            }
            return Ok(s);
        }
        [HttpGet("{SubjectId}")]
        public ActionResult GetPower(int SubjectId)
        {
            var s = _isubject.Get(SubjectId);
            if (s == null)
            {
                return NotFound();
            }
            return Ok(s);
        }
        [HttpPost]
        public ActionResult PostPower(Subjects s)
        {
            _isubject.Create(s);
            return Ok();

        }
        [HttpDelete("{SubjectId}")]
        public ActionResult Delete(int SubjectId)
        {
            _isubject.Delete(SubjectId);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutPower(Subjects s)
        {
            _isubject.Update(s);
            return NoContent();
        }
    }
}
