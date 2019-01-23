using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public abstract class Vehicle
    {
        public string brand;
        public Bodywork bodywork;
        public Chassis chassis;
        public Wheel[] wheels;
        public Door[] doors;

     
        public Vehicle(string brand, Bodywork bodywork, Chassis chassis, Wheel[] wheels, Door[] doors)
        {
            this.brand = brand;
            this.bodywork = bodywork;
            this.chassis = chassis;
            this.wheels = wheels;
            this.doors = doors;
        }
    }
}
