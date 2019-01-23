using System;
using BusinessCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bodywork bodywork1 = new Bodywork("Mercedes");
            Bodywork bodywork2 = new Bodywork("Peugeot");

            Chassis chassis1 = new Chassis("Bmw");
            Chassis chassis2 = new Chassis("Seat");

            Wheel wheel1 = new Wheel("Pirelli", 30.5f);
            Wheel wheel2 = new Wheel("Pirelli", 30.5f);
            Wheel wheel3 = new Wheel("Pirelli", 30.5f);
            Wheel wheel4 = new Wheel("Pirelli", 30.5f);

            Wheel[] wheels = new Wheel[] { wheel1, wheel2, wheel3, wheel4 };


            Wheel[] carWheels = new Wheel[]
             {
                new Wheel("Pirelli", 30.5f),
                new Wheel("Pirelli", 30.5f),
                new Wheel("Pirelli", 30.5f),
                new Wheel("Pirelli", 30.5f),
                new Wheel("Pirelli", 30.5f),
             };

            Wheel[] truckWheels = new Wheel[]
            {
                new Wheel("Pirelli", 60.5f),
                new Wheel("Pirelli", 60.5f),
                new Wheel("Pirelli", 60.5f),
                new Wheel("Pirelli", 60.5f),
                new Wheel("Pirelli", 60.5f),
            };

            Door[] carDoors = new Door[]
             {
                new Door("black"),
                new Door("black"),
                new Door("black"),
                new Door("black"),
                new Door("black"),
             };

            Door[] truckDoors = new Door[]
            {
                new Door("white"),
                new Door("white"),
                new Door("white"),
                new Door("white"),
                new Door("white"),
            };


            Car car1 = new Car("Peugeot", bodywork1, chassis1, wheels, carDoors);
            Truck truck1 = new Truck("Generaltrucks", bodywork2, chassis2, wheels, truckDoors);

            Console.WriteLine($"La marca del chásis del coche es: {car1.chassis.Brand}");
            Console.WriteLine($"La marca de la carrocería del camión es: {truck1.bodywork.Brand}");
            Console.ReadLine();
        }
    }
}
