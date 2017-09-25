using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                T2.Tehtava();
                Console.Write("Press 1, if you want to continue > ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x > 0);
            
        }
    }
}
