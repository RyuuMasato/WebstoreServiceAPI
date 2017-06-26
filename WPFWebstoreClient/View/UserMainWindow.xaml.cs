using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ServiceClient.UserService;

namespace WebstoreClient
{
    /// <summary>
    /// Interaction logic for UserMainWindow.xaml
    /// </summary>
    public partial class UserMainWindow : Window
    {
        public UserMainWindow()
        {
            InitializeComponent();
        }

        private void Login_User(object sender, RoutedEventArgs e)
        {
            string username = LoginUsernameBox.Text, password = LoginPasswordBox.Password;
            Console.WriteLine("[WebstoreClient] => User login: {0}, {1}", username, password);
            using (UserServiceClient userService = new UserServiceClient())
            {
                userService.LoginUser(username, password);
            }
        }

        private void Register_New_User(object sender, RoutedEventArgs e)
        {
            string username = RegisterNewUsernameBox.Text;
            Console.WriteLine("[WebstoreClient] => User registering: {0}", username);
            using (UserServiceClient userService = new UserServiceClient())
            {
                userService.RegisterNewUser(username);
            }
        }
    }
}
