using Microsoft.AspNetCore.Mvc;
using HousingSocietyManagement.Models;

namespace HousingSocietyManagement.Controllers
{
    public class FlatController : Controller
    {
        DBHelper repo;
        private readonly IConfiguration config;

        public FlatController(IConfiguration config)
        {
            this.config = config;
            DBHelper.conString = this.config.GetConnectionString("HousingSocietyDB");
        }

        public IActionResult  Index()
        {
            repo = new DBHelper();
            return View(repo.GetFlats());
        }

        public IActionResult DeleteFlat(int flatNo)
        {
            repo = new DBHelper();
            Flat flat = repo.GetFlatById(flatNo);
            return View(flat);
        }

        public IActionResult Yes(int flatNo)
        {
            repo = new DBHelper();
            repo.DeleteFlat(flatNo);
            return RedirectToAction("Index");
        }
        public IActionResult GetFlatDetails(int flatNo)
        {
            repo = new DBHelper();
          Flat flat=  repo.GetFlatById(flatNo);
            return View(flat);
        }

        //Incoming Get Request 
        public IActionResult CreateFlat()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult CreateFlat(Flat flat)
        {
            repo = new DBHelper();
            repo.AddNewFlat(flat);
            return RedirectToAction("Index");
        }

    }
}
