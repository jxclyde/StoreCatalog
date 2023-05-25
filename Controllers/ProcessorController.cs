using Microsoft.AspNetCore.Mvc;

namespace StoreCatalog.Controllers
{
    public class ProcessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
