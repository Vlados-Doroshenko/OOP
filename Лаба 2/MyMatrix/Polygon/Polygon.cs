using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Polygon
    {
        private double P_n;
        private double P_a;
        
        public double n
        {
            get { return P_n; }
            set { if (value > 0) P_n = value; }
        }

        public double a
        {
            get { return P_a; }
            set { if (value > 0) P_a = value; }
        }

        public Polygon(double n, double a)
        {
            this.n = n;
            this.a = a;
        }

        public double Perimetr()
        {
            return n * a;
        }
        public double Square()
        {
            return 0.25 * (n * Math.Pow(a, 2) *Math.Tan( Math.PI / n));
        }
    }
}
