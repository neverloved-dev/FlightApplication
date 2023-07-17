using Microsoft.EntityFrameworkCore;
using FlightApplication.Models;
using System.Security.Cryptography.X509Certificates;

namespace FlightApplication.Data
{
    public class FlightTicketDbContext:DbContext
    {
        public FlightTicketDbContext(DbContextOptions<FlightTicketDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<FlightTicket> FlightTicket { get; set; }

    }
}
