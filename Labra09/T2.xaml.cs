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
    /// Interaction logic for T2.xaml
    /// </summary>
    public partial class T2 : Window
    {
        public T2()
        {
            InitializeComponent();
            
            
        }

        private void button_hae_Click(object sender, RoutedEventArgs e)
        {
            dgPelaajat.ItemsSource = Joukkoe.HaePelaajat();
        }
        
    }
}
