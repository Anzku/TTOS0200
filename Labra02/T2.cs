using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T2
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä: ohjelmoida pesukoneen toiminta");
            Pesukone LG = new Pesukone();
            Console.WriteLine("Laitetaan pesukoneen päälle");
            LG.on_paalla = true;
            Menu(LG);
        }
        public static void Menu(Pesukone pesukone)
        {
            string valinta = "";
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Pesuohjelma1");
                Console.WriteLine("2. Pesuohjelma2");
                Console.WriteLine("3. Pesuohjelma3");
                Console.WriteLine("4. Laita pesukoneen pois päältä");
                Console.WriteLine("Sinun valinta > ");
                valinta = Console.ReadLine();
                switch (valinta)
                {
                    case "1":
                        pesukone.Pesu_ohjelma_1();

                        break;
                    case "2":
                        pesukone.Pesu_ohjelma_2();

                        break;
                    case "3":
                        pesukone.Pesu_ohjelma_3();

                        break;
                    case "4":
                        pesukone.on_paalla = false;
                        Console.WriteLine("Nyt pesukone on pois päältä.");

                        break;
                    default:
                        Menu(pesukone);
                        break;

                }
            } while (valinta != "4");
            
        }
    }
    class Pesukone
    {
        int pesu_aika { get; set; }
        int pesu_lampotila { get; set; }
        public bool on_paalla = false;
        public void Pesu_ohjelma_1 ()
        {
            this.pesu_aika = 60;
            this.pesu_lampotila = 40;
            Console.WriteLine("Pesuohjelma 1 alkaa. Pesuaika: {0} min. Veden lämpötilä: {1} astetta. ", this.pesu_aika, this.pesu_lampotila);
            Console.WriteLine("Pesuohjelma on loppunut");
        }
        public void Pesu_ohjelma_2()
        {
            this.pesu_aika = 130;
            this.pesu_lampotila = 60;
            Console.WriteLine("Pesuohjelma 2 alkaa. Pesuaika: {0} min. Veden lämpötilä: {1} astetta. ", this.pesu_aika, this.pesu_lampotila);
            Console.WriteLine("Pesuohjelma on loppunut");

        }
        public void Pesu_ohjelma_3()
        {
            this.pesu_aika = 40;
            this.pesu_lampotila = 30;
            Console.WriteLine("Pesuohjelma 3 alkaa. Pesuaika: {0} min. Veden lämpötilä: {1} astetta. ", this.pesu_aika, this.pesu_lampotila);
            Console.WriteLine("Pesuohjelma on loppunut");
        }
        
    }
}
