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
            if (ticket.Class == FlightClass.P)
            {
                ticket.Class = FlightClass.R;
            }
            return Ok(ticket);
        }
    }
}
