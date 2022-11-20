using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchiture.Application.Interfaces.Repository;
using OnionArchiture.Persistence.Context;
using OnionArchiture.Persistence.Repositories;

namespace OnionArchiture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("inMemoryDb"));

            services.AddTransient<IProductRepository, ProductRepository>();
        }

    }
}
