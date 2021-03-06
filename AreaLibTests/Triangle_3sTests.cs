﻿using NUnit.Framework;
using System;


namespace AreaLib.Tests
{
    [TestFixture()]
    public class Triangle_3sTests
    {
        [Test()]
        public void Triangle_3sTest()
        {
            //Arrange /Act
            Triangle_3s testTriangle_3s = new Triangle_3s();

            //Assert
            Assert.IsTrue(testTriangle_3s.Name == "triangle_3s" && testTriangle_3s.Properties == 3);
        }

        [Test()]
        public void CalculateAreaTest()
        {
            //Arrange
            Triangle_3s testTriangle_3s = new Triangle_3s();
            double[] values = {3,4,5};

            //Act
            double result = testTriangle_3s.CalculateArea(values);

            //Assert
            Assert.IsTrue(result == 6);
        }

        [Test()]
        public void CalculateAreaViaCalcTest()
        {
            //Arrange

            AreaCalculator calcTest = new AreaCalculator();
            double[] values = { 3, 4, 5 };

            //Act
            double result = calcTest.Calculate("triangle_3s",values);

            //Assert
            Assert.IsTrue(result == 6);
        }

        [Test()]
        public void InvalidArgumentTest()
        {
            //Arrange
            Triangle_3s testTriangle_3s = new Triangle_3s();
            double[] values = { 1, 10, 5 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => testTriangle_3s.CalculateArea(values));
            Assert.That(ex.Message, Is.EqualTo("This is not a valid triangle"));
        }

        [Test()]
        public void IsRightTest_ex()
        {
            //Arrange
            Triangle_3s testTriangle_3s = new Triangle_3s();
            double[] values = { 1, 10, 5 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => testTriangle_3s.CalculateArea(values));
            Assert.That(ex.Message, Is.EqualTo("This is not a valid triangle"));
        }

        [Test()]
        public void IsRightTest_true()
        {
            //Arrange
            Triangle_3s testTriangle_3s = new Triangle_3s();
            double[] values = { 3, 4, 5 };

            //Act /Assert
            Assert.IsTrue(testTriangle_3s.isRightTriangle(values) == true);
        }

        [Test()]
        public void IsRightTest_exception()
        {
            //Arrange
            Triangle_3s testTriangle_3s = new Triangle_3s();
            double[] values = { 3, 10, 5 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => testTriangle_3s.isRightTriangle(values));
            Assert.That(ex.Message, Is.EqualTo("This is not a valid triangle"));
        }

        [Test()]
        public void IsRightTest_false()
        {
            //Arrange
            Triangle_3s testTriangle_3s = new Triangle_3s();
            double[] values = { 3, 4, 4 };

            //Act /Assert
            Assert.IsTrue(testTriangle_3s.isRightTriangle(values) == false);
        }
    }
}