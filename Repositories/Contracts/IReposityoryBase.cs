﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
   public interface IReposityoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        void Create(T entity);
    }
}
