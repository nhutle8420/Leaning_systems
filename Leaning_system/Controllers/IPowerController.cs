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

    }
}
