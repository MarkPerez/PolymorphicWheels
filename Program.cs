using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VehicleWheels> vehicleWheels = new List<VehicleWheels>();
            vehicleWheels.Add(new VehicleWheels());
            //car wheels cast as vehicle wheels
            vehicleWheels.Add(new CarWheels());
            //motorbike wheels cast as vehicle wheels
            vehicleWheels.Add(new MotorbikeWheels());

            foreach (VehicleWheels vehicle in vehicleWheels)
            {
                vehicle.NoOfWheels();
            }
            MotorbikeWheels motorBike = new MotorbikeWheels();
            motorBike.NoOfWheels();
        }
    }
}
