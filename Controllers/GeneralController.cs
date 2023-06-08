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
            
            if (ModelState.IsValid)
            {
                _db.processors.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("IndexGeneral");

            }
            return View(obj);
        }

        //TODO ->
		//Handling Processors Editing process
		public IActionResult EditProcessor()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditProcessor(Processor obj)
		{

			if (ModelState.IsValid)
			{
				_db.processors.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("IndexGeneral");

			}
			return View(obj);
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
            
            if (ModelState.IsValid)
            {
                _db.motherboards.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("IndexGeneral");
            }
            return View(obj);
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
            
            if (ModelState.IsValid)
            {
                _db.graphicscards.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("IndexGeneral");
            }
            return View(obj);

        }

    }
}
