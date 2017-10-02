using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T6
    {
        public static void Tehtava() {
            Radio testiRadio = new Radio();
            RadioTest(testiRadio);
        }
        public static void RadioTest(Radio radio)
        {
            Console.WriteLine(radio);
            radio.Power();
            radio.Kanava = 29100.5;
            radio.Kanava = 100.0;
            radio.Kanava = 23000;
            radio.Volume = 150;
            radio.Volume = -5;
            radio.Volume = 45;
            Console.WriteLine(radio);
            radio.Power();

        }
        
    }
    class Radio
    {
        private int volume { get; set; } // 0-100%
        private bool paala { get; set; } // onko se päällä vai pois päältä
        private double kanava { get; set; } // 2000.0 - 26000.0
        private double minKanava = 2000.0;
        private double maxKanava = 26000.0;
        public Radio()
        {
            volume = 30;
            paala = false;
            kanava = 10000.0;
            Console.WriteLine("Uusi Radio on syntynyt");
        }
        public override string ToString()
        {

            string onOff = paala ? onOff = "Radio on päällä." : "Radio on pois päältä.";
            return onOff + " Äänen voimakkuus asenettu: " + volume + "%. Kanava: " + kanava+"\n";
        }
        private int TarkastettuIntArvo(int min, int max, int value)
        {
            if (value>max)
            {
                Console.WriteLine(value + " on liian iso arvo. Asennettaan arvo "+max);
                return max;
            }
            else if (value<min)
            {
                Console.WriteLine(value + " on liian pieni arvo. Asennettaan arvo "+min);
                return min;
            }
            else return value;
        }
        private double TarkastettuDoubleArvo(double min, double max, double value)
        {
            if (value > max)
            {
                Console.WriteLine(value + " on liian iso arvo.");
                return max;
            }
            else if (value < min)
            {
                Console.WriteLine(value + " on liian pieni arvo.");
                return min;
            }
            else {
                //Console.WriteLine("Äänenvoimakkuus - Asennettaan uuden arvon: " + value);
                return value;
            }
        }
        public int Volume
        {
            get { return volume; }
            set {
                Console.WriteLine("Yritetään asenta äänenvoimakkuus: " + value + "%");
                volume = TarkastettuIntArvo(0,100,value);
                Console.WriteLine("Äänenvoimakkuus " + volume + "% asenettu\n");
            }
        }
        public double Kanava
        {
            get { return kanava; }
            set {
                Console.WriteLine("Yritetään asenta kanava: " + value);
                kanava = TarkastettuDoubleArvo(this.minKanava, this.maxKanava, value);
                Console.WriteLine("Kanava " + kanava + " asenettu\n");
            }
        }
        public void Power()
        {
            if (paala)
            {
                paala = false;
                Console.WriteLine("Olemme laittaneet radion pois päältä.");
            }
            else
            {
                paala = true;
                Console.WriteLine("Olemme laittaneet radion päälle.");
            }
        }
    }
}
