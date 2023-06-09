using Microsoft.EntityFrameworkCore;
using Project_Solpac_Web.Models;

namespace Project_Solpac_Web.Data
{
    public class SolpacClientDbContext : DbContext
    {
        public SolpacClientDbContext(DbContextOptions<SolpacClientDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
