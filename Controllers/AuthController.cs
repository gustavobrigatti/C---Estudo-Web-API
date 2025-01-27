using Estudo_1___Web_API.Application.Services;
using Estudo_1___Web_API.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_1___Web_API.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if(username == "Gustavo" &&  password == "123")
            {
                var token = TokenService.GenerateToken(new Employee());
                return Ok(token);
            }

            return BadRequest("username or password invalid!");
        }
    }
}
