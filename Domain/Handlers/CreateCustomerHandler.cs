using System;
using Shop.Domain.Entities;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Repositories;
using Shop.Domain.Services;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        ICustomerRepository _repository;
        IEmailService _emailService;

        public CreateCustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public CreateCustomerResponse Handle(CreateCustomerRequest command)
        {
            // Verificar se o cliente já está cadastrado

            // Validar os dados

            // Cria a entidade
            var customer = new Customer(command.Name, command.Email);

            // Persiste a entidade no banco
            _repository.Save(customer);

            // Envia E-mail de boas-vindas
            _emailService.Send(customer.Name, customer.Email);

            return new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            };
        }
    }

}
