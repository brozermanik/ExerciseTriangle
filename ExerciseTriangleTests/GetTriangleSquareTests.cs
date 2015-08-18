using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseTriangle;

namespace ExerciseTriangleTests
{
    [TestClass]
    public class GetTriangleSquareTests
    {
        [TestMethod]
        public void TestGetTriangleSquare()
        {
            double a = 6;
            double b = 7;
            double expected = 21;
            double actual;

            actual = GetTriangleSquare.TriangleSquare(a, b);
            Assert.AreEqual(expected, actual, "Тест не проqден");
        }
    }
}
