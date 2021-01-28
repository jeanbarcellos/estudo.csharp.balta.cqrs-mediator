using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Handlers;

namespace Shop.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CreateCustomerHandler : ControllerBase
    {
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