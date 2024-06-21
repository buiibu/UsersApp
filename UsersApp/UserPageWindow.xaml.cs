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
using System.Windows.Shapes;
using Database;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {

        private readonly Database.UserAppEntities connection;
        public UserPageWindow()
        {
            InitializeComponent();

            connection = new Database.UserAppEntities();
            List<User> users = connection.Users.ToList();
            listOfUsers.ItemsSource = users;
        }
    }
}
