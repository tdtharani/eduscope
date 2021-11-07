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

namespace SMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 addcourse = new Window1();
            addcourse.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //try { }
            Window4 Course_main = new Window4();
            Course_main.Show();
            this.Hide();

           /** catch(Exception ex) 
            {
                MessageBox.Show("Invalid Course Name!");
            }**/
        }
    }
}
