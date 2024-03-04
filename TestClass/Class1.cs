using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TestClass
{
    public class TriangleTest

    {
        [TestFixture]
        public class TriangleTest1
        {
            //Equilaterl Triangle Test 1
            [Test]
            public void AnalyzeTriangle_Input60and60and60_OutputEquilateralTriangle()
            {
                //Arrange
                int firstSide = 60;
                int secondSide = 60;
                int thirdSide = 60;
                string expected = "Equilateral triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            //Isosceles triangle Test 1
            [Test]
            public void AnalyzeTriangle_Input60and40and60_OuputIsoscelesTriangle()
            {
                //Arrange
                int firstSide = 60;
                int secondSide = 40;
                int thirdSide = 60;
                string expected = "Isosceles triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Isosceles triangle Test 2
            [Test]
            public void AnalyzeTriangle_Input40and60and60_OuputIsoscelesTriangle()
            {
                //Arrange
                int firstSide = 40;
                int secondSide = 60;
                int thirdSide = 60;
                string expected = "Isosceles triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Isosceles triangle Test 3
            [Test]
            public void AnalyzeTriangle_Input60and60and40_OuputIsoscelesTriangle()
            {
                //Arrange
                int firstSide = 60;
                int secondSide = 60;
                int thirdSide = 40;
                string expected = "Isosceles triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }


            //Scalene triangle Test 1
            [Test]
            public void AnalyzeTriangle_Input30and40and50_OutputScaleneTriangle()
            {
                //Arrange
                int firstSide = 30;
                int secondSide = 40;
                int thirdSide = 50;
                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Scalene triangle Test 2
            [Test]
            public void AnalyzeTriangle_Input3and4and5_OutputScaleneTriangle()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;
                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Scalene triangle Test 3
            [Test]
            public void AnalyzeTriangle_Input70and30and60_OutputScaleneTriangle()
            {
                //Arrange
                int firstSide = 70;
                int secondSide = 30;
                int thirdSide = 60;
                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Scalene triangle Test 4
            [Test]
            public void AnalyzeTriangle_Input80and90and20_OutputScaleneTriangle()
            {
                //Arrange
                int firstSide = 80;
                int secondSide = 90;
                int thirdSide = 20;
                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

            //Scalene triangle Test 5
            [Test]
            public void AnalyzeTriangle_Input8and9and10_OutputScaleneTriangle()
            {
                //Arrange
                int firstSide = 8;
                int secondSide = 9;
                int thirdSide = 10;
                string expected = "Scalene triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

      



        }
    }
}
