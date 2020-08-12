using System;
using System.Collections.Generic;
using System.Text;

namespace CarConfigApp
{
    abstract class Color : IParts
    {
        public int price;
        public Color(int price)
        {

        }

        public virtual int Calculate()
        {
            return price;
        }

        public string GetPartType()
        {
            return "Color";
        }
    }
}
