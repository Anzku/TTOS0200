using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra09
{
    public static class Game
    {
        public static Random rnd = new Random();
        public static string Viking(int draws)
        {
            return Lines(6,48,draws);
        }
        public static string Lotto(int draws)
        {
            return Lines(7, 40, draws);
        }
        public static string Eurojackpot(int draws)
        {
            return EJPLines(5, 50, draws);
        }
        static string Lines (int arvotaan, int max, int draws)
        {
            string text = "";
            //jokaiselle riville
            for (int row = 1; row<=draws;row++)
            {
                text += "Row " + row + ": ";
                bool[] array = new bool[max+1];
                
                //kuinko paljon numeroita pitää saada
                for (int i = 0; i < arvotaan; i++)
                {
                    int number = rnd.Next(1, max + 1);
                    if (!array[number]) array[number] = true;
                    else i--;
                }
                
                for (int i = 1; i <= max; i++)
                {
                    if (array[i])
                    {
                        text += i + " ";
                    }
                }
                text += "\n";
            }
            return text;
        }
        static string EJPLines(int arvotaan, int max, int draws)
        {
            string text = "";
            //jokaiselle riville
            for (int row = 1; row <= draws; row++)
            {
                text += "Row " + row + ": ";
                bool[] array = new bool[max + 1];

                //kuinko paljon numeroita pitää saada
                for (int i = 0; i < arvotaan; i++)
                {
                    int number = rnd.Next(1, max + 1);
                    if (!array[number]) array[number] = true;
                    else i--;
                }

                for (int i = 1; i <= max; i++)
                {
                    if (array[i])
                    {
                        text += i + " ";
                    }
                }
                //2 tähtinumeroa
                int a = rnd.Next(1, 11);
                int b;
                do
                {
                    b = rnd.Next(1, 11);
                } while (b == a);
                
                text += a+" "+b+"\n";
            }
            return text;
        }
    }
}
