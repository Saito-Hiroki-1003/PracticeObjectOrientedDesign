using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Triangle
    {
        public double CalculateArea(double BottomLength, double HeightToTop)
        {
            double area = 0;

            area = BottomLength * HeightToTop / 2;

            return area;
        }
    }
}