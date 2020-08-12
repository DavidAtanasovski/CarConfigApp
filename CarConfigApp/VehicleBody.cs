using System;
using System.Collections.Generic;
using System.Text;

namespace CarConfigApp
{
    abstract class VehicleBody : IParts
    {
        private int price;
        public VehicleBody(int price)
        {
            this.price = price;
        }
        public virtual int Calculate()
        {
            return price;
        }

        public string GetPartType()
        {
            return "Body";
        }
    }
}
