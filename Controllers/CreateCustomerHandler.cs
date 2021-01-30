using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Handlers;
using Shop.Domain.Queries.Requests;

namespace Shop.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CreateCustomerHandler : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public IActionResult GetByid(
            [FromServices] IMediator mediator,
            [FromQuery] FindCustomerByIdRequest command
        )
        {
            var result = mediator.Send(command);

            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command
        )
        {
            var result = mediator.Send(command);

            return Ok(result);
        }
    }
}