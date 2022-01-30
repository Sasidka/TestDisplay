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
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            InfoGrid.ItemsSource = App.db.User.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage(new User()));
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            var GetUser = InfoGrid.SelectedItem as User; // спец переменная определяющая выбранную запись пользователем в DataGrid
            NavigationService.Navigate(new EditPage(GetUser));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
