using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        // 2.1 Prikazivanje indeksa svih bookinga - 
        private static List<HotelBooking>bookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(bookings);
        }

        // 2.2 Napravi create koji sluzi za pozivanje Create view-a

        public IActionResult Create()
        {
            return View();
        }


        //
        public IActionResult CreateBooking(HotelBooking booking)

        {
            
            booking.ID = bookings.Count + 1;

            bookings.Add(booking);

            return RedirectToAction("Index");
        }
    }
}
