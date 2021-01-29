using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}