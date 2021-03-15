using System;
using System.Collections.Generic;
using System.Text;

namespace SharpWasher
{
    class Car
    {
        string marka;

        public Car(string _marka)
        {
            marka = _marka;
        }
        public void WashCars()
        {
            Console.WriteLine("{0} машина помита", this.marka);
        }
    }
    

}
