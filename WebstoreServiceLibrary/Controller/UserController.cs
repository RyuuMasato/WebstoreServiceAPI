using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Controller
{
    public class UserController
    {
        private readonly UserContext _userContext;
        private readonly UnitOfWork _unitOfWork;
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userContext = new UserContext();
            _userRepository = new UserRepository(_userContext);
            _unitOfWork = new UnitOfWork(_userContext);
        }

        public void Create(string username)
        {
            _userRepository.Create(new User()
            {
                Username = username,
                Password = new string(username.ToCharArray().Reverse().ToArray())
            });
            _unitOfWork.SaveChanges();
        }

        public User FindByUsername(string username)
        {
            return _userRepository.Find(username).First();
        }

        public IEnumerable<User> UpdateUserList()
        {
            IObservable<User> userObs = _userRepository.FindAll().ToAsyncEnumerable().ToObservable();
            userObs.Subscribe(
                (u) => Console.WriteLine("Value returned: {0}, {1}", u.Username, u.Password),
                (error) => Console.WriteLine(error),
                () =>
                {
                    Console.WriteLine("Finished Subscription");
                });
            return _userRepository.FindAll();
        }
    }
}
