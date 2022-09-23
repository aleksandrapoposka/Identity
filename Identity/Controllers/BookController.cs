using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetBooks()
        {
            return View();
        }
    }
}
