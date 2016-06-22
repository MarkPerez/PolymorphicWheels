using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicWheels
{
    class MotorbikeWheels : VehicleWheels
    {
        public override void NoOfWheels()
        {
            Console.WriteLine("A motorbike has two wheels.");
        }
    }
}
