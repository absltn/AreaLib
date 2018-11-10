using NUnit.Framework;
using AreaLib;

namespace AreaLib.Tests
{
    [TestFixture()]
    public class CircleTests
    {
        [Test()]
        public void CircleTest()
        {
            //Arrange /Act
            Circle testCircle = new Circle();

            //Assert
            Assert.IsTrue(testCircle.Name == "circle" && testCircle.Properties == 1);
        }

        [Test()]
        public void CalculateAreaTest()
        {
            //Arrange
            Circle testCircle = new Circle();
            double[] values = { 1 };

            //Act
            double result = testCircle.CalculateArea(values);

            //Assert
            Assert.IsTrue(result == Shape.pi);
        }
    }
}