using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Models.User;
using SocialMedia.Services.User;

namespace SocialMedia.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
[HttpPost("Register")]
public async Task<IActionResult> RegisterUserAsync([FromBody] UserRegister model)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    var registerResult = await _service.RegisterUserAsync(model);
    if (registerResult)
    {
        return Ok("User was registered.");
    }
    return BadRequest("User could not be registered.");
        }
    }
}
