using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalculatorApp
{
    public class CalculatorTest
    {
        private Calculator calc1;

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
        }

        [Test]
        public void AddTest2()
        {
            // Add Test 2
            double a = -4;
            double b = -6.5;
            Assert.AreEqual(-10.5, calc1.Add(a, b));
        }

        [Test]
        public void AddTestOverload()
        {
            // added test, overload
            calc1.Accumulator = 4;
            calc1.Add(6);
            Assert.AreEqual(10, calc1.Accumulator);

            calc1.Add(2);
            Assert.AreEqual(12, calc1.Accumulator);

            calc1.Add(-2.3);
            Assert.AreEqual(9.7, calc1.Accumulator);
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
        }

        [Test]
        public void TestSubstract2()
        {
            // Substract Test 2
            double a = 62;
            double b = 20;
            Assert.AreEqual(42, calc1.Substract(a, b), 0.001);
        }

        [Test]
        public void TestSubstract3()
        {
            // Substract Test 3
            double a = -62;
            double b = -20;
            Assert.AreEqual(-42, calc1.Substract(a, b), 0.001);
        }

        [Test]
        public void TestSubstractOverload()
        {
            // substract test, overload
            calc1.Accumulator = 10;
            calc1.Substract(6);
            Assert.AreEqual(4, calc1.Accumulator);

            calc1.Substract(-2);
            Assert.AreEqual(6, calc1.Accumulator);

            calc1.Substract(2.5);
            Assert.AreEqual(3.5, calc1.Accumulator);
        }

        [Test]
        public void TestMultiply()
        {
            // Multiply Test 1
            double a = 2;
            double b = 3;
            Assert.AreEqual(6, calc1.Multiply(a, b));
        }

        [Test]
        public void TestMultiply2()
        {
            // Multiply Test 2
            double a = 2.5;
            double b = 3.5;
            Assert.AreEqual(8.75, calc1.Multiply(a, b));
        }

        [Test]
        public void TestMultiply3()
        {
            // Multiply Test 3
            double a = -2.5;
            double b = 3.5;
            Assert.AreEqual(-8.75, calc1.Multiply(a, b));
        }

        [Test]
        public void TestMultiplyOverload()
        {
            // multiply test, overload
            calc1.Accumulator = 10;
            calc1.Multiply(6);
            Assert.AreEqual(60, calc1.Accumulator);

            calc1.Multiply(-2);
            Assert.AreEqual(-120, calc1.Accumulator);

            calc1.Multiply(2.5);
            Assert.AreEqual(-300, calc1.Accumulator);
        }

        [Test]
        public void TestPower()
        {
            // Power Test 1
            double a = 2;
            double b = 3;
            Assert.AreEqual(8, calc1.Power(a, b));
        }

        [Test]
        public void TestPower2()
        {

            // Power Test 2
            double a = -2;
            double b = 3;
            Assert.AreEqual(-8, calc1.Power(a, b));
        }

        [Test]
        public void TestPower3()
        {
            // Power Test 3
            double a = 2;
            double b = -3;
            Assert.AreEqual(0.125, calc1.Power(a, b));
        }

        [Test]
        public void TestPower4()
        {
        // Power Test 4
       double a = 2.5;
        double b = 2;
        Assert.AreEqual(6.25, calc1.Power(a, b));
    }
    [Test]
    public void TestPowerOverload()
    {
    // power test, overload
            calc1.Accumulator = 2;
            calc1.Power(2);
            Assert.AreEqual(4, calc1.Accumulator);

            calc1.Power(-2);
            Assert.AreEqual(0.0625, calc1.Accumulator);

            calc1.Power(1.5);
            Assert.AreEqual(0.015625, calc1.Accumulator);
    }

        [Test]
        public void TestDivide()
        {
            // Divide Test 1
            double dividend = 6;
            double divisor = 2;
            Assert.AreEqual(3, calc1.Divide(dividend, divisor));
        }

        [Test]
        public void TestDivide2()
        {
            // Divide Test 2
            double dividend = -6.5;
            double divisor = 2.5;
            Assert.AreEqual(-2.6, calc1.Divide(dividend, divisor));
        }

        [Test]
        public void TestDivide3()
        {
            // Divide Test 3
            double dividend = -6;
            double divisor = -2;
            Assert.AreEqual(3, calc1.Divide(dividend, divisor));
        }

        [Test]
        public void TestDivideByZero()
        {
            double divided = 10;
            double divisor = 0;

            Assert.That( () =>calc1.Divide(0), Throws.TypeOf<DivideByZeroException>() );


        }


        [Test]
        public void TestDivideOverload()
        {
            // divide test, overload
            calc1.Accumulator = 10;
            calc1.Divide(2);
            Assert.AreEqual(5, calc1.Accumulator);

            calc1.Divide(-2);
            Assert.AreEqual(-2.5, calc1.Accumulator);

            calc1.Divide(2.5);
            Assert.AreEqual(-1, calc1.Accumulator);
        }

        [Test]
        public void TestAccumulator()
        {
            //get
            double a = calc1.Accumulator;
            Assert.AreEqual(0, a);

            // set
            calc1.Accumulator = 7;
            calc1.Accumulator = 7;
            calc1.Accumulator = 1;
            Assert.AreEqual(15, calc1.Accumulator);

            calc1.Accumulator = 1;
            Assert.AreEqual(16, calc1.Accumulator);

            // clear
            calc1.Clear();
            Assert.AreEqual(0, calc1.Accumulator);
        }
    }
}