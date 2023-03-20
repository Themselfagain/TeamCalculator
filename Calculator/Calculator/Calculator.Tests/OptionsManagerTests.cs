using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class OptionsManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddShouldAddsAAndB()
        {
            //Arrange
            double a = 25;
            double b = 2;
            string expectedResult = "25 + 2 = 27";

            //Act
            string actualResult = OptionsManager.Add(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void ShouldSubtractAbsWoksProperly()
        {
            //Arrange
            double a = -25;
            double b = 2;
            string expectedResult = "|-25 - 2| = 27";

            //Act
            string actualResult = OptionsManager.SubtractAbs(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void MultiplyShoudMultiplyAAndB()
        {
            double a = 25;
            double b = 2;
            string expectedResult = "25 * 2 = 50";

            string actualResult = OptionsManager.Multiply(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SubtractShouldWork()
        {
            double a = 15;
            double b = 5;
            string ex = "15 - 5 = 10";
            string act = OptionsManager.Subtract(a, b);
            Assert.AreEqual(ex, act);
        }
        [Test]
        public void DevideShouldThrowException()
        {
            double a = 15;
            double b = 0;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Devide(a, b));
            Assert.AreEqual(ex.Message, "Is not devisible by zero");
        }
        [Test]
        public void DevideShouldWork()
        {
            double a = 15;
            double b = 3;
            var ex = "15 / 3 = 5";
            string act = OptionsManager.Devide(a, b);
            Assert.AreEqual(ex, act);
        }
        [Test]
        public void DevideReminderShouldWork()
        {
            double a = 15;
            double b = 4;
            var ex = "15 % 4 = 3";
            string act = OptionsManager.DevideReminder(a, b);
            Assert.AreEqual(ex, act);
        }
        [Test]
        public void SumSquaresShouldWork()
        {
            double a = 5;
            double b = 2;
            var ex = "25 + 4 = 29";
            string act = OptionsManager.SumSquares(a, b);
            Assert.AreEqual(ex, act);
        }
        public void MinimumShouldWorksProperly()
        {
            double a = 1;
            double b = -23;
            var ex = "Min(1,-23)=-23";
            string act = OptionsManager.Minimum(a, b);
            Assert.AreEqual(ex, act);
        }
        [Test]
        public void MaximumShouldWorksProperly()
        {
            double a = 1;
            double b = -23;
            var ex = "Max(1,-23)=1";
            string act = OptionsManager.Maximum(a, b);
            Assert.AreEqual(ex, act);
        }
        [Test]
        public void DevideReminderShouldThrowMessage()
        {
            double a = 15;
            double b = 0;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Devide(a, b));
            Assert.AreEqual(ex.Message, "Is not devisible by zero");
        }
        [Test]
        public void AverageShouldWork()
        {
            double a = 5;
            double b = 3;
            var ex = "Average(5,3)=4";
            string act = OptionsManager.Average(a, b);
            Assert.AreEqual(ex, act);
        }
        [Test]
        public void LogShouldThrowMessageWhenBaseIs0()
        {
            double a = 15;
            double b = 0;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Logarithm(a, b));
            Assert.AreEqual(ex.Message, "The base must be positive and different from 1");
        }
        [Test]
        public void LogShouldThrowMessageWhenBaseIsNegative()
        {
            double a = 15;
            double b = -5;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Logarithm(a, b));
            Assert.AreEqual(ex.Message, "The base must be positive and different from 1");
        }
        [Test]
        public void LogShouldThrowMessageWhenBaseIsOne()
        {
            double a = 15;
            double b = 1;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Logarithm(a, b));
            Assert.AreEqual(ex.Message, "The base must be positive and different from 1");
        }
        [Test]
        public void LogShouldWork()
        {
            double a = 1;
            double b = 23;
            var ex = OptionsManager.Logarithm(a, b);
            Assert.AreEqual(ex,"Log of 1 by base 23 = 0");
        }
        [Test]
        public void SumSquareRootsShouldThrowWhenNumberAIsNegative()
        {
            double a = -16;
            double b = 25;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.SumSquareRoots(a, b));
            Assert.AreEqual(ex.Message,"The numbers must be positive or 0") ;
        }
        [Test]
        public void SumSquareRootsShouldThrowWhenNumberBIsNegative()
        {
            double a = 16;
            double b = -25;
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.SumSquareRoots(a, b));
            Assert.AreEqual(ex.Message, "The numbers must be positive or 0");
        }
        [Test]
        public void SumSquareRootShouldWork()
        {
            double a = 25;
            double b = 16;
            var ex = OptionsManager.SumSquareRoots(a, b);
            Assert.AreEqual(ex, "Square root of 25 + square root of 16 = 9");
        }
        [Test]
        public void PowerShouldWork()
        {
            double a = 2;
            double b = 4;
            var ex = $"2 ^ 4 =16";
            string act = OptionsManager.Power(a, b);
            Assert.AreEqual(ex, act);
        }
    }
}