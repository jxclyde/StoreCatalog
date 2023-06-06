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

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CatalogViewModel catalogViewModel)
        {
            if (ModelState.IsValid)
            {
                // Save changes to the processors, motherboards, and graphics cards in the database
                _db.processors.AddRange(catalogViewModel.Processors);
                _db.motherboards.AddRange(catalogViewModel.Motherboards);
                _db.graphicscards.AddRange(catalogViewModel.GraphicsCards);
                _db.SaveChanges();

                return RedirectToAction("Index"); // Redirect to the index page or any other desired page
            }

            // If the model state is not valid, return the view with the same catalogViewModel to display validation errors
            return View(catalogViewModel);
        }
    }
}
