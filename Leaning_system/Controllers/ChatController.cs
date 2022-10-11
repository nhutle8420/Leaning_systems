using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        public readonly IChat _Ichat;
        public ChatController(IChat ichat)
        {
            _Ichat = ichat;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var c = _Ichat.getAll();
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
        [HttpGet("{ChatId}")]
        public ActionResult GetID(int ChatId)
        {
            var c = _Ichat.Get(ChatId);
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
        [HttpPost]
        public ActionResult Post(Chat c)
        {
            _Ichat.Create(c);
            return Ok();

        }
        [HttpDelete("{ChatId}")]
        public ActionResult Delete(int ChatId)
        {
            if(_Ichat.Delete(ChatId))
                 return NoContent();
            else
                return BadRequest();
        }
        [HttpPut]
        public ActionResult PutPower(Chat c)
        {

            _Ichat.Update(c);
            return NoContent();
        }
    }
}
