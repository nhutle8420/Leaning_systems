using Leaning_system.IRepo;

using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class IPowerController : ControllerBase
    {
        public readonly IPower _Ipower;
        public IPowerController(IPower ipowerr)
        {
            _Ipower = ipowerr;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var poweri = _Ipower.getAll();
            if (poweri == null)
            {
                return NotFound();
            }
            return Ok(poweri);
        }
        [HttpGet("{id}")]
        public ActionResult GetPower(int id)
        {
            var power = _Ipower.Get(id);
            if (power == null)
            {
                return NotFound();
            }
            return Ok(power);
        }
        [HttpPost]
        public ActionResult PostPower(Power power)
        {
            _Ipower.Create(power);
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _Ipower.Delete(id);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutPower(Power power)
        {
            _Ipower.Update(power);
            return NoContent();
        }

    }
}
