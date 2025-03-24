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

namespace KozlovTest.Views.Pages.TestPages
{
    /// <summary>
    /// Логика взаимодействия для TestPage1.xaml
    /// </summary>
    public partial class TestPage1 : Page
    {
        private int sum = 0;
        public TestPage1()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (Tb1.Text == "1")
            {
                MessageBox.Show("Правильно");
                sum++;
            }
            else
            {
                MessageBox.Show("неправильно");
            }
            p1.Visibility = Visibility.Collapsed;
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB1.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                sum++;
            }
            else
            {
                MessageBox.Show("неправильно");
            }
            p2.Visibility = Visibility.Collapsed;
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (ChB1.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                sum++;
            }
            else
            {
                MessageBox.Show("неправильно");
            }
            p3.Visibility = Visibility.Collapsed;
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            if (Tb4Text == "1")
            {
                MessageBox.Show("Правильно");
                sum++;
            }
            else
            {
                MessageBox.Show("неправильно");
            }
            p4.Visibility = Visibility.Collapsed;
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
