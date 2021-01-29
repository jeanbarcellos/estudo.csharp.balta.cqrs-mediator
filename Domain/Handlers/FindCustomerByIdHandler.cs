using System;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;
using Shop.Domain.Repositories;

namespace Shop.Domain.Handlers
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest command)
        {
            var customer = _repository.GetCustomerById(command.Id);

            if (customer == null)
            {
                throw new Exception("Nada");
            }

            return new FindCustomerByIdResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
            };
        }
    }
}