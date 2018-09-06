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
        public void Deep_add(int a, int b, int result)
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
    }
}
