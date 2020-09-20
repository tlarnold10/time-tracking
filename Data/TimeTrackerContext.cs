using Microsoft.EntityFrameworkCore;
using TimeTrack.Models;

namespace TimeTrack.Data
{
    public class TimeTrackerContext : DbContext
    {
        public TimeTrackerContext (DbContextOptions<TimeTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
    }
}