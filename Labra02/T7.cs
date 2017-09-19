using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T7
    {
        public static void Tehtava()
        {
            int valinta = 0;
            int kappale = 1;
            CD disk = new CD();
            do
            {
                Console.WriteLine("CD levy on soitimissa. Sinun valinta:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Change the song");
                Console.WriteLine("4. Eject");
                Console.WriteLine("5. Off");
                valinta = Convert.ToInt32(Console.ReadLine());
                switch (valinta)
                {
                    case 1:
                        disk.Play(kappale);
                        break;
                    case 2:
                        disk.Stop();
                        break;
                    case 3:
                        Console.Write("Type the number of song (1-5) > ");
                        kappale = Convert.ToInt32(Console.ReadLine());
                        Console.Write("You choosed song #" + kappale + ": '" + disk.soittolista[kappale]);
                        disk.Play(kappale);
                        break;
                    case 4:
                        Console.Write("Eject. Good bye!");
                        System.Environment.Exit(1);
                        break;

                    default:
                        break;
                }

            } while (valinta != 5);
            Console.WriteLine("CD soitin on pois päältä");
        }
    }
    class CD
    {
        public string[] soittolista = new string[] { "Stop", "Endless Forms Most Beautiful", "The Greatest Show on Earth", "Elan", "Weak Fantasy", "Alpenglow" };
        int soittaa_nyt = 0; // 0-mitään ei soita
        public void Play(int kappale)
        {
            this.soittaa_nyt = kappale;
                
            Console.WriteLine("Play! Nyt soittaa kappale: '"+this.soittolista[kappale]+"'");
        }
        public void Stop()
        {
            this.soittaa_nyt = 0;
            Console.WriteLine("Stop! Ei ole toistoa");
        }
        public override string ToString()
        {
            string soittotilanne;
            if (this.soittaa_nyt == 0) soittotilanne = "Now playing: " + this.soittolista[this.soittaa_nyt];
            else soittotilanne = "Stop";
            return soittotilanne;
        }
    }
}
