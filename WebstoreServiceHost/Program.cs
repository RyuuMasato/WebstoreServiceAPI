using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebstoreServiceLibrary;

namespace WebstoreServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost userServiceHost = new ServiceHost(typeof(UserService)))
            {
                userServiceHost.Open();
                Console.WriteLine("Service Library ready for use...\n");
                Console.ReadKey();
            }
        }
    }
}
