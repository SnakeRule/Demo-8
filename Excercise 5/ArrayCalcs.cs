/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 8.2.2016
*Author: Jere-Joonas Valtanen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5
{
    public class ArrayCalcs
    {
        // static method used for calculating the sum of all the doubles in the array
        public static double Sum(double[] array)
        {
            Console.WriteLine("Sum : {0:F2}",array.Sum());
            return array.Sum();
        }

        // static method used for calculating the average of all the doubles in the array
        public static double Average(double[] array)
        {
            Console.WriteLine("Ave : {0:F2}",array.Average());
            return array.Average();
        }

        // static method used to find the smallest value in the array
        public static double Min(double[] array)
        {
            Console.WriteLine("Min : {0:F2}",array.Min());
            return array.Min();
        }

        // static method used to find the largest value in the array
        public static double Max(double[] array)
        {
            Console.WriteLine("Max : {0:F2}", array.Max());
            return array.Max();
        }
    }
}
