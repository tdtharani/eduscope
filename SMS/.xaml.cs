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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string courseid = Id.Text;
                string name = newname.Text;
                double money = double.Parse(newfee.Text);
                MessageBox.Show("The Course is Successfully Updated!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Please check your inputs.");
            }
        }
    }
}
