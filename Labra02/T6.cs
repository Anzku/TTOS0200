using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T6
    {
        
        
        
        
        
        public static void Tehtava()
        {
            Menu();
        }
        
        public static void Menu()
        {
            int valinta = 0;
            do
            {

                Console.WriteLine("\nCoffee machine. \nYour selection please:");
                Console.WriteLine("1. Macchiato");
                Console.WriteLine("2. Piccolo Latte");
                Console.WriteLine("3. Espresso");
                Console.WriteLine("4. Melange");
                Console.WriteLine("5. Cappuccino");
                Console.WriteLine("6. Off");
                valinta = Convert.ToInt32(Console.ReadLine());
                switch (valinta)
                {
                    case 1:
                        Kahvi_ohjelma macchiato = new Kahvi_ohjelma(60, 15, 0);
                        macchiato.Tekee_kahvi();
                        break;
                    case 2:
                        Kahvi_ohjelma piccolo_latte = new Kahvi_ohjelma(50, 50, 0);
                        
                        piccolo_latte.Tekee_kahvi();
                        break;
                    case 3:
                        Kahvi_ohjelma espresso = new Kahvi_ohjelma(30, 0, 0);
                        
                        espresso.Tekee_kahvi();
                        break;
                    case 4:
                        Kahvi_ohjelma melange = new Kahvi_ohjelma(50, 20, 10);
                        melange.Tekee_kahvi();
                        break;
                    case 5:
                        Kahvi_ohjelma cappuccino = new Kahvi_ohjelma(30, 60, 0);
                        cappuccino.Tekee_kahvi();
                        break;
                    case 6:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Menu();
                        break;

                }

            } while (valinta != 6);
        }
        
    }
    class Kahvi_ohjelma
    {
        int maidon_maara;
        int kahvin_maara;
        int kerman_maara;
        public int sokeri;
        public Kahvi_ohjelma (int kahvi, int maito, int kerma)
        {
            this.maidon_maara = maito;
            this.kahvin_maara = kahvi;
            this.kerman_maara = kerma;
        }
        void Kysy_sokerista()
        {
            Console.Write("Kuinko paljon sokeria haluaisit? (lusikallista) > ");
            this.sokeri = Convert.ToInt32(Console.ReadLine());
            
        }

        public void Tekee_kahvi()
        {
            Kysy_sokerista();
            Console.WriteLine(this);

        }
        public override string ToString()
        {
            return "\nCoffee machine starts making coffee. \nIngridients: coffee - " + this.kahvin_maara + " ml,\nmilk - " + this.maidon_maara + " ml,\ncream - " + this.kerman_maara + " ml,\nsugar - " + this.sokeri + " spoons\nCoffee is ready!";
        }
    }
}
