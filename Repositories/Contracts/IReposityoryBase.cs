﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
   public interface IReposityoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
