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
            ViewBag.Flats = repo.GetFlats();


           return View();
        }

        public IActionResult GetFlats()
        {
            //Dictionary is a Key-Value pair of collections
            //"Flat" is the Key

            //flats list is the value
            repo = new HousingSocietyRepository();

            ViewData["Flats"] = repo.GetFlats();
            return View();
        }

        public IActionResult AllFlats()
        {
            Flat flat = new Flat();
            flat.FlatNo = 3;
            flat.FlatOwner = "John";
            flat.Mobile = 7412589635;
            flat.Wing = "A";
            flat.Aadhar = 1236457896325874;
            flat.Email = "John@hotmail.com";
            repo = new HousingSocietyRepository();
            repo.GetFlats().Add(flat);

            return View(repo.GetFlats());
        }

      
    }
}
