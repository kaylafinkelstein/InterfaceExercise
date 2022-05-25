using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; set; }
        public int NumberOfDoors { get; set; }
        public string Motto { get; set; }
        public string Name { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} we're driving");
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
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.- DONE
     * 
     */
}

