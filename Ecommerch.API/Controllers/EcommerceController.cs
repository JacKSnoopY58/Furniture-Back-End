using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerch.API.Controllers
{
    [ApiController]
    [Route("test")]
    public class EcommerceController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult GetPublicData()
        {
            return Ok(new { message = "This is public data." });
        }

        [Authorize]
        [HttpGet("secure")]
        public IActionResult GetSecureData()
        {
            return Ok(new { message = "This is protected data, only for authenticated users." });
        }
    }
}
