using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double GetArea()
        {
            double  halfPerimer = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(halfPerimer * (halfPerimer - Side1) * (halfPerimer - Side2) * (halfPerimer - Side3));

        }

        public bool IsRightAngle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);

            bool result  = Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.00001;
            return result;
        }
    }
}
