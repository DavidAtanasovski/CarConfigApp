using System;
using System.Collections.Generic;
using System.Text;

namespace CarConfigApp
{
    abstract class Wheels : IParts
    {
        private int price;

        public Wheels(int price)
        {

        }
        public virtual int Calculate()
        {
            return price;
        }

        public string GetPartType()
        {
            return "Wheels";
        }
    }
}
