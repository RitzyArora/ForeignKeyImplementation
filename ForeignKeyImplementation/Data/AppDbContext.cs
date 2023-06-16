using ForeignKeyImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace ForeignKeyImplementation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
