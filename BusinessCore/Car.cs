using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public class Car : Vehicle
    {

        public Car(string brand, Bodywork bodywork, Chassis chassis, Wheel[] wheels, Door[] doors)
             : base(brand, bodywork, chassis, wheels, doors)
        {
        }
    }
}
