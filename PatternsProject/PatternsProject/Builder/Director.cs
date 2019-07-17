using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Builder
{
    class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void MinConstruct()
        {
            builder.BuildPartA();
        }
        public void FullConstruct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }


    }
}
