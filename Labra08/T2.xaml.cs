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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class T2 : Window
    {
        public T2()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            try

    {
                float ostan = float.Parse(txb_ostan.Text);
                float maksan = ostan * 0.8997F;
                txb_maksan.Text = maksan.ToString("0.00");
                float usd = ostan / 0.8997F;
                //tblock.Text = txb_ostan.Text + " EUR vastaa " + usd.ToString("0.00") + "USD";
                tblock.Text = txb_ostan.Text;
                tblock.Text += " EUR vastaa ";
                tblock.Text += usd.ToString("0.00");
                tblock.Text += " USD";
            }

    catch (Exception)
            {
                txb_maksan.Text = " ";
                //tblock.Text = "Please, enter numbers";
                //throw;
            }
            

        }
    }
}
