using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    class TestCalculator
    {
        private Calculator uut_;

        [SetUp]
        public void Setup()
        {
            uut_ = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(5, 5, 10)]
        [TestCase(20, 80, 100)]
        [TestCase(-50, 20, -30)]
        public void Deep_Add(int a, int b, int result)
        {
            Assert.That(uut_.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(20, 7, 13)]
        [TestCase(-5, -2, -3)]
        [TestCase(17, 64, -47)]
        [TestCase(2, 3, -1)]
        public void Deep_Subtract(int a, int b, int result)
        {
            Assert.That(uut_.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(5, 2, 10)]
        [TestCase(0, 64, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(3, -2, -6)]
        public void Deep_Multiply(int a, int b, int result)
        {
            Assert.That(uut_.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 4, 16)]
        [TestCase(8, 2, 64)]
        [TestCase(1, 10, 1)]
        [TestCase(92, 0, 1)]
        public void Deep_Power(int x, int exp, int result)
        {
            Assert.That(uut_.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(10, 5, 2)]
        [TestCase(0, 2, 0)]
        [TestCase(-4, 2, -2)]
        [TestCase(100, 100, 1)]
        public void Deep_Divide(int dividend, int divisor, int result)
        {
            Assert.That(uut_.Divide(dividend, divisor), Is.EqualTo(result));
        }

        [TestCase(16, 2, 2, 4)]
        [TestCase(0, 2, 2, 0)]
        [TestCase(-4, 2, 2, -1)]
        [TestCase(-12, 2, -3, 2)]
        public void Deep_Divide2(double a, double b,
            double c, double d)
        {
            uut_.Divide(a, b);
            Assert.That(uut_.Divide(c), Is.EqualTo(d));
        }
    }
}
