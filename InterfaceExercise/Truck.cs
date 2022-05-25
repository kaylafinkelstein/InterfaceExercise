using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany  
    {
        public Truck()
        {

        }

        public string Make { get; set; } = "Rivian";
        public string Model { get; set; } = "R1T";
        public double EngineSize { get; set; } = 0;
        public int NumberOfDoors { get; set; } = 4;
        public string Motto { get; set; } = "Keep the world adventurus forever";
        public string Name { get; set; } = "Rivian"; 

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} we're driving an electric truck!");
        }
        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} can reverse in an electric truck!");
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parked in an electric truck!");
        }
    }
}
