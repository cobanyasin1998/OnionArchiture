using OnionArchiture.Application.Interfaces.Repository;
using OnionArchiture.Domain.Entities;
using OnionArchiture.Persistence.Context;

namespace OnionArchiture.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext _context) : base(_context)
        {

        }
    }
}
