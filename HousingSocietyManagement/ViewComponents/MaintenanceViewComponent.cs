using HousingSocietyManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HousingSocietyManagement.ViewComponents
{
    public class MaintenanceViewComponent:ViewComponent
    {
        DBHelper repo = new DBHelper();

        public IViewComponentResult Invoke(int maintenanceId,string viewName)
        {
            ViewData["ViewName"] = viewName;
            return  View(repo.GetMaintenance(maintenanceId));
        }
    }
}
