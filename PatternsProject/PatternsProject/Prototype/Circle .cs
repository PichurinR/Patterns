using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Prototype
{
    class Circle : IFigure
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Circle with radius {0}", radius);
        }
    }
}
