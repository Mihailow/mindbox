using System;

namespace mindbox_bramnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7);
            Triangle triangle = new Triangle(6, 8, 10);

            Console.WriteLine($"Площадь круга: {circle.Area}");
            Console.WriteLine($"Площадь треугольника: {triangle.Area}");

            if (triangle.Rectangular)
                Console.WriteLine("Треугольник прямоугольный");
        }
    }
}