using AutoMapper;
using MediatR;
using OnionArchiture.Application.DTO;
using OnionArchiture.Application.Interfaces.Repository;
using OnionArchiture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchiture.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDTO>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<ProductViewDTO>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            var dto = _mapper.Map<ProductViewDTO>(product);

            return new ServiceResponse<ProductViewDTO>(dto);


        }
    }
}
