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
    /// Interaction logic for T3Lotto.xaml
    /// </summary>
    public partial class T3Lotto : Window
    {
       
        public T3Lotto()
        {
            InitializeComponent();
            List<string> games = new List<string>();
            games.Add("Lotto");
            games.Add("Viking");
            games.Add("Eurojackpot");
            
            cbxGame.ItemsSource = games;
        }

        private void buttonDraw_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "";
            string game = "empty";
            if (cbxGame.SelectedItem!=null) game = cbxGame.SelectedItem.ToString();
            int drawNumb = 0;
            try
            {
                drawNumb = int.Parse(tbNumberOfDraws.Text);
                switch (game)
                {
                    case "Viking": textBlock1.Text = Game.Viking(drawNumb);
                        break;
                    case "Lotto": textBlock1.Text = Game.Lotto(drawNumb);
                        break;
                    case "Eurojackpot": textBlock1.Text = Game.Eurojackpot(drawNumb);
                        break;
                    default:
                        textBlock1.Text = "Please, choose a game";
                        break;
                }
                //textBlock1.Text = cbxGame.SelectedItem.ToString() + " " + drawNumb;
            }
            catch (Exception)
            {
                textBlock1.Text = "Error";               
            }
            

        }

       

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "";
        }
    }
}
