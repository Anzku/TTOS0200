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

namespace Labra08
{
    /// <summary>
    /// Interaction logic for T3.xaml
    /// </summary>
    public partial class T3 : Window
    {
        public T3()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int L = int.Parse(textBox_L.Text);
                int H = int.Parse(textBox_H.Text);
                int W = int.Parse(textBox_W.Text);
                int ikkunan_pintaala = L * H;
                int lasin_pintaala = (L - W * 2) * (H - W * 2);
                int karmin_piiri = (L + H) * 2;
                string vastaus = "";

                vastaus = ikkunan_pintaala.ToString();
                textBox_1.Text = vastaus + " cm^2";
                vastaus = lasin_pintaala.ToString();
                textBox_2.Text = vastaus + " cm^2";
                vastaus = karmin_piiri.ToString();
                textBox_3.Text = vastaus + " cm";
            }
            catch (Exception)
            {

                string vastaus = "-";
                textBox_1.Text = vastaus;
                
                textBox_2.Text = vastaus;
                
                textBox_3.Text = vastaus;
            }
        }
    }
}
