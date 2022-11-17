using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchiture.Application.Interfaces.Repository;
using OnionArchiture.Persistence.Context;
using OnionArchiture.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseInMemoryDatabase("memoryDb");
            });

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
         
        }
    }
}
