using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}