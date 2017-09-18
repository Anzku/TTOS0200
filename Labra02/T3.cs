using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T3
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä: ohjelmoida television toiminta");
            Console.WriteLine("Laitetaan TV päälle");
            TV telkku = new TV();
            telkku.on_paalla = true;
            Menu(telkku);
        }
        public static void Menu(TV telkkari)
        {
            string valinta = "";
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. TV-kanava 1");
                Console.WriteLine("2. TV-kanava 2");
                Console.WriteLine("3. TV-kanava 3");
                Console.WriteLine("4. Äänen voimakkuus");
                Console.WriteLine("5. Laita TV pois päältä");
                Console.Write("Sinun valinta > ");
                valinta = Console.ReadLine();
                switch (valinta)
                {
                    case "1":
                        telkkari.Kanavan_vaihto(1);

                        break;
                    case "2":
                        telkkari.Kanavan_vaihto(2);

                        break;
                    case "3":
                        telkkari.Kanavan_vaihto(3);

                        break;
                    case "4":
                        Console.Write("Anna haluamasi äänen voimakkuus (%) > ");
                        int voimakkuus = Convert.ToInt32(Console.ReadLine());
                        telkkari.Aanen_voimakkuus(voimakkuus);
                        break;
                    case "5":
                        telkkari.on_paalla = false;
                        Console.WriteLine("Nyt telkkari on pois päältä.");

                        break;
                    default:
                        Menu(telkkari);
                        break;

                }
            } while (valinta != "5");

        }
    }
    class TV
    {
        int kanava { get; set; }
        int aani { get; set; }
        public bool on_paalla;
        public TV ()
        {
            this.kanava = 1;
            this.aani = 30;
            this.on_paalla = true;
            Tiedot();
            
        }
        void Tiedot()
        {
            Console.WriteLine("TV on {0}.",(this.on_paalla==true ? "päällä" : "pois päältä"));
            Console.WriteLine("TV äänen voimakkuus on {0} %", this.aani);
            Console.WriteLine("TV kanava: {0}", this.kanava);
        }
        public void Kanavan_vaihto(int num)
        {
            this.kanava = num;
            Tiedot();
        }
        public void Aanen_voimakkuus(int num)
        {
            this.aani = num;
            Tiedot();

        }
       

    }
}
