﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter,
            string? includeProperties = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter,
            string? includeProperties = null);

        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
