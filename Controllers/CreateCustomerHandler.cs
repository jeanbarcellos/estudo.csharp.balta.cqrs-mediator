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
            [FromServices] IFindCustomerByIdHandler handler,
            [FromQuery] FindCustomerByIdRequest command
        )
        {
            var result = handler.Handle(command);

            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
        )
        {
            var response = handler.Handle(command);

            return Ok(response);
        }
    }
}