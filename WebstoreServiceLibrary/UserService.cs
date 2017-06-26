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
            Debug.WriteLine("Invoked RegisterNewUser(); Params: " + username);
        }

        public void LoginUser(string username, string password)
        {
            Debug.WriteLine("Invoked LoginUser(); Params: " + username + ", " + password);
        }
    }
}
