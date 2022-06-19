using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScordController : ControllerBase
    {
        public readonly IScord _isCord;
        public ScordController(IScord scord)
        {
            _isCord = scord;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var st = _isCord.getAll();
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpGet("{usernameHV}")]
        public ActionResult GetPower(string usernameHV)
        {
            var st = _isCord.Get(usernameHV);
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpPost]
        public ActionResult PostPower(Scord c)
        {
            _isCord.Create(c);
            return Ok();

        }
        [HttpDelete("{usernameHV}")]
        public ActionResult Delete(string usernameHV)
        {
            if (_isCord.Delete(usernameHV))
                return NoContent();
            else
                return BadRequest();
        }
        [HttpPut]
        public ActionResult PutST(Scord s)
        {
            _isCord.Update(s);
            return NoContent();
        }
    }
}
