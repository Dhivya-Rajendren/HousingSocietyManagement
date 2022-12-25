using Microsoft.AspNetCore.Mvc;
using HousingSocietyManagement.Models;

namespace HousingSocietyManagement.Controllers
{
    public class FlatController : Controller
    {
        HousingSocietyRepository repo;
        public IActionResult  Index()
        {
            Flat flat = new Flat();
            flat.FlatNo = 3;
            flat.FlatName = "A-3";
            flat.FlatOwner = "John";
            flat.Mobile = 7412589635;
            flat.Wing = "A";
            flat.Aadhar = 1236457896325874;
            flat.Email = "John@hotmail.com";
            repo = new HousingSocietyRepository();
            repo.GetFlats().Add(flat);

            return View(repo.GetFlats());
        }

        public IActionResult GetFlatDetails(int flatNo)
        {
            repo = new HousingSocietyRepository();
          Flat flat=  repo.GetFlatById(flatNo);
            return View(flat);
        }

       

    }
}
