using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "Cruze";
        public double EngineSize { get; set; } = 1.4;
        public int NumberOfDoors { get; set; } = 4;
        public string Motto { get; set; } = "Find New Roads";
        public string Name { get; set; } = "Chevrolet";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} we're driving(Barely)");
        }
        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} can reverse");
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parked");
        }
    }
}
