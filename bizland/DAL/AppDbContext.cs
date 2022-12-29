using bizland.Models;
using Microsoft.EntityFrameworkCore;

namespace bizland.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<About> Abouts { get;set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FeaturedService> FeaturedService { get; set; }
        public DbSet<FeedbackSite> FeedbackSites { get; set; }
        public DbSet<Hero>  Heros { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
