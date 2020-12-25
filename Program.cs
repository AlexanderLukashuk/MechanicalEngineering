using System;
using mechanicalEngineering.Models;

namespace MechanicalEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer();
            CarBuilder carBuilder = new Pickup();
            var pickup = engineer.MekeCar(carBuilder);
            Console.Write(pickup.ToString());
        }
    }
}
