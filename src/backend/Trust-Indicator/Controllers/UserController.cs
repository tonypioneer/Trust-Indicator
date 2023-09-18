using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Trust_Indicator.Data;
using Trust_Indicator.Dtos;
using Trust_Indicator.Model;

namespace Trust_Indicator.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IRepo _repo;
        public UserController(IRepo repository)
        {
            _repo = repository;
        }

        //user/login
        [HttpPost("login")]
        public ActionResult<bool> ValidLogin(string email, string password)
        {
            return Ok(_repo.ValidLogin(email, password));
        }

        //user/isAdmin
        [HttpGet("isAdmin")]
        public ActionResult<bool> IsAdmin(User user)
        {
            return Ok(_repo.IsAdmin(user));
        }
    }
}
