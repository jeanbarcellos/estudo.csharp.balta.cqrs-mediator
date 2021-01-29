using System;
using System.Threading.Tasks;
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories
{
    public interface ICustomerRepository
    {
        bool Exists(string email);

        void Save(Customer customer);

        Customer GetCustomerById(Guid Id);
    }

}