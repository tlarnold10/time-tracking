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
        public DbSet<Project> Project { get; set; }
        public DbSet<TimeEntry> TimeEntry { get; set; }
    }
}