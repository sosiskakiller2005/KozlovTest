using KozlovTest.AppData;
using KozlovTest.Model;
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
    /// Логика взаимодействия для DeleteStudentPage.xaml
    /// </summary>
    public partial class DeleteStudentPage : Page
    {
        private KozlovTestEntities _context = new KozlovTestEntities();
        public DeleteStudentPage()
        {
            InitializeComponent();
        }

        private void StudentsLv_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student selectetudent = StudentsLv.SelectedItem as Student;
            MessageBoxResult messageBoxResult = MessageBox.Show("Удалить выбранного студента?", "Удалить", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                _context.Student.Remove(selectetudent);
                MessageBox.Show("Студент удален.");
                FrameHelper.selectedFrame.Navigate(new MenuPage());
            }
        }
    }
}
