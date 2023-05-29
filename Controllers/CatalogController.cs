using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreCatalog.Data;
using StoreCatalog.Models;

namespace StoreCatalog.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CatalogController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var processors = _db.processors.ToList();
            var motherboards = _db.motherboards.ToList();
            var graphicsCards = _db.graphicscards.ToList();

            var catalogViewModel = new CatalogViewModel
            {
                Processors = processors,
                Motherboards = motherboards,
                GraphicsCards = graphicsCards
            };

            return View(catalogViewModel);
        }

        //GET
        public IActionResult Create()
        {
            var processors = _db.processors.ToList();
            var motherboards = _db.motherboards.ToList();
            var graphicsCards = _db.graphicscards.ToList();

            var catalogViewModel = new CatalogViewModel
            {
                Processors = processors,
                Motherboards = motherboards,
                GraphicsCards = graphicsCards
            };

            return View(catalogViewModel);
        }
    }
}
