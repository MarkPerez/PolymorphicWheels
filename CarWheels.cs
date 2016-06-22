using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicWheels
{
    class CarWheels : VehicleWheels
    {
        public override void NoOfWheels()
        {
            Console.WriteLine("A car has four wheels.");
        }
    }
}
