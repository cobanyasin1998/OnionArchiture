using AutoMapper;
using MediatR;
using OnionArchiture.Application.DTO;
using OnionArchiture.Application.Interfaces.Repository;
using OnionArchiture.Application.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchiture.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductViewDTO>>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductViewDTO>>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductViewDTO>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();

                var viewModel = _mapper.Map<List<ProductViewDTO>>(products);

                return new ServiceResponse<List<ProductViewDTO>>(viewModel);
            }
         
        }
    }
}
