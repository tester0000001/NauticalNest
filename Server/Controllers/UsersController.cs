using Microsoft.AspNetCore.Mvc;
using NauticalNest.Server.Models;
using NauticalNest.Server.Services;

namespace NauticalNest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AuthService _authService;
        

        public UsersController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationDto registrationDto)
        {
            // Validate input data
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Check for duplicate username
            var userExists = /*TODO: Database logic to check if user already exists */
            if (userExists) 
                return BadRequest("User already exists");

            _authService.RegisterUser(registrationDto.Username, registrationDto.Password);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto loginDto)
        {
            var user = _authService.LoginUser(loginDto.Username, loginDto.Password);
            if (user == null)
                return Unauthorized("Invalid username or password");

            var token = _authService.GenerateJwtToken(user);
            return Ok(new { Token = token });
        }
    }
}