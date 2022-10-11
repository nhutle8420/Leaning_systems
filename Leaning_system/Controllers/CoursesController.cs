using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourse _icourses;
        public CoursesController(ICourse icourses)
        {
            _icourses = icourses;
        }
        [HttpGet]
          public ActionResult Get()
        {
            var c = _icourses.getAll();
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
        [HttpGet("{course}")]
        public ActionResult GetID(int course)
        {
            var c = _icourses.Get(course);
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
        [HttpPost]
        public ActionResult Post(Courses c)
        {
            _icourses.Create(c);
            return Ok();

        }
        [HttpDelete("{course}")]
        public ActionResult Delete(int course)
        {
            if (_icourses.Delete(course))
                return NoContent();
            else
                return BadRequest();
        }
        
     
            
            [HttpPut]
        public ActionResult Put(Courses c)
        {

            _icourses.Update(c);
            return NoContent();
        }
    }
}
