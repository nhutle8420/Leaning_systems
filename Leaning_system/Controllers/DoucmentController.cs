using Leaning_system.IRepo.Interface;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoucmentController : ControllerBase
    {
        public readonly IDocument _idocument;
        public DoucmentController(IDocument document)
        {
            _idocument = document;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var t = _idocument.getAll();
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpGet("{MaDC}")]
        public ActionResult GetPower(int MaDC)
        {
            var power = _idocument.Get(MaDC);
            if (power == null)
            {
                return NotFound();
            }
            return Ok(power);
        }
        [HttpPost]
        public ActionResult PostPower(Documentz documentz)
        {
            _idocument.Create(documentz);
            return Ok();

        }
        [HttpDelete("{MaDC}")]
        public ActionResult Delete(int MaDC)
        {
            _idocument.Delete(MaDC);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutPower(Documentz documentz)
        {
            _idocument.Update(documentz);
            return NoContent();
        }
    }
}
