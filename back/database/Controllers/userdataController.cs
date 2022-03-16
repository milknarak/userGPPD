using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userdataController : ControllerBase
    {

        [HttpGet("userdata")]
        public IActionResult userdata()
        {

            var context = new Context();
            var userdata = context.profile.ToList();
            return Ok(userdata);
        }
    }
}
