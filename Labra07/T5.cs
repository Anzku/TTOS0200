using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra07
{
    class T5
    {
        public static void Test()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            ArrayCalcs calcs = new ArrayCalcs(array);
        }
    }
    class ArrayCalcs
    {
        public ArrayCalcs(double[] array)
        {
            Sum(array);
            Ave(array);
            Min(array);
            Max(array);
        }
        
        public static void Sum(double[] array)
        {
            double sum = 0;
            foreach (double num in array)
            {
                sum += num;
            }
            Console.WriteLine( "Sum=" + sum);
        }
        public static void Ave(double[] array)
        {
            double sum = 0;
            int count = array.Length;
            foreach (double num in array)
            {
                sum += num;
            }
            Console.WriteLine("Ave=" + (sum/count));
        }
        public static void Min(double[] array)
        {
            double min = array[0];
            
            foreach (double num in array)
            {
                if (num < min) min = num;
            }
            Console.WriteLine("Min=" + min);
        }
        public static void Max(double[] array)
        {
            double max = array[0];
            foreach (double num in array)
            {
                if (num > max) max = num;
            }
            Console.WriteLine("Max=" + max);
        }
    }
}
