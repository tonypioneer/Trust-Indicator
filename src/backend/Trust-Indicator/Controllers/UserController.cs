using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        //user/isAdmin/{userId}
        [HttpGet("isAdmin")]
        public ActionResult<bool> IsAdmin(int userId)
        {
            User user = _repo.GetUserByID(userId);
            return Ok(_repo.IsAdmin(user));
        }

        //user/NewUser
        [HttpPost("NewUser")]
        public ActionResult NewUser(UserInputDto user)
        {
            User u = new()
            {
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                LegalName = user.LegalName,
                Is_Admin = false
            };

            UserValidator validator = new();
            ValidationResult results = validator.Validate(u);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
                return BadRequest();
            }

            if (_repo.GetUserByLegalName(user.LegalName) != null)
            {
                return BadRequest("Person already has an account!");
            }

            if (_repo.GetUserByEmail(user.Email) != null)
            {
                return BadRequest("Email already used!");
            }

            if (_repo.CheckUserName(user.UserName))
            {
                return BadRequest("This user name is used!");
            }

            UserOutputDto newUser = _repo.AddUser(u);
            return CreatedAtAction(nameof(GetUser), new { UserName = newUser.UserName }, newUser);
        }

        //user/GetUser/{UserName}
        [HttpGet("GetUser/{UserName}")]
        public ActionResult GetUser(string userName)
        {
            IEnumerable<UserOutputDto> user = _repo.GetUserByUsername(userName);
            if (user == null)
                return NotFound("User Not Found.");
            else
            {
                return Ok(user);
            }
        }
        /* 
        private User GetAuthenticatedUser()
        {
            var email = User.FindFirstValue("email");
            return _repo.GetUserByEmail(email);
        }

        [HttpPost("changeProfilePhoto")]
        [Authorize]
        public ActionResult<UserOutputDto> ChangeProfilePhoto(User user, string photo)
        {
            return Ok(_repo.ChangeProfilePhoto(user, photo));
        }

        [HttpPost("changePassword")]
        [Authorize]
        public ActionResult<UserOutputDto> ChangePassword(User user, string password)
        {
            return Ok(_repo.ChangePassword(user, password));
        }

        [HttpPost("changeUserName")]
        [Authorize]
        public ActionResult<UserOutputDto> ChangeUserName(User user, string userName)
        {
            return Ok(_repo.ChangeUserName(user, userName));
        }
        */
    }
}
