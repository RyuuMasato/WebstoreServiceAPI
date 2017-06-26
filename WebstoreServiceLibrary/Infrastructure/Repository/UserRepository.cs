using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Infrastructure.Repository
{
    public class UserRepository : Repository<User, string>, IUserRepository
    {
        private readonly UserContext _dbContext;
        public UserRepository(UserContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> Find(string query)
        {
            return _dbContext.Users
                .Where(u => u.Username.StartsWith(query))
                .ToList();
        }

        public IEnumerable<User> FindAll()
        {
            return _dbContext.Users
                .ToList();
        }
    }
}
