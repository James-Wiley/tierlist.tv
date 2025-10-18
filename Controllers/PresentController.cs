using Microsoft.AspNetCore.Mvc;

namespace tierlist.tv.Controllers
{
    public class PresentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
