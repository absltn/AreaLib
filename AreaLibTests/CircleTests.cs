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
            Circle c1 = new Circle();

            //Assert
            Assert.IsTrue(c1.Name == "circle" && c1.Properties == 1);
        }

        [Test()]
        public void CalculateAreaTest()
        {
            //Arrange
            Circle c1 = new Circle();
            double[] values = { 1 };

            //Act
            double result = c1.CalculateArea(values);

            //Assert
            Assert.IsTrue(result == Shape.pi);
        }
    }
}