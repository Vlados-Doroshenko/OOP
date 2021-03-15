using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SharpWasher
{
    class Program
    {
        static void Main(string[] args)
        {            
            Car Opel = new Car("Opel");
            Car Mazda = new Car("Mazda");
            Car Mercedes = new Car("Mercedes");
            Car Volvo = new Car("Volvo");
            Car Audi = new Car("Audi");
            Garage garage = new Garage();
            Washer CarWash = new Washer();
            List<Car> listCarov = new List<Car> { Opel, Mazda, Mercedes, Volvo, Audi };
            garage.addCars(listCarov);
            CarWash.Wash(garage);
            Console.ReadKey();
        }
    }
}
