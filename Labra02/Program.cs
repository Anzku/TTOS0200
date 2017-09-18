using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int tehtava;
                do
                {
                    Console.Write("Valitse tehtävän numero (1 - 7) > ");
                    tehtava = 99;
                    tehtava = Convert.ToInt32(Console.ReadLine());
                    switch (tehtava)
                    {
                        case 1:
                            Labra02.T1.Tehtava();
                            break;
                        case 2:
                            Labra02.T2.Tehtava();
                            break;
                        case 3:
                            Labra02.T3.Tehtava();
                            break;
                        case 4:
                            Labra02.T4.Tehtava();
                            break;/*
                        case 5:
                            Labra02.T5.Tehtava();
                            break;
                        case 6:
                            Labra02.T6.Tehtava();
                            break;
                        case 7:
                            Labra02.T7.Tehtava();
                            break;
                       */
                        default:
                            Labra02.T2.Tehtava();
                            break;

                    }
                    

                } while (tehtava != 0);


                Console.Read();

            
        }
    }
}
