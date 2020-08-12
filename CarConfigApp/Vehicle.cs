using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarConfigApp
{
    class Vehicle
    {
        public Engine Engine{ get; set; }
        public VehicleBody VehicleBody { get; set; }

        private List<IParts> vehicle;
        public Vehicle()
        {
            vehicle = new List<IParts>();
        }
        public void AddPart(IParts part)
        {
            vehicle.Add(part);
        }
        public int CalculateTotal()
        {
            return Engine.Calculate() + VehicleBody.Calculate();
            return vehicle.Sum(x => x.Calculate());
            //int sum = 0;
            //foreach(var part in vehicle)
            //{
            //    sum += part.Calculate();
            //}
            //return sum;


        }

        public void ReplacePart(IParts part)
        {
            vehicle.RemoveAll(item => item.GetPartType() == part.GetPartType());
            vehicle.Add(part);
        }
    }
}
