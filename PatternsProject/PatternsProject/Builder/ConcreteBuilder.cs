using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Builder
{
    class ConcreteBuilder : IBuilder
    {
        Product pr = new Product();
        public void BuildPartA()
        {
            pr.Add("This is part A");
        }

        public void BuildPartB()
        {
            pr.Add("This is part B");
        }
        public void BuildPartC()
        {
            pr.Add("This is part C");
        }

        public Product GetProduct()
        {
            return this.pr;
        }

        public void Reset()
        {
            this.pr = new Product();
        }
    }
}
