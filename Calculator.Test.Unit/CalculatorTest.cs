using NUnit.Framework;
using NUnit.Framework.Internal;


namespace CalculatorUnitTests
{

    public class CalculatorTest
    {
        private CalculatorApp.Calculator calc1;
        private CalculatorApp.Calculator calc2;

        [SetUp]
        protected void SetUp()
        {
            calc1 = new CalculatorApp.Calculator();
        }

        [Test]
        public void AddTest()
        {
            double a = 2.3;
            double b = 3.2;
            Assert.AreEqual(5.5, calc1.Add(a, b));
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
            double a = 3;
            double b = 2;
            Assert.AreEqual(1, calc1.Substract(a, b));

            a = 62;
            b = 20;
            Assert.AreEqual(42, calc1.Substract(a, b));
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
    }
}