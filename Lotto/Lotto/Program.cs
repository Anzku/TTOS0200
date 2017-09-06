using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        
        static void DrawLotto()
        {
            bool[] numerot = new bool[40];
            int hits;
            int lkm;
            int nro;
            Random rnd;
            string rivi;
            Console.Write("Anna arvottavien rivien määrä > ");
            lkm = int.Parse(Console.ReadLine());
            //arvotaan rivit
            rnd = new Random();
            for (int i = 0; i<lkm; i++)
            {
                hits = 0;
                do
                {
                    nro = rnd.Next(0, 40);
                    if (numerot[nro]==false)
                    {
                        numerot[nro] = true;
                        hits++;
                    }
                } while (hits < 7);
                //näytetään arvotut numerot
                rivi = string.Format("Rivi {0}: ", (i+1));
                for (int j = 0; j < 40; j++)
                {
                    if (numerot[j])
                    {
                        rivi += (j + 1).ToString() + " ";
                    }
                }
                Console.WriteLine(rivi);
                //tyhjätään edellisen arvonnan True eli liput alas
                numerot = new bool[40];
            }

            /*
            
            int rivit = Console.Read();
            int[] number = new int[40];
            int luku;
            Random r = new Random();
            for (int j=0; j<rivit; j++)
            {
                Console.Write("Rivi " + (j + 1)+": ");
                for (int i = 0; i < 7; i++)
                {
                    do
                    {
                        luku = r.Next(1, 40);
                    }
                    while (number[luku] == 1);
                    number[luku] = 1;
                    Console.Write(luku + " ");
                }
                Console.WriteLine();
            }*/

        }
        static void Main(string[] args)
        {
            
            DrawLotto();
            Console.Read();
        }
    }
}
