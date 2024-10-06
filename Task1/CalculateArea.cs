using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CalculateFigure
    {
        public double CalculateArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
