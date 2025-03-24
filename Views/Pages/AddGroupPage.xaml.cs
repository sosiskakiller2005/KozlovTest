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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        private KozlovTestEntities _context = new KozlovTestEntities();
        public AddGroupPage()
        {
            InitializeComponent();
            
        }

        private void EntertBtn_Click(object sender, RoutedEventArgs e)
        {
            Group newGroup = new Group()
            {
                Name = NameTb.Text
            };
            _context.Group.Add(newGroup);
            _context.SaveChanges();
            MessageBox.Show("Группа добавлена.");
            FrameHelper.selectedFrame.Navigate(new MenuPage());
        }
    }
}
