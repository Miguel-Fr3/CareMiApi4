using CareMiApi4.Data;
using CareMiApi4.Models;
using CareMiApi4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CareMiApi4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private readonly AppDbContext _context;

        public AuthController(TokenService tokenService, AppDbContext context)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login login)
        {
            var user = _context.Logins
                .FirstOrDefault(u => u.NrCpf == login.NrCpf && u.DsSenha == login.DsSenha);

            if (user != null)
            {
                var token = _tokenService.GenerateToken(user.NrCpf);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}
