using HousingSocietyManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HousingSocietyManagement.Controllers
{
    public class MaintenanceController : Controller
    {
        DBHelper repo = new DBHelper();

        private readonly IConfiguration config;

        public MaintenanceController(IConfiguration config)
        {
            this.config = config;
            DBHelper.conString = this.config.GetConnectionString("HousingSocietyDB");
        }
        public IActionResult Index()
        {
            repo = new DBHelper();
            return View(repo.GetAllMaintenance());
        }

        public IActionResult GetDetails(int id)
        {
            repo = new DBHelper();
            return View(repo.GetMaintenance(id));
        }

        public IActionResult Delete(int id)
        {
            repo = new DBHelper();
            return View(repo.GetMaintenance(id));
        }

    }
}
