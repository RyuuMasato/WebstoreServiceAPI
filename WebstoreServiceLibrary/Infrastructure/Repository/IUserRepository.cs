using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Infrastructure.Repository
{
    interface IUserRepository : IRepository<User, string>
    {
        IEnumerable<User> Find(string qeury);
        IEnumerable<User> FindAll();
    }
}
