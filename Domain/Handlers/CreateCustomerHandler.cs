using System;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest command)
        {
            // Verificar se o cliente já está cadastrado

            // Validar os dados

            // Inserir o cliente

            // Enviar e-mail de boas vinda

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Jean Barcellos",
                Email = "jeanbarcellos@teste.com",
                Date = DateTime.Now
            };
        }
    }
}
