using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Builder
{
    class Product
    {
        List<object> parts = new List<object>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ", ";
            }

            return "Product parts: " + str + "\n";
        }
    }
}