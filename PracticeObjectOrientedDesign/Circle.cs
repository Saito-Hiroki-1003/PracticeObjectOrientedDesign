using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Circle
    {
        public double CalculateArea(double Radius)
        {
            double area = 0;

            area = Math.PI * Radius * Radius;

            return area;
        }
    }
}