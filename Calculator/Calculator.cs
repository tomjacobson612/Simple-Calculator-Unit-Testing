using EnsureThat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class SimpleCalculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public int Divide(int first, int second)
        {
            Ensure.That(second, nameof(second)).IsNot(0);
            //Guard.IsNotEqualTo(0, second, nameof(second)); 
            return first / second;
        }

        public int Mod(int first, int second)
        {
            return first % second;
        }
    }
}
