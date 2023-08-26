using Microsoft.AspNetCore.Mvc;

namespace Trust_Indicator.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
