using System.Threading.Tasks;
using Shop.Domain.Entities;

namespace Shop.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<bool> Exists(string email);

        Task Save(Customer customer);
    }

}