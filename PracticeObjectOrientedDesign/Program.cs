using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Square square = new Square();

            Triangle triangle = new Triangle();

            double circleArea = circle.CalculateArea(5);
            double squareArea = square.CalculateArea(10);
            double triangleArea = triangle.CalculateArea(6,8);

            Console.WriteLine("円の面積: " + circleArea);
            Console.WriteLine("正方形の面積: " + squareArea);
            Console.WriteLine("三角形の面積: " + triangleArea);
            Console.ReadLine();
        }
    }
}
