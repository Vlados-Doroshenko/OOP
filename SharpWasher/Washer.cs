using System;
using System.Collections.Generic;
using System.Text;

namespace SharpWasher
{
    class Washer
    {
        delegate void delWahs();
        public void Wash(Garage WashCar)
        {
            int n = WashCar.cars.Count;
            for (int i = 0; i < n; i++)
            {
                delWahs del = WashCar.cars[i].WashCars;
                del();
            }
        }
    }
}
