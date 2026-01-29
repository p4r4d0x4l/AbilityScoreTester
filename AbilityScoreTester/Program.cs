using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "\nStarting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "\nDivide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "\nAdd amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "\nMinimum");

                calculator.CalculateAbilityScore();

                Console.WriteLine("\n\nCalculated ability score: " + calculator.Score);
                Console.WriteLine("\n\nPress Q to quit, any other key to continue");

                char keyChar = Console.ReadKey(true).KeyChar;

                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if (double.TryParse(line, out double value))
            {
                Console.WriteLine("\n    using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("\n    using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("\n    using value " + value);
                return value;
            } else
            {
                Console.WriteLine("\n    using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
