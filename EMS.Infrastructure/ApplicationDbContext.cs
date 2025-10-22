using EMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }

    }
}
