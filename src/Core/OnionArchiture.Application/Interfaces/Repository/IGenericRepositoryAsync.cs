﻿using OnionArchiture.Domain.Common;
using OnionArchiture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchiture.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid Id);

        Task<T> AddAsync(T entity);
    }
}
