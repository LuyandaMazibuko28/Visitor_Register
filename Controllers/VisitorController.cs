using Microsoft.AspNetCore.Mvc;

namespace VisitorRegister.Controllers
{
    public class VisitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
