using FlightApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FlightApplication.Models;
using System.Runtime.InteropServices.Marshalling;
using System.Net.Http;
using System.Net;

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
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsersAsync()
        {
            var url = "http://jsonplaceholder.typicode.com/users";

            var request = WebRequest.Create(url);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            return Ok(data);
        }
    }
}
