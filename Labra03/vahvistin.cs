using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    public class Vahvistin1
    {
        private readonly int Maxvolume = 100;
        private readonly int Minvolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= Maxvolume && value >= Minvolume) volume = value;
                else if (value > Maxvolume)
                {
                    Console.WriteLine("Ikkunat paukkuu, laita hiljemmallee :D");
                    volume = Maxvolume;
                }
                else if (value < Minvolume)
                {
                    Console.WriteLine("Ootko mies vai hiiri? Laita kovemmallee :D");
                    volume = Minvolume;
                }
            }
        }
    }
    class TestaaVahvari
    {
        Vahvistin1 bubu = new Vahvistin1();
        

    }
}
