using FlightApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FlightApplication.Models;

namespace FlightApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightTicketController : Controller
    {
        public readonly FlightTicketDbContext _context;
        public FlightTicketController(FlightTicketDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult AddNewTicket(FlightTicket ticket)
        {
            var user = _context.Users.Find(ticket.UserId);
            if(user.Age>18 && ticket.Meal == MealMark.g || ticket.Meal == MealMark.h || ticket.Meal == MealMark.k)
            {
                return BadRequest("This is an adult ordering child's meal");
            }
            if (ticket.Destination == DestinationMark.U && ticket.Class == FlightClass.P)
            {
                return BadRequest("UK has no first class");
            }
            _context.FlightTicket.Add(ticket);
            _context.SaveChanges();
            return Ok(ticket);
        }
    }
}
