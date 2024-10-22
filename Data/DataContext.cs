using Microsoft.EntityFrameworkCore;
using SmartCitySecurity.Models;

namespace SmartCitySecurity.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Incident> Incidents { get; set; }
        public DbSet<PolicePatrol> PolicePatrols { get; set; }
    }
}
