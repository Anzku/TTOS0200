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
    /// Interaction logic for T1.xaml
    /// </summary>
    public partial class T1 : Window
    {
        public T1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            List<String> list = new List<string>();
            if ((bool)checkBox_Milk.IsChecked) list.Add("Milk");
            if ((bool)checkBox_Butter.IsChecked) list.Add("Butter");
            if ((bool)checkBox_Chicken.IsChecked) list.Add("Chicken");
            if ((bool)checkBox_Lemonade.IsChecked) list.Add("Lemonade");
            if ((bool)checkBox_Beer.IsChecked) list.Add("Beer");
            foreach (string item in list)
            {
                text += item + " ";
            }
            shopping_list.Text = text;

        }
    }
}
