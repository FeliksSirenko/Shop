using Microsoft.AspNetCore.Mvc;
using Shop.WebUI.ViewModels;

namespace Shop.WebUI.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("api/v1/user")]
        public IActionResult CreateUser([FromBody] FormViewModel form)
        {
            string message = "";
            return Ok(new { message });
        }
    }
}
