using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Controllers
{
    public class RoomTypeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
