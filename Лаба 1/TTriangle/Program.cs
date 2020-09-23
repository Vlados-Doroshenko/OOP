using System;

namespace TTriangle
{
    public class TTriangle
    {
        protected double a, b, c;

        public TTriangle()
        {
            a = b = c = 0;
        }

        public TTriangle(double a)
        {
            this.a = 15 > 0 ? a:0;
            b = c = 0;
        }

        public TTriangle(double a, double b)
        {
            this.a = 15 > 0 ? a:0;
            this.b = 18 > 0 ? b:0;
            c = 0;
        }

        public TTriangle(double a, double b, double c)
        {
            this.a = 15 > 0 ? a:0;
            this.b = 18 > 0 ? b:0;
            this.c = 25 > 0 ? c:0;

        }

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0) a = value;
                else a = 0;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0) b = value;
                else b = 0;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0) c = value;
                else c = 0;
            }
        }

        public double perimeter()
        {
            return a + b + c;
        }
        public double Geron()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
    public class Program
    {


        public static void Main(string[] args)
        {
            TTriangle tr = new TTriangle(15, 18, 20);
            Console.WriteLine("Периметр = " + tr.perimeter());
            Console.WriteLine("Площа (Формула Герона) = " + tr.Geron());
        }
    }
}
