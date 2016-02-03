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

        private double Ones { get; set; }
        private double Twos { get; set; }
        private double Threes { get; set; }
        private double Fours { get; set; }
        private double Fives { get; set; }
        private double Sixes { get; set; }

        public void DiceThrow()
        {
            DiceNum = rand.Next(1, 7);

            switch (DiceNum)
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
