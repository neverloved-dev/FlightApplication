using FlightApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FlightApplication.Models;

namespace FlightApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public readonly FlightTicketDbContext _context;
        public UserController(FlightTicketDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult<Task<User>> AddNewUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }
}
