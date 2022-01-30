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

namespace TestDisplay.Views
{
    /// <summary>
    /// Логика взаимодействия для AutenPage.xaml
    /// </summary>
    public partial class AutenPage : Page
    {
        public AutenPage()
        {
            InitializeComponent();
        }

        private void Sign_btn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = App.db.User.FirstOrDefault(u => u.Login == LogTB.Text && u.Password == PassTB.Text);
            if (CurrentUser != null)
            {
                NavigationService.Navigate( new DataPage());
            }
        }
    }
}
