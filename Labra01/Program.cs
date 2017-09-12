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
            //Labra01.T6.Tehtava();
            //MakeSpace(5);
            //Labra01.T6.Tehtava();
            //Labra01.T9new.Tehtava();
            Console.Write("Valitse tehtävän numero (18) > ");
            int tehtava = Convert.ToInt32(Console.ReadLine());

            Labra01.T18.Tehtava();
            
            Console.Read();
        }
        static void MakeSpace(int x)
        {
            for (int i = 0; i < x; i++) Console.WriteLine();
        }
    }
    
}
