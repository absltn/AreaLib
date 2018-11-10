﻿using NUnit.Framework;
using System;

namespace AreaLib.Tests
{
    // new shape stub
    public class NewShape : Shape
    {
        public NewShape()
        {
            Name = "test";
            Properties = 2;
        }

        public override double CalculateArea(double[] values)
        {
            return 999;
        }
    }

    [TestFixture()]
    public class AreaCalculatorTests
    {
        [Test()]
        public void AreaCalculatorTest()
        {
            //Arrange /Act
            AreaCalculator calcTest = new AreaCalculator();

            //Assert
            Assert.IsNotNull(calcTest.ToString());
        }

        [Test()]
        public void AddExistingShapeTest()
        {
            //Arrange
            Circle circleTest = new Circle();
            AreaCalculator calcTest = new AreaCalculator();

            //Act /Assert
            Assert.True(calcTest.AddShape(circleTest) == false);
        }

        [Test()]
        public void AddNewShapeTest()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            NewShape newShapeTest = new NewShape();

            //Act /Assert
            Assert.True(calcTest.AddShape(newShapeTest) == true);
        }

        [Test()]
        public void CalculateTest()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            NewShape newShapeTest = new NewShape();
            calcTest.AddShape(newShapeTest);

            //Act 
            double[] testVar = { 1, 2 };
            
            // Assert
            Assert.IsTrue(calcTest.Calculate("test", testVar) == 999);
        }

        [Test()]
        public void ToStringTest()
        {
            //Arrange 
            AreaCalculator calcTest = new AreaCalculator();
            //Act /Assert
            Assert.That(calcTest.ToString(), Is.EqualTo("circle,1 triangle_3s,3 "));
        }

        [Test()]
        public void NegativeVarTest()
        {
            //Arrange 
            AreaCalculator calcTest = new AreaCalculator();
            double[] var = { -1 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => calcTest.Calculate("circle", var));
            Assert.That(ex.Message, Is.EqualTo("only positive arguments must be used"));
        }

        [Test()]
        public void WrongVarQtyTest()
        {
            //Arrange 
            AreaCalculator calcTest = new AreaCalculator();
            double[] var = { 1 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => calcTest.Calculate("triangle_3s", var));
            Assert.That(ex.Message, Is.EqualTo("not enough arguments"));
        }

    }
}