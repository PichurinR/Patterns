using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Builder
{
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
