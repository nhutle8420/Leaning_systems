using Leaning_system.IRepo.Interface;
using Leaning_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leaning_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _iaccount;
        public AccountController(IAccount iaccount) 
         {
            _iaccount = iaccount;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var c = _iaccount.GetAll();
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
        [HttpGet("{UserName}")]
        public ActionResult GetID(string UserName)
        {
            var c = _iaccount.Get(UserName);
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
        [HttpPost]
        public ActionResult Post(Account c)
        {
            _iaccount.Create(c);
            return Ok();
        }
        [HttpDelete("{UserName}")]
        public ActionResult Delete(string UserName)
        {
            if (_iaccount.Delete(UserName))
                return NoContent();
            else
                return BadRequest();
        }
        [HttpPut]
        public ActionResult Put(Account c)
        {

            _iaccount.Update(c);
            return NoContent();
        }
    }
}
