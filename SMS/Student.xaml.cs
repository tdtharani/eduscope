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
using System.Windows.Shapes;

namespace SMS
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 Payments = new Window5();
            Payments.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 Course_main = new Window4();
            Course_main.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window6 Student = new Window6();
            Student.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window9 Search = new Window9();
            Search.ShowDialog();
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window8 register = new Window8();
            register.ShowDialog();
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window10 Studentlist = new Window10();
            Studentlist.ShowDialog();
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Hide();
        }
    }
}
