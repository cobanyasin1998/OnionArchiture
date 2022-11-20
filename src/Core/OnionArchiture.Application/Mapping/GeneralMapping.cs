using AutoMapper;
using OnionArchiture.Application.Features.Commands.CreateProduct;

namespace OnionArchiture.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, DTO.ProductViewDTO>().ReverseMap();
            CreateMap<Domain.Entities.Product, CreateProductCommand>().ReverseMap();

        }
    }
}
