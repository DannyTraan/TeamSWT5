using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            try
            {
                var result = dividend / divisor;
                Accumulator = result;
                return result;
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine($"Attempted to divide the dividend {dividend} by zero...\n");
                Accumulator = 0;
                return 0;
            }

        }

        public double Divide(double divisor)
        {
            try
            {
                var result = Accumulator / divisor;
                Accumulator = result;
                return result;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine($"Attempted to divide the dividend {Accumulator} by zero...\n");
                Accumulator = 0;
                return 0;
            }
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
