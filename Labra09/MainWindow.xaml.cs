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
using Labra09; // пример! - если мы используем классы из другого avaruudesta 

namespace Labra09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; //muuttuja on käytettävissä kaikissa luokan metodeissa ja tapahtumankäsittelijöissä
        private const string polku = @"d:\kuvat\";
        public MainWindow()
        {
            //tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            autot = Autotalli.HaeAutot();
            NaytaKuva("autotalli.png");
            //asetetaan comboboxiin kaikki eri automerkit
            //VE1: käsin koodaamalla
            List<string> merkki = new List<string>();
            merkki.Add("Audi");
            merkki.Add("Saab");
            merkki.Add("Volvo");
            merkki.Add("Lexus");
            merkki.Add("Dodge");
            cmbAutot.ItemsSource = merkki;
            //VE2: parempi kysytään LINQ:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            //pyydetään BL (business logikan)-kerrokselta autot, ja näytetään ne käyttäjälle
            
            dgAutot.ItemsSource = autot;
        }
        private void NaytaKuva(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                url = "puuttuu.png";
            }
            try
            {
                //lisätään kuvatiedostojen vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill; //täyttää koko kuvan
                imgAuto.Source = pic; // mistä lataa
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //huom, olemme itse populoineet DataGridin Auto-olioilla, joten kukin DataGridin jäsen/alkio on itseasiassa Auto-olio
                object obj = dgAutot.SelectedItem;
                if (obj != null)
                {
                    Auto valittu = (Auto)obj; //kastaaminen (объект в Auto)
                    NaytaKuva(valittu.URL);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnHaeAudi_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin pelkästään Audi-merkkiset autot
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = "";
            NaytaKuva("");
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //suodatetaan DataGridiin näkyviin vain valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            NaytaKuva("autotalli.png");
        }
    }
}
