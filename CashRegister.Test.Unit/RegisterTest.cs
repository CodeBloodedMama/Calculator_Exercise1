using System;
using NUnit.Framework;

namespace CashRegister.Test.Unit
{
    [TestFixture]
    public class RegisterTests
    {
        private Register uut;

        [SetUp]
        public void Setup()
        {
            uut = new Register();
        }

        [Test]
        public void AddItem_OneItem_NoOfItemsIs1()
        {
            // Arrange

            // Act
            uut.AddItem(12.50);

            // Assert
            Assert.That(uut.GetNoOfItems(), Is.EqualTo(1));
        }

        [Test]
        public void AddItem_OneItem_TotalIsCorrect()
        {
            // Arrange

            // Act
            uut.AddItem(13.45);

            // Assert
            Assert.That(uut.GetTotal(), Is.EqualTo(13.45));
        }

        [Test]
        public void AddItem_TwoItems_NoOfItemsIs2()
        {
            // Act
            uut.AddItem(11.22);
            uut.AddItem(22.33);

            // Assert
            Assert.That(uut.NoOfItems, Is.EqualTo(2));
        }

        [Test]
        public void AddItem_TwoItems_TotalIsCorrect()
        {
            // Act
            uut.AddItem(11.22);
            uut.AddItem(22.33);

            // Assert
            Assert.That(uut.GetTotal(), Is.EqualTo(33.55).Within(0.005));
        }

        [Test]
        public void ctor_NoItemsAdded_NoOfItemsIsZero()
        {
            // Arrange er i SetUp
            // Act - der skal ikke være nogen act
            // Assert
            Assert.That(uut.NoOfItems, Is.Zero);
        }

        [Test]
        public void ctor_NoItemsAdded_TotalIsZero()
        {
            // Arrange er i setup
            // Act - der skal ikke gøres noget
            // Assert
            Assert.That(uut.GetTotal(), Is.Zero);
        }

        [Test]
        public void AddItem_NegativeItem_Throws()
        {
            // Act + Assert
            Assert.That(() => uut.AddItem(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void AddItem_BigItem_Throws()
        {
            // Act + Assert
            Assert.That(() => uut.AddItem(10001), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void SubtractItem_EmptyAndNegativeItem_NoChanges()
        {
            uut.SubtractItem(-10);

            Assert.That(uut.GetTotal(), Is.EqualTo(0));
        }

        [Test]
        public void SubtractItem_OneItemAndNegativeItem_CorrectTotal()
        {
            uut.AddItem(10);
            uut.SubtractItem(-10);

            Assert.That(uut.GetTotal(), Is.EqualTo(0));
        }
    }
}