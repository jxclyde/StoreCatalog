using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreCatalog.Data;
using StoreCatalog.Models;

namespace StoreCatalog.Controllers
{
    public class GeneralController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GeneralController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult IndexGeneral()
        {
            var processors = _db.processors.ToList();
            var motherboards = _db.motherboards.ToList();
            var graphicsCards = _db.graphicscards.ToList();

            CatalogueItem catalogue = new CatalogueItem()
            {
                Processors = processors,
                Motherboards = motherboards,
                GraphicsCards = graphicsCards

            };
            return View(catalogue);
        }

        //Handling Processors creating process
        public IActionResult CreateProcessor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProcessor(Processor obj)
        {
            _db.processors.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("IndexGeneral");
        }

        //Handling Motherboards creating process
        public IActionResult CreateMotherboards()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMotherboards(Motherboard obj)
        {
            _db.motherboards.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("IndexGeneral");
        }

        //Handling GraphicsCards creating process
        public IActionResult CreateGraphicsCards()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateGraphicsCards(GraphicsCard obj)
        {
            _db.graphicscards.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("IndexGeneral");
        }

    }
}
