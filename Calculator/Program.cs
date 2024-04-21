using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SimpleCalculator();

            Console.WriteLine(calculator.Add(12, 12));
            Console.WriteLine(calculator.Subtract(12, 12));
            Console.WriteLine(calculator.Multiply(12, 12));
            Console.WriteLine(calculator.Divide(12, 12));
            Console.WriteLine(calculator.Mod(42, 7));

        }
    }
}
