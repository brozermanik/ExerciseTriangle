using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseTriangle;

namespace TriangleProgramRun
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleSquareSimpleInput();
        }
        public static void TriangleSquareSimpleInput()
        {
            Console.WriteLine("Введите длину первой стороны треугольника в см");
            double aSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника в см");
            double bSide = Convert.ToDouble(Console.ReadLine());
            TriangleSquareSimpleOutput(aSide, bSide);
        }

        // Метод вывода
        public static void TriangleSquareSimpleOutput(double aSide, double bSide)
        {  
            double trSquare = (aSide * bSide) / 2;
            Console.WriteLine("Таким образом площадь треугольника равно {0:0.0} см в квадрате", trSquare);
            Console.ReadKey();
        }       
    }
}
