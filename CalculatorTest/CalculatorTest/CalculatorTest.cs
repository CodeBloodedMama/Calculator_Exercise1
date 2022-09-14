using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalculatorApp
{
    public class CalculatorTest
    {
        private Calculator calc1;

        //private Calculator calc2;
        //private Calculator calc3;

        [SetUp]
        protected void SetUp()
        {
            calc1 = new Calculator();
        }

        [Test]
        public void AddTest()
        {
            // Test 1
            double a = 2.3;
            double b = 3.2;
            Assert.AreEqual(5.5, calc1.Add(a, b));
           
            // Test 2
            a = -4;
            b = -6.5;
            Assert.AreEqual(-10.5, calc1.Add(a, b));
        }

        [Test]
        public void TestAddTypes()
        {
            int a = 2;
            int b = 3;
            Assert.AreEqual(5, calc1.Add(a, b));

        }

        [Test]
        public void TestSubstract()
        {
            double a = 2.3;
            double b = 3.2;
            Assert.AreEqual(-0.9, calc1.Substract(a, b), 0.001);

            a = 62;
            b = 20;
            Assert.AreEqual(42, calc1.Substract(a, b), 0.001);
        }

        [Test]
        public void TestMultiply()
        {
            double a = 2;
            double b = 3;
            Assert.AreEqual(6, calc1.Multiply(a, b));
        }

        [Test]
        public void TestPower()
        {
            double a = 2;
            double b = 3;
            Assert.AreEqual(8, calc1.Power(a, b));
        }

        [Test]
        public void TestAccumulator()
        {
            //get
            double a = calc1.Accumulator;
            Assert.AreEqual(0,a);

            // set
            calc1.Accumulator = 7;
            calc1.Accumulator = 7;
            Assert.AreEqual(14,calc1.Accumulator);

            // clear
            calc1.Clear();
            Assert.AreEqual(0,calc1.Accumulator);
        }
    }
}