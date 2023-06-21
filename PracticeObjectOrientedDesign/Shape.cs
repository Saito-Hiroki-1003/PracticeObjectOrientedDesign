using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    class Shape
    {
        public ShapeType Type { get; set; }
        public double Radius { get; set; }
        public double SideLength { get; set; }
        public double BottomLength { get; set; }
        public double HeightToTop { get; set; }
        // ... 他の共通のプロパティやメソッド ...

        public double CalculateArea()
        {
            double area = 0;

            if (Type == ShapeType.Circle)
            {
                area = Math.PI * Radius * Radius;
            }
            else if (Type == ShapeType.Square)
            {
                area = SideLength * SideLength;
            }
            else if (Type == ShapeType.Triangle)
            {
                area = BottomLength * HeightToTop / 2;
            }
            return area;
        }
    }
}
