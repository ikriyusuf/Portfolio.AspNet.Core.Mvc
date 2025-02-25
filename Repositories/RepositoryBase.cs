using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IReposityoryBase<T>
        where T : class, new()
    {
        // BEN BURAYI DEVRALDIĞIM CLASSLARDA DA KULLANMAK İSTİYORUM.
        // BU YÜZDEN PRİVATE DEĞİL PROTECTED OLARAK TANIMLAMAK İSTİYORUM
        protected readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges
                ? _context.Set<T>()
                : _context.Set<T>().AsNoTracking();
        }
    }
}
