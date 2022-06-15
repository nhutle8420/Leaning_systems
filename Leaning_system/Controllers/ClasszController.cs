using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasszController : ControllerBase
    {
        private readonly IClass _iclass;
        public ClasszController(IClass iclass)
        {
            _iclass = iclass;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var l = _iclass.getAll();
            if (l == null)
            {
                return NotFound();
            }
            return Ok(l);
        }
        [HttpGet("{id}")]
        public ActionResult GetPower(int id)
        {
            var l = _iclass.Get(id);
            if (l == null)
            {
                return NotFound();
            }
            return Ok(l);
        }
        [HttpPost]
        public ActionResult PostPower(Class iclass)
        {
            _iclass.Create(iclass);
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _iclass.Delete(id);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutClass(Class iclass)
        {
            _iclass.Update(iclass);
            return NoContent();
        }

    }
}
