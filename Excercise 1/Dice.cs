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

namespace Excercise_1
{
    class Dice
    {
        Random rand = new Random();

        private int DiceNum { get; set; }
        private double DiceAve { get; set; }

        // used for calculating how many of each dice number has been thrown
        private double Ones { get; set; }
        private double Twos { get; set; }
        private double Threes { get; set; }
        private double Fours { get; set; }
        private double Fives { get; set; }
        private double Sixes { get; set; }

        public void DiceThrow()
        {
            DiceNum = rand.Next(1, 7); // This is where the dice is rolled

            switch (DiceNum) // depending on what was rolled, a 1 is added to the specified int
            {
                case 1: Ones++; break;

                case 2: Twos++; break;

                case 3: Threes++; break;

                case 4: Fours++; break;

                case 5: Fives++; break;

                case 6: Sixes++; break;
            }
        }

        public void PrintDiceData(int rolls)
        {
            // Calculating the average from all the dice throws. the rolls value is brought in from the main program
            DiceAve = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives * 5) + (Sixes * 6)) / rolls;

            Console.WriteLine("Average is : " + DiceAve);
            Console.WriteLine("1 was thrown {0} times", Ones);
            Console.WriteLine("2 was thrown {0} times", Twos);
            Console.WriteLine("3 was thrown {0} times", Threes);
            Console.WriteLine("4 was thrown {0} times", Fours);
            Console.WriteLine("5 was thrown {0} times", Fives);
            Console.WriteLine("6 was thrown {0} times", Sixes);
        }

    }
}
