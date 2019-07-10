using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Prototype
{
    class Rectangle : IFigure
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Rectangle height {0} и width {1}", height, width);
        }
    }
}
