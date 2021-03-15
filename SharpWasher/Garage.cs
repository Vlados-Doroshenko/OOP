using System;
using System.Collections.Generic;
using System.Text;

namespace SharpWasher
{
    class Garage
    {
        public List<Car> cars = new List<Car>();

        public void addCars(Car marka)
        {
            cars.Add(marka);
        }
        public void addCars(List<Car>Car)
        {
            foreach(var i in Car)
            {
                cars.Add(i);
            }
        }
    }
}
