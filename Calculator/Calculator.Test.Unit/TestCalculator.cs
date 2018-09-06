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

        [Test]

        public void deep()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(2, 3), Is.EqualTo(5));
        }
    }
}
