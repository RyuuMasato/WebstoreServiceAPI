using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Infrastructure.Repository
{
    interface IRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity GetById(TKey id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
