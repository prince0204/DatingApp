using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using System.Threading.Tasks;
using DatingApp.API.Model;

namespace DatingApp.API.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class AuthUser : ControllerBase
    {
        private readonly IUserAuthRepository _repo;
        public AuthUser(IUserAuthRepository repo)
        {
            _repo = repo;

        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password){
            username = username.ToLower();
            if(await _repo.IsUserExists(username))
                return BadRequest("Username already exist.");
            User user = new User{
                Username = username
            };
            var createdUser = _repo.Register(User, password);
            return StatusCode(201);
        }
    }
}