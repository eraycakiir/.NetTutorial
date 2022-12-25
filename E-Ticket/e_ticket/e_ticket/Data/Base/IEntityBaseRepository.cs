﻿using e_ticket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_ticket.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T actor);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
