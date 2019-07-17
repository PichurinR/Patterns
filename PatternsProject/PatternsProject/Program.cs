using PatternsProject.Prototype;
using System;
using PatternsProject.Builder;

namespace PatternsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region --Prototipe

            //IFigure figure = new Rectangle(10, 50);
            //IFigure clonedRect = figure.Clone();
            //figure.ShowInfo();
            //clonedRect.ShowInfo();

            //figure = new Circle(50);
            //IFigure clonedCirc = figure.Clone();
            //figure.ShowInfo();
            //clonedCirc.ShowInfo();

            //Console.Read();
            #endregion

            #region --Builder

            
            var builder = new ConcreteBuilder();
            var director = new Director(builder);
            director.FullConstruct();
            Console.WriteLine(builder.GetProduct().ListParts());
            builder.Reset();
            director.MinConstruct();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.Read();

            #endregion
        }
    }
}
