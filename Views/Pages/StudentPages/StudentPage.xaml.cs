using KozlovTest.AppData;
using KozlovTest.Model;
using KozlovTest.Views.Pages.TestPages;
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

namespace KozlovTest.Views.Pages.StudentPages
{
    /// <summary>
    /// Логика взаимодействия для StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        private KozlovTestEntities _context = new KozlovTestEntities();
        public StudentPage()
        {
            InitializeComponent();
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";

            StudentCmb.DisplayMemberPath = "Name";

            TestCmb.ItemsSource = _context.Test.ToList();
            TestCmb.DisplayMemberPath = "Name";
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TestCmb.SelectedIndex == 1)
            {
                FrameHelper.selectedFrame.Navigate(new TestPage1());
            }
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentCmb.ItemsSource = _context.Student.Where(s => s.Group == GroupCmb.SelectedItem as Group);
        }
    }
}
