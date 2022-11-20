using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchiture.Application.Features.Commands.CreateProduct;
using OnionArchiture.Application.Features.Queries.GetAllProducts;
using OnionArchiture.Application.Features.Queries.GetProductById;
using System;
using System.Threading.Tasks;

namespace OnionArchiture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductQuery();

            return Ok(await _mediator.Send(query));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };

            return Ok(await _mediator.Send(query));

        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
