using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;
using Shop.Domain.Repositories;

namespace Shop.Domain.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            var customer = _repository.GetCustomerById(request.Id);

            if (customer == null)
            {
                throw new Exception("Nada");
            }

            var result = new FindCustomerByIdResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
            };

            return Task.FromResult(result);
        }
    }
}