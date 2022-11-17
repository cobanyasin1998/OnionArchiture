using Microsoft.EntityFrameworkCore;
using OnionArchiture.Application.Interfaces.Repository;
using OnionArchiture.Domain.Common;
using OnionArchiture.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchiture.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<List<T>> GetAllAsync()
        {

            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {

            return await _context.Set<T>().FindAsync(Id);
        }
    }
}
