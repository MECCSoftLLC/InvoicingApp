using Invoicing.Core.Data;
using Invoicing.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoicing.Core.Repositories
{
    public class Repository<TEntity> where TEntity : EntityBase
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public virtual Int32 Count()
        {
            return _entities.Count();
        }

        public virtual TEntity Add(TEntity entity)
        {
            _entities.Add(entity);
            return entity;
        }

        public virtual TEntity Get(Int32 id)
        {
            return _entities.Find(id);
        }
 
        public virtual TEntity Update(TEntity entity)
        {
            _entities.Update(entity);
            return entity;
        }

        public virtual TEntity Remove(TEntity entity)
        {
            _entities.Remove(entity);
            return entity;
        }
    }
}
