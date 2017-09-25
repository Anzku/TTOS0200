using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T3
    {
        public static void Tehtava()
        {
            Vahvistin samsung = new Vahvistin();
            int newVolume;
            for (int i = 0; i < 10; i++)
            {
                VolumeNyt(samsung);

                newVolume = Ask();
                if (newVolume > 100)
                {
                    Console.WriteLine("-> Too much volume ");
                    samsung.changes(100);
                }
                else if (newVolume < 1)
                {
                    Console.WriteLine("-> Too low volume ");
                    samsung.changes(0);
                }
                    
                else samsung.changes(newVolume);
            }
        }
        public static void VolumeNyt(Vahvistin vahvistin)
        { Console.WriteLine("-> Amplifier volume is set to : " + vahvistin.Volume); }

        public static int Ask()
        {
            Console.Write("Give a new volume value (0-100) > ");
            int vastaus = Convert.ToInt32(Console.ReadLine());
            return vastaus;
        }
    }

    class Vahvistin
    {
        private int volume { get; set; }
        public Vahvistin()
        {
            this.volume = 10;
        }
        public int Volume
        {
            get { return volume; }
            set { volume = value; }  //value -sana on kieleen sisäänrakennettu 
        }
        public void changes(int uusiVolume)
        {
            if (this.volume > uusiVolume)
            {
                do
                {
                    this.volume--;
                    Console.WriteLine("Volume changing: " + this.volume);
                } while (this.volume > uusiVolume);

            }
            else if (this.volume < uusiVolume)
            {
                do
                {
                    this.volume++;
                    Console.WriteLine("Volume changing: " + this.volume);
                } while (this.volume < uusiVolume);

            }
        }

    }
}
