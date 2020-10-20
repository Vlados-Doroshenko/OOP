using System;
using System.Collections.Generic;
using System.Text;

namespace TCircle
{
    class TCone: TCircle
    {
        private double H;
        public double r { get; set; }

        public TCone()
        {
            H = 0;
        }

        public TCone(double H, double r):base(r)
        {
            base.r = r > 0 ? r : 0;
            this.H = h > 0 ? h : 0;
        }

        public double h
        {
            get { return H; }
            set
            {
                if (value > 0) H = value;
            }
        }

        public double Vol()
        {
            return 0.33 * Math.PI * Math.Pow(r, 2) * h;
        }
    }
}
