using KozlovTest.AppData;
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

namespace KozlovTest.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.selectedFrame.Navigate(new PasswordPage());
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
