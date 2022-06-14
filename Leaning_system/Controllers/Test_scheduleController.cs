using Leaning_system.IRepo;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test_scheduleController : ControllerBase
    {
        public readonly ITest_schedule _ische;
        public Test_scheduleController(ITest_schedule test)
        {
            _ische = test;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var t = _ische.getAll();
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpGet("{Topic}")]
        public ActionResult GetPower(string Topic)
        {
            var st = _ische.Get(Topic);
            if (st == null)
            {
                return NotFound();
            }
            return Ok(st);
        }
        [HttpPost]
        public ActionResult PostPower(test_schedule st)
        {
            _ische.Create(st);
            return Ok();

        }
        [HttpDelete("{Topic}")]
        public ActionResult Delete(string Topic)
        {
            _ische.Delete(Topic);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutST(test_schedule st)
        {
            _ische.Update(st);
            return NoContent();
        }
    }
}
