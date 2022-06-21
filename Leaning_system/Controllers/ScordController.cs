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
        [HttpGet("{STT}")]
        public ActionResult GetPower(int STT)
        {
            var st = _isCord.Get(STT);
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
        public ActionResult Delete(int STT)
        {
            if (_isCord.Delete(STT))
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
