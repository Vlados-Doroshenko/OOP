using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class MyFrac : IMyNumber<MyFrac>, IComparable
    {
        BigInteger nom;
        BigInteger denom;
        public int CompareTo(object that)
        {
            MyFrac frac = that as MyFrac;
            if (Value > frac.Value)
            {
                return 1;
            }
            else if (Value < frac.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        public double Value
        {
            get { return (double)nom / (double)denom; }
        }
        public MyFrac() { }
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            this.nom = nom;
            this.denom = denom;
        }
        public MyFrac(int nom, int denom)
        {
            this.nom = nom;
            this.denom = denom;
        }
        public double GetValue()
        {
            return ((double)nom / (double)denom);
        }
        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);
        }
        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom - that.nom * this.denom, this.denom * that.denom);
        }
        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(this.nom * that.nom, this.denom * that.denom);
        }
        public MyFrac Divide(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom, this.denom * that.nom);
        }
        public override string ToString()
        {
            try
            {
                return nom + "/" + denom + "(" + ((double)nom / (double)denom) + ")";
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
