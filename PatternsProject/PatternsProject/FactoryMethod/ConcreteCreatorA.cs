using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.FactoryMethod
{
    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }
}
