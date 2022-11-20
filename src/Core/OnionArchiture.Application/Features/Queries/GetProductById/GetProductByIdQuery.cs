using MediatR;
using OnionArchiture.Application.DTO;
using OnionArchiture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<ProductViewDTO>>
    {
        public Guid Id { get; set; }


    }
}
