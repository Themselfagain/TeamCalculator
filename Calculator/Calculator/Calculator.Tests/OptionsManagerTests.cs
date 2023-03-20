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
            var ex = "15 : 4 = 3";
            string act = OptionsManager.DevideReminder(a, b);
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
    }
}