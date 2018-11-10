using NUnit.Framework;
using AreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Tests
{
    [TestFixture()]
    public class Triangle_3sTests
    {
        [Test()]
        public void Triangle_3sTest()
        {
            //Arrange /Act
            Triangle_3s t1 = new Triangle_3s();

            //Assert
            Assert.IsTrue(t1.Name == "triangle_3s" && t1.Properties == 3);
        }

        [Test()]
        public void CalculateAreaTest()
        {
            //Arrange
            Triangle_3s t1 = new Triangle_3s();
            double[] values = {3,4,5};

            //Act
            double result = t1.CalculateArea(values);

            //Assert
            Assert.IsTrue(result == 6);
        }

        [Test()]
        public void InvalidArgumentTest()
        {
            //Arrange
            Triangle_3s t1 = new Triangle_3s();
            double[] values = { 1, 10, 5 };

            //Act
            var ex = Assert.Throws<ArgumentException>(() => t1.CalculateArea(values));

            //Assert
            Assert.That(ex.Message, Is.EqualTo("This is not a valid triangle"));
        }
    }
}