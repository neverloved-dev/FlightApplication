using FlightApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FlightApplication.Models;
using System.Runtime.InteropServices.Marshalling;
using System.Net.Http;
using System.Net;
using System.Net.Mail;

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
            if(user.Age<1 || user.Age>80)
            {
                return BadRequest("User age invalid");
            }
            _context.Users.Add(user);
            _context.SaveChanges();
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("bae99f0e4e0575", "87adc6f078ae18"),
                EnableSsl = true
            };
            var body = $"Hello {user.Name},your age is {user.Age}";
            client.Send("from@example.com", "to@example.com", "Hello world", body);
            return Ok(user);
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
