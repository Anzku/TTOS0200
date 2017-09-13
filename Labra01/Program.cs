using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class Program
    {
        static void Main(string[] args)
        {
            int tehtava;
            do
            {
                Console.Write("Valitse tehtävän numero (1 - 18) > ");
                tehtava = 99;
                tehtava = Convert.ToInt32(Console.ReadLine());
                switch (tehtava)
                {
                    case 1:
                        Labra01.T1.Tehtava();
                        break;
                    case 2:
                        Labra01.T2.Tehtava();
                        break;
                    case 3:
                        Labra01.T3.Tehtava();
                        break;
                    case 4:
                        Labra01.T4.Tehtava();
                        break;
                    case 5:
                        Labra01.T5.Tehtava();
                        break;
                    case 6:
                        Labra01.T6.Tehtava();
                        break;
                    case 7:
                        Labra01.T7.Tehtava();
                        break;
                    case 8:
                        Labra01.T8.Tehtava();
                        break;
                    case 9:
                        Labra01.T9new.Tehtava();
                        break;
                    case 10:
                        Labra01.T10.Tehtava();
                        break;
                    case 11:
                        Labra01.T11.Tehtava();
                        break;
                    case 12:
                        Labra01.T12.Tehtava();
                        break;
                    case 13:
                        Labra01.T13.Tehtava();
                        break;
                    case 14:
                        Labra01.T14.Tehtava();
                        break;
                    case 15:
                        Labra01.T15.Tehtava();
                        break;
                    case 16:
                        Labra01.T16.Tehtava();
                        break;
                    case 17:
                        Labra01.T17.Tehtava();
                        break;
                    case 18:
                        Labra01.T18.Tehtava();
                        break;
                    default:
                        Labra01.T18.Tehtava();
                        break;

                }
                MakeSpace(5);
                
            } while (tehtava != 0);
            
            
            Console.Read();
            
        }
        static void MakeSpace(int x)
        {
            for (int i = 0; i < x; i++) Console.WriteLine();
        }
        static void Menu()
        {

        }
    }
    
}
