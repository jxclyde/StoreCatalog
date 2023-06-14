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

		//Handling Processors Editing process
		public IActionResult EditProcessor(int? id )
		{
            if (id == null || id == 0)
            { 
                return NotFound();
            }

            var processorFromDb = _db.processors.Find(id);

            if (processorFromDb == null)
            {
                return NotFound();
            }
			return View(processorFromDb);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditProcessor(Processor obj)
		{

			if (ModelState.IsValid)
			{
				_db.processors.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("IndexGeneral");

			}
			return View(obj);
		}

        //Handling Processors Deleting 
        public IActionResult DeleteProcessor(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var processorFromDb = _db.processors.Find(id);

            if (processorFromDb == null)
            {
                return NotFound();
            }
            return View(processorFromDb);
        }

        [HttpPost("DeleteProcessorPOST")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProcessorPOST(int? id)
        {

            var obj = _db.processors.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.processors.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("IndexGeneral");

        }
        //---------------------------------------------------------------------

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

		//Handling Motherboard Editing process
		public IActionResult EditMotherboard(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			var motherboardFromDb = _db.motherboards.Find(id);

			if (motherboardFromDb == null)
			{
				return NotFound();
			}
			return View(motherboardFromDb);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditMotherboard(Motherboard obj)
		{

			if (ModelState.IsValid)
			{
				_db.motherboards.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("IndexGeneral");

			}
			return View(obj);
		}

        //Handling Motherboard Deleting 
        public IActionResult DeleteMotherboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var motherboardFromDb = _db.motherboards.Find(id);

            if (motherboardFromDb == null)
            {
                return NotFound();
            }
            return View(motherboardFromDb);
        }

        [HttpPost("DeleteMotherboardPOST")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMotherboardPOST(int? id)
        {

            var obj = _db.motherboards.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.motherboards.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("IndexGeneral");

        }
        //---------------------------------------------------------------------

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

		//Handling GraphicsCard Editing process
		public IActionResult EditGraphicsCard(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			var graphicsCardFromDb = _db.graphicscards.Find(id);

			if (graphicsCardFromDb == null)
			{
				return NotFound();
			}
			return View(graphicsCardFromDb);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditGraphicsCard(GraphicsCard obj)
		{

			if (ModelState.IsValid)
			{
				_db.graphicscards.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("IndexGeneral");

			}
			return View(obj);
		}

        //Handling GraphicsCard Deleting 
        public IActionResult DeleteGraphicsCard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var graphicsCardFromDb = _db.graphicscards.Find(id);

            if (graphicsCardFromDb == null)
            {
                return NotFound();
            }
            return View(graphicsCardFromDb);
        }

        [HttpPost("DeleteGraphicsCardPOST")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteGraphicsCardPOST(int? id)
        {

            var obj = _db.graphicscards.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.graphicscards.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("IndexGeneral");

        }
    }
}
