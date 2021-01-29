using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public async Task<bool> Exists(string email)
        {
            return await _context.Customers.AnyAsync(x => x.Email == email);
        }

        public async Task Save(Customer customer)
        {
            _context.Customers.Add(customer);

            await _context.SaveChangesAsync();
        }
    }
}