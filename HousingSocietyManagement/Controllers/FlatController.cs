using Microsoft.AspNetCore.Mvc;
using HousingSocietyManagement.Models;

namespace HousingSocietyManagement.Controllers
{
    public class FlatController : Controller
    {
        HousingSocietyRepository repo;
        public IActionResult  Index()
        {
            repo = new HousingSocietyRepository();
            return View(repo.GetFlats());
        }

        public IActionResult GetFlatDetails(int flatNo)
        {
            repo = new HousingSocietyRepository();
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
            repo = new HousingSocietyRepository();
            repo.AddNewFlat(flat);
            return RedirectToAction("Index");
        }

    }
}
