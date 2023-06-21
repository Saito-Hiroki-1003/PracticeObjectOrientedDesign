using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public class Square
    {
        public double CalculateArea(double SideLength)
        {
            double area = 0;

            area = SideLength * SideLength;

            return area;
        }
    }
}