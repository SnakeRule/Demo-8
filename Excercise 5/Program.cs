using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            ArrayCalcs.Sum(array);

            ArrayCalcs.Average(array);

            ArrayCalcs.Min(array);

            ArrayCalcs.Max(array);

        }
    }
}
