using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Book controller'ın List Action'a yönlendirme yapıldı.
            return RedirectToAction("List", "Book");
        }
    }
}
