using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Prototype
{
    interface IFigure
    {
        IFigure Clone();
        void ShowInfo();

    }
}
