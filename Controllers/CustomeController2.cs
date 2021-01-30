using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;

namespace Shop.Controllers
{
    [ApiController]
    [Route("customers2")]
    public class CustomeController2 : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public Task<FindCustomerByIdResponse> GetByid(
            [FromServices] IMediator mediator,
            [FromQuery] FindCustomerByIdRequest command
        )
        {
            return mediator.Send(command);
        }

        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command
        )
        {
            return mediator.Send(command);
        }

    }
}