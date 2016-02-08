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
    class Program
    {
        static void Main(string[] args)
        {
            int rolls;

            Dice dice = new Dice();

            Console.Write("Enter how many times you'd like to roll the dice : ");
            rolls = int.Parse(Console.ReadLine());

            
            for(int i = 0; i < rolls; i++)
            {
                dice.DiceThrow();
            }

            dice.PrintDiceData(rolls);
        }
    }
}
