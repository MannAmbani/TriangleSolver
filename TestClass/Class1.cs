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
            //Equilaterla Triangle Test 1
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

        




        }
    }
}
