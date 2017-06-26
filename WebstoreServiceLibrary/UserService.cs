using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebstoreServiceLibrary
{
    public class UserService : IUserService
    {
        public void RegisterNewUser(string username)
        {
            Console.WriteLine("[ServiceLibrary] => Invoked RegisterNewUser(); Params: " + username);
        }

        public void LoginUser(string username, string password)
        {
            Console.WriteLine("[ServiceLibrary] => Invoked LoginUser(); Params: " + username + ", " + password);
        }
    }
}
