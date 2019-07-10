using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.FactoryMethod
{
    class ConcreteCreatorb : Creator
    {
        public override IProduct FactoryMethod()
        {
           return new ProductB();
        }
    }
}
