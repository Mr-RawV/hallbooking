using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Hall;

namespace HallRoomBooking.Controllers
{
    public class MeetingHallController : Controller
    {
        public IActionResult ViewHall()
        {
            HallService hs = new HallService();
            //List<HallService> hall = new List<HallService>();
            //hs.GetName();
            return View(hs.GetName());
            
        }
    }
}