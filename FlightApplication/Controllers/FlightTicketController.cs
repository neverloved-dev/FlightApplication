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
        public ActionResult AddNewUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }
}
