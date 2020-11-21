using System;
using System.Collections.Generic;
using System.Text;

namespace TCircle
{
    class TCircle
    {
        private double R, D, L;

        public TCircle()
        {
            R = D = L = 0;
        }

        public TCircle(double R)
        {
            this.R = r> 0 ? r : 0;
            D = L = 0;
        }

        public TCircle(double R, double D)
        {
            this.R = r > 0 ? r : 0;
            this.D = d > 0 ? d : 0;
            L = 0;
        }

        public TCircle(double R, double D, double L)
        {
            this.R = r > 0 ? r : 0;
            this.D = d > 0 ? d : 0;
            this.L = l > 0 ? l : 0;
        }

        public TCircle (TCircle obj)
        {
            R = obj.R;
            D = obj.D;
            L = obj.L;
        }        

        public double r
        {
            get { return R; }
            set
            {
                if (value > 0) R = value;
            }
        }

        public double d
        {
            get { return D; }
            set
            {
                if (value > 0) D = value;
            }
        }

        public double l
        {
            get { return L; }
            set
            {
                if (value > 0) L = value;
            }
        }

        public static TCircle operator *(TCircle c1, TCircle c2)
        {
            return new TCircle { D = c1.D * c2.D };
        }

        public double Diametr()
        {
            return 2*r;
        }

        public double Square()
        {
            return Math.PI * (Math.Pow(Diametr(), 2) / 4);
        }

        public double Square_Select()
        {
            return (Math.PI * Math.Pow(r, 2) * l) / 360;
        }

        public double Length()
        {
            return Math.PI * D;
        }

        public override string ToString()
        {
            return "Дiаметр кола = " + Diametr() + "\r\nПлоща кола = " + Square() + "\r\nПлоща селектора кола = " + Square_Select() + "\r\nДовжина кола = " + Length();
        }
    }
}
