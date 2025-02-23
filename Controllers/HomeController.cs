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
       // Shared klasöründeki About.cshtml dosyasını döndürmek için tam yol kullanma yolunu seçtim.
        public IActionResult About()
        {
            return View("~/Views/Shared/_About.cshtml");
        }
    }
}
