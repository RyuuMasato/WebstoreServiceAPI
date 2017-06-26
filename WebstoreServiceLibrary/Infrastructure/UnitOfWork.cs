using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Dispose() { }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
