using System;
using System.Collections.Generic;
using System.Text;

namespace CarConfigApp
{
    abstract class Engine : IParts
    {
        private int price;
        public Engine(int price)
        {
            this.price = price;
        }
        public virtual int Calculate()
        {
            return price;
        }

        public string GetPartType()
        {
            return "Engine";
        }
    }
}
