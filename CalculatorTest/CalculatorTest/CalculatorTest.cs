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
            // Add Test 1
            double a = 2.3;
            double b = 3.2;
            Assert.AreEqual(5.5, calc1.Add(a, b));
           
            // Add Test 2
            a = -4;
            b = -6.5;
            Assert.AreEqual(-10.5, calc1.Add(a, b));

            // added test, overload
            calc1.Accumulator = 4;
            double added = 6;
            Assert.AreEqual(10, calc1.Accumulator + added);
        }

        [Test]
        public void TestAddTypes()
        {
            // Add Test 3
            int a = 2;
            int b = 3;
            Assert.AreEqual(5, calc1.Add(a, b));

        }

        [Test]
        public void TestSubstract()
        {
            // Substract Test 1
            double a = 2.3;
            double b = 3.2;
            Assert.AreEqual(-0.9, calc1.Substract(a, b), 0.001);

            // Substract Test 2
            a = 62;
            b = 20;
            Assert.AreEqual(42, calc1.Substract(a, b), 0.001);

            // Substract Test 3
            a = -62;
            b = -20;
            Assert.AreEqual(-42, calc1.Substract(a, b), 0.001);

            // substract test, overload
            calc1.Accumulator = 4;
            double substractor = 1;
            Assert.AreEqual(3, calc1.Accumulator - substractor);
        }

        [Test]
        public void TestMultiply()
        {
            // Multiply Test 1
            double a = 2;
            double b = 3;
            Assert.AreEqual(6, calc1.Multiply(a, b));

            // Multiply Test 2
            a = 2.5;
            b = 3.5;
            Assert.AreEqual(8.75, calc1.Multiply(a, b));

            // Multiply Test 1
            a = -2.5;
            b = 3.5;
            Assert.AreEqual(-8.75, calc1.Multiply(a, b));

            // multiply test, overload
            calc1.Accumulator = 4;
            double multiplier = 5;
            Assert.AreEqual(20, calc1.Accumulator * multiplier);
        }

        [Test]
        public void TestPower()
        {
            // Power Test 1
            double a = 2;
            double b = 3;
            Assert.AreEqual(8, calc1.Power(a, b));

            // Power Test 2
            a = -2;
            b = 3;
            Assert.AreEqual(-8, calc1.Power(a, b));

            // Power Test 3
            a = 2;
            b = -3;
            Assert.AreEqual(0.125, calc1.Power(a, b));

            // Power Test 4
            a = 2.5;
            b = 2;
            Assert.AreEqual(6.25, calc1.Power(a, b));

            // power test, overload
        }

        [Test]
        public void TestDivide()
        {
            // Divide Test 1
            double dividend = 6;
            double divisor = 2;
            Assert.AreEqual(3,calc1.Divide(dividend,divisor));

            // Divide Test 2
            dividend = -6.5;
            divisor = 2.5;
            Assert.AreEqual(-2.6, calc1.Divide(dividend, divisor));

            // Divide Test 3
            dividend = -6;
            divisor = -2;
            Assert.AreEqual(3, calc1.Divide(dividend, divisor));

            // divide test, overload
            calc1.Accumulator = 4;
            double divisor = 2.5;
            Assert.AreEqual(1.6, calc1.Accumulator / divisor);
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