using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Controllers
{
    public class RoomTypeController : Controller
    {
        RoomTypeManager Rtm = new RoomTypeManager(new EfRoomTypeDal());

       

        public IActionResult Index()
        {
            return View();
        }
    }
}
