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
        public Kiuas heater = new Kiuas();
        

        public T4Kiuas()
        {
            InitializeComponent();
            //heater.hum = 0;
            //heater.temp = 0;
            

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
            float number;
            
            if (float.TryParse(inputBox.Text, out number))
            {
                infoBlock.Text = "";
                //onnistunut saada float;
                
                if (radioTemp.IsChecked == true)
                {
                    //heater.temp = inputBox.Text;

                    //textTemp.Text = heater.temp;
                    ////////////////////////////

                    if (number > 120)
                    {
                        textTemp.Text = "120";
                        infoBlock.Text = "info: Max temperature: 120";
                    }
                    else if (number < 0)
                    {
                        textTemp.Text = "0";
                        infoBlock.Text = "info: Min temperature: 0";
                    }
                    else textTemp.Text = inputBox.Text;
                    inputBox.Text = "0";
                }
                else if (radioHum.IsChecked == true)
                {
                    //heater.hum = inputBox.Text;

                    //textHum.Text = heater.hum;

                    if (number > 100)
                    {
                        textHum.Text = "100";
                        infoBlock.Text = "info: Max humidity: 100";
                    }
                    else if (number < 0)
                    {
                        textHum.Text = "0";
                        infoBlock.Text = "info: Min humidity: 0";
                    }
                    else textHum.Text = inputBox.Text;
                    inputBox.Text = "0";
                }
                else infoBlock.Text = "Please choose Temperature or Humidity";
            }
                
            else
                infoBlock.Text = inputBox.Text+" is outside the range.";                                  
            
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            //inputBox.Text = "0";
            string line = inputBox.Text;
            string newLine = line.Substring(0, line.Length - 1);
            inputBox.Text = newLine;
        }
    }   
}
