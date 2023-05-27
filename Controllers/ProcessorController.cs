using Microsoft.AspNetCore.Mvc;
using StoreCatalog.Data;
using StoreCatalog.Models;
using System.Collections;

namespace StoreCatalog.Controllers
{
    public class ProcessorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProcessorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Processor> objProcessorList = _db.processors;
            //IEnumerable<Motherboard> objMotherboardList = _db.motherboards;
            //IEnumerable<GraphicsCard> objGraphicsCardList = _db.graphicscards;
            //ViewData["ProcessorList"] = objProcessorList;
            //ViewData["MotherboardList"] = objMotherboardList;
            //ViewData["GraphicsCardList"] = objGraphicsCardList;

            return View(objProcessorList);
        }

        //public IActionResult Index()
        //{
        //    IndexViewModel viewModel = new IndexViewModel
        //    {
        //        Processors = _db.processors,
        //        Motherboards = _db.motherboards,
        //        GraphicsCards = _db.graphicscards
        //    };

        //    return View(viewModel);
        //}

    }
}
