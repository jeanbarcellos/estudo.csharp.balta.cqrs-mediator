using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public bool Exists(string email)
        {
            return _context.Customers.Any(x => x.Email == email);
        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();
        }

        public Customer GetCustomerById(Guid Id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == Id);
        }

    }
}