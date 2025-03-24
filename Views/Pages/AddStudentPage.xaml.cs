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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        private KozlovTestEntities _context = new KozlovTestEntities();
        public AddStudentPage()
        {
            InitializeComponent();
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
        }

        private void EntertBtn_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student()
            {
                Name = NameTb.Text,
                Group = GroupCmb.SelectedItem as Group
            };
            _context.Student.Add(newStudent);
            _context.SaveChanges();
            MessageBox.Show("Студент добавлен.");
            FrameHelper.selectedFrame.Navigate(new MenuPage());
        }
    }
}
