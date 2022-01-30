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
using TestDisplay.Model;

namespace TestDisplay.Views
{
    /// <summary>
    /// Логика взаимодействия для AddnewUserPage.xaml
    /// </summary>
    public partial class AddnewUserPage : Page
    {
        public AddnewUserPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RoleCMB.ItemsSource = App.db.Role.ToList();
        }

        private void SaveUser_Click_1(object sender, RoutedEventArgs e)
        {
            User people = new User();
            people.Login = LogTB.Text;
            people.Password = PassTB.Text;

            var CurrentUser = RoleCMB.SelectedItem as Role;
            people.RoleID = CurrentUser.ID;

            App.db.User.Add(people);
            App.db.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
