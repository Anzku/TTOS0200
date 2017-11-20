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

namespace Labra09
{
    /// <summary>
    /// Interaction logic for T4Kiuas.xaml
    /// </summary>
    public partial class T4Kiuas : Window
    {
        public T4Kiuas()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var name = (string)button.Content;
            if (inputBox.Text == "0") inputBox.Text = name;
            else inputBox.Text += name;
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "0";
        }
    }   
}
