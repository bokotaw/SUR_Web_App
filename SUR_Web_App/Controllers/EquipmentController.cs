using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SUR_Web_App.Controllers
{
    public class EquipmentController : Controller
    {
        [Authorize(Roles = "SuperAdmin, Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
