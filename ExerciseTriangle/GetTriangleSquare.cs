using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTriangle
{
    public class GetTriangleSquare
    {
        public static void TriangleSquare()
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
                double trSquare = (aSide * bSide) / 2;
                Console.WriteLine("Таким образом площадь треугольника равно {0:0.0} см в квадрате", trSquare);
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                Console.ReadKey();
            }
        }

        public static double TriangleSquare(double aSide, double bSide)
        {
            try
            {
                Console.WriteLine("Введите длину первой стороны треугольника в см");
                aSide = Convert.ToDouble(Console.ReadLine());
                if ((aSide <= 0) || (aSide.GetTypeCode() != TypeCode.Double))
                {
                    throw new Exception("Введено неверное значение, длина стороны треугольника не может равняться нулю или быть отрицательным");
                }

                Console.WriteLine("Введите длину второй стороны треугольника в см");
                bSide = Convert.ToDouble(Console.ReadLine());
                if ((bSide <= 0) && (bSide.GetTypeCode() != TypeCode.Double))
                {
                    throw new Exception("Введено неверное значение, длина стороны треугольника не может равняться нулю или быть отрицательным");
                }
                double trSquare = (aSide * bSide) / 2;
                Console.WriteLine("Таким образом площадь треугольника равно {0:0.0} см в квадрате", trSquare);
                Console.ReadKey();
                return trSquare;
            }

            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
                return 0;
            }
        }
    }
}
