using Microsoft.EntityFrameworkCore;
using ECommence.Api;

namespace ECommence.Api.Data
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

    }
}
