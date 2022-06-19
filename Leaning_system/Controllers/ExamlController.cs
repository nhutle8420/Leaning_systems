using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamlController : ControllerBase
    {
        public readonly IExaml _Iexaml;
        public ExamlController(IExaml examl)
        {
            _Iexaml = examl;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var st = _Iexaml.getAll();
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpGet("{Context}")]
        public ActionResult Get(string Context)
        {
            var st = _Iexaml.Get(Context);
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpPost]
        public ActionResult Post(Examl_detial ex)
        {
            _Iexaml.Create(ex);
            return Ok();

        }
        [HttpDelete("{Context}")]
        public ActionResult Delete(string Context)
        {
            _Iexaml.Delete(Context);
            return NoContent();
        }
        [HttpPut]
        public ActionResult Put(Examl_detial ex)
        {
            _Iexaml.Update(ex);
            return NoContent();
        }

    }
}
