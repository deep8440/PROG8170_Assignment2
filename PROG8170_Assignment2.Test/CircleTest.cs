using NUnit.Framework;

namespace PROG8170_Assignment2.Test
{
    public class CircleTest
    {
        [Test]
        public void GetRadius_Input5_Output5()
        {
            // Arrange
            Circle circle = new Circle(5);

            int expected = 5;

            // Act
            int result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetRadius_InputNothing_Output1()
        {
            // Arrange
            Circle circle = new Circle();
            int expected = 1;
            // Act
            int result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void GetRadius_Input15_Output15()
        {
            // Arrange
            Circle circle = new Circle(15);

            int expected = 15;

            // Act
            int result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SetRadius_Input8_Output8()
        {
            // Arrange
            Circle circle = new Circle();

            int expected = 8;

            // Act
            circle.SetRadius(8);
            int result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SetRadius_Input18_Output18()
        {
            // Arrange
            Circle circle = new Circle();

            int expected = 18;

            // Act
            circle.SetRadius(18);
            int result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SetRadius_Input26_Output26()
        {
            // Arrange
            Circle circle = new Circle();

            int expected = 26;

            // Act
            circle.SetRadius(26);
            int result = circle.GetRadius();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetCircumference_Input10_OutputApproximately63()
        {
            // Arrange
            int radius = 10;
            Circle circle = new Circle(radius);

            double expected = 62.831853071795862;

            // Act
            double result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetCircumference_Input5_OutputApproximately32()
        {
            // Arrange
            int radius = 5;
            Circle circle = new Circle(radius);

            double expected = 31.415926535897931;

            // Act
            double result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetCircumference_Input13_OutputApproximately82()
        {
            // Arrange
            int radius = 13;
            Circle circle = new Circle(radius);

            double expected = 81.681408993334628;

            // Act
            double result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetArea_Input6_OutputApproximately113()
        {
            // Arrange
            int radius = 6;
            Circle circle = new Circle(radius);

            // Act
            double expected = 113.09733552923255;
            double result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetArea_Input4_OutputApproximately113()
        {
            // Arrange
            int radius = 4;
            Circle circle = new Circle(radius);

            // Act
            double expected = 50.26548245743669;
            double result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetArea_Input11_OutputApproximately113()
        {
            // Arrange
            int radius = 11;
            Circle circle = new Circle(radius);

            // Act
            double expected = 380.13271108436493;
            double result = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}