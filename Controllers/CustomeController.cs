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
    [Route("customers")]
    public class CustomeController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetByid(
            [FromServices] IMediator mediator,
            [FromQuery] FindCustomerByIdRequest command
        )
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command
        )
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
