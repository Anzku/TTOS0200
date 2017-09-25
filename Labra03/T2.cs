using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T2
    {
        public static void Tehtava()
        {
            Hissi dynamo = new Hissi();
            int uusiKerros;
            for (int i=0;i<10;i++)
            {
                MissaHissiOn(dynamo);
                
                uusiKerros = Ask();
                if (uusiKerros > 5) Console.WriteLine("There are only 5 floors in the building");
                else if (uusiKerros < 1) Console.WriteLine("The building doesn't have underground floors.");
                else dynamo.liikkuu(uusiKerros); 
            }
        }
        public static void MissaHissiOn(Hissi hissi)
        { Console.WriteLine("Elevator is now in floor:" + hissi.Floor); }

        public static int Ask()
        {
            Console.Write("Give a new floor number (1-5) > ");
            int vastaus = Convert.ToInt32(Console.ReadLine());
            return vastaus;
        }
    }
        
    class Hissi
    {
        private int kerros { get; set; }
        public Hissi () {
            this.kerros = 1;
        }
        public int Floor
        {
            get { return kerros; }
            set { kerros = value; }  //value -sana on kieleen sisäänrakennettu 
        }
        public void liikkuu (int uusiKerros)
        {
            if (this.kerros > uusiKerros)
            {
                do
                {
                    this.kerros--;
                    Console.WriteLine("Hissi liikkuu alas kerrokselle " + this.kerros);
                } while (this.kerros > uusiKerros);
                
            }
            else if (this.Floor < uusiKerros)
            {
                do
                {
                    this.Floor = this.Floor+1;
                    Console.WriteLine("Hissi liikkuu ylös kerrokselle " + this.kerros);
                } while (this.Floor < uusiKerros);

            }
        }
        
    }
}
