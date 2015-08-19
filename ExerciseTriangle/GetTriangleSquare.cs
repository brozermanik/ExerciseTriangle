using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTriangle
{
    public class GetTriangleSquare
    {        


        // Задание
        // Напишите функцию, которая вычисляет площадь прямоугольного треугольника, принимая на вход длину каждой его стороны
        // Очевидно, что данное решение не учитывает множества факторов (например пользователь может ввести отрицательное значение,
        // буквы, вместо чисел и т.д.)
        public static void TriangleSquareSimple()
        {
            Console.WriteLine("Введите длину первой стороны треугольника в см");
            double aSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника в см");
            double bSide = Convert.ToDouble(Console.ReadLine());

            double trSquare = (aSide * bSide) / 2;
        }
        // Для удобства тестирования разделим ввод и вывод информации на 2 метода
        // Метод ввода
        public static void TriangleSquareSimpleInput()
        {
            Console.WriteLine("Введите длину первой стороны треугольника в см");
            double aSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника в см");
            double bSide = Convert.ToDouble(Console.ReadLine());
        }

        // Метод вывода
        public static double TriangleSquareSimpleOutput(double aSide, double bSide)
        {
            double trSquare = (aSide * bSide) / 2;
            return trSquare;
        }

        //Так-как оказалось, что наша программа работает с неправильными значениями добавим проверку
        //

        public static void TriangleInput()
        {
            try
            {
                Console.WriteLine("Введите длину первой стороны треугольника в см");
                double aSide = Convert.ToDouble(Console.ReadLine());
                if ((aSide <= 0) || (aSide.GetTypeCode() != TypeCode.Double))
                {
                    throw new Exception("Введено неверное значение, длина стороны треугольника не может равняться нулю или быть отрицательным");
                }

                Console.WriteLine("Введите длину второй стороны треугольника в см");
                double bSide = Convert.ToDouble(Console.ReadLine());
                if ((bSide <= 0) && (bSide.GetTypeCode() != TypeCode.Double))
                {
                    throw new Exception("Введено неверное значение, длина стороны треугольника не может равняться нулю или быть отрицательным");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.ReadKey();
            }
        }

        public static double TriangleOutput(double aSide, double bSide)
        {
            double trSquare = (aSide * bSide) / 2;
            Console.WriteLine("Таким образом площадь треугольника равно {0:0.0} см в квадрате", trSquare);
            return trSquare;
        }
    }
}
