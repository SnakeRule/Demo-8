using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5
{
    public class ArrayCalcs
    {
        public static double Sum(double[] array)
        {
            Console.WriteLine("Sum : {0:F2}",array.Sum());
            return array.Sum();
        }

        public static double Average(double[] array)
        {
            Console.WriteLine("Ave : {0:F2}",array.Average());
            return array.Sum();
        }

        public static double Min(double[] array)
        {
            Console.WriteLine("Min : {0:F2}",array.Min());
            return array.Min();
        }

        public static double Max(double[] array)
        {
            Console.WriteLine("Max : {0:F2}", array.Max());
            return array.Max();
        }
    }
}
