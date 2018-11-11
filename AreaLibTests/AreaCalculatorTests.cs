using AreaLib;
using NUnit.Framework;
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

        [Test()]
        public void CalculateWithNoNameTest1()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            double[] var = { 1 };

            //Act /Assert
            Assert.True(calcTest.Calculate(var) == 3.141592);
        }

        [Test()]
        public void CalculateWithNoNameTest2()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            double[] var = { 3, 4, 5 };

            //Act /Assert
            Assert.True(calcTest.Calculate(var) == 6);
        }

        [Test()]
        public void CalculateWithNoNameTest3()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            double[] var = { -3, 4, 5 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => calcTest.Calculate(var));
            Assert.That(ex.Message, Is.EqualTo("only positive arguments must be used"));
        }

        [Test()]
        public void RemShapeTestTrue()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();

            //Act
            calcTest.RemShape("circle");

            //Assert
            Assert.That(calcTest.ToString(), Is.EqualTo("triangle_3s,3 "));
        }

        [Test()]
        public void RemShapeTestTrue_2()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();

            //Act
            calcTest.RemShape("circle");
            calcTest.RemShape("triangle_3s");

            //Assert
            Assert.That(calcTest.ToString(), Is.EqualTo(""));
        }

        [Test()]

        public void RemShapeTestFalse()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            calcTest.RemShape("circle");

            //Act /Assert
            Assert.IsTrue(calcTest.RemShape("circle") == false);
        }

        [Test()]
        public void CalculateWithNoStringFound()
        {
            //Arrange
            AreaCalculator calcTest = new AreaCalculator();
            double[] var = { 1 };

            //Act /Assert
            var ex = Assert.Throws<ArgumentException>(() => calcTest.Calculate("polygon",var));
            Assert.That(ex.Message, Is.EqualTo("Shape name not found"));
        }
        
    }
}