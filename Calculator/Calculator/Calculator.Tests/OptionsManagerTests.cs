using NUnit.Framework;

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
    }
}