﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAPI.Infrastructure.Context;

namespace ServiceAPI.Infrastructure.Repository
{
    public class Repository<TEntity, TKey> where TEntity : class
    {
        private readonly DbContext _dbContext;
        private UserContext dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException("dbContext");
        }

        protected DbContext DbContext
        {
            get { return _dbContext; }
        }
        public void Create(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            DbContext.Set<TEntity>().Add(entity);
        }
        public TEntity GetById(TKey id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
        public void Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            DbContext.Set<TEntity>().Attach(entity);
            DbContext.Set<TEntity>().Remove(entity);
        }
        public void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            DbContext.Set<TEntity>().Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
