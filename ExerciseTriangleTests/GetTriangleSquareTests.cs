using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseTriangle;

namespace ExerciseTriangleTests
{
    [TestClass]
    public class GetTriangleSquareTests
    {
        [TestMethod]
        public void TriangleOutput_Test16Input()
        {
            double a = 0x2bc;
            double b = 2;
            double expected = 700;
            double actual;

            actual = GetTriangleSquare.TriangleSquareSimpleOutput(a, b);
            Assert.AreEqual(expected, actual, "Тест не пройден");
        }

        //Проверим как ведет себя метод "TriangleSquareSimpleOutput" если пользователь
        //введет отрицательное значение. У треугольника не может быть отрицательной длины
        //стороны, метод не должен искать площадь при таких значениях
        [TestMethod]
        public void TriangleSquareSimpleTest1_NegativeInput()
        {
            //длины сторон
            double a = -6;
            double b = 7;
            double expected = -21;
            double actual;

            //если тест даст положительный результат значит метод принимает и работает с неверными значениями.
            actual = GetTriangleSquare.TriangleSquareSimpleOutput(a, b);
            Assert.AreEqual(expected, actual, "Тест не пройден");
        }

        [TestMethod]
        public void TriangleOutputTest_NegativeInput()
        {
            double a = -6;
            double b = 7;
            double expected = 21;
            double actual;

            actual = GetTriangleSquare.TriangleOutput(a, b);
            Assert.AreEqual(expected, actual, "Тест не пройден");
        }


    }
}
