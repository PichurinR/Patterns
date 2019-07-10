using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }
}
