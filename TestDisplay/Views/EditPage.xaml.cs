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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public User user { get; set; } // Специальная переменная для отображения данных в XAML
        public EditPage(User CurrentUser) // чтобы полуучать данные и работать с ними
        {
            InitializeComponent();
            user = CurrentUser;
            this.DataContext = this; // чтобы XAML код понимал откуда брать данные
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            App.db.SaveChanges();
            MessageBox.Show("Изменения Сохранены");
            NavigationService.GoBack();
        }
    }
}

            //if (user.RoleID == 0)
            //{
            //    user.RoleID = 2;
            //    App.db.User.Add(user);
            //}