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
                if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Tрикутник iснує");
                else Console.WriteLine("Трикутник не iснує");
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0) b = value;
                else b = 0;
                if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Tрикутник iснує");
                else Console.WriteLine("Трикутник не iснує");
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0) c = value;
                else c = 0;
                if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Tрикутник iснує");
                else Console.WriteLine("Трикутник не iснує");
            }
        }

        public double perimeter()
        {
            return a + b + c;
        }
        public double Geron()
        {
            double p = (perimeter()) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
    public class Program
    {


        public static void Main(string[] args)
        {
            TTriangle tr1 = new TTriangle();
            Console.WriteLine("Периметр = " + tr1.perimeter());
            Console.WriteLine("Площа (Формула Герона) = " + tr1.Geron());

            TTriangle tr2 = new TTriangle(0, 14, 0);
            Console.WriteLine("Периметр = " + tr2.perimeter());
            Console.WriteLine("Площа (Формула Герона) = " + tr2.Geron());

            TTriangle tr3 = new TTriangle(0, 0, 8);
            Console.WriteLine("Периметр = " + tr3.perimeter());
            Console.WriteLine("Площа (Формула Герона) = " + tr2.Geron());

            TTriangle tr4 = new TTriangle(5, 8, 8);
            Console.WriteLine("Периметр = " + tr4.perimeter());
            Console.WriteLine("Площа (Формула Герона) = " + tr4.Geron());
        }
    }
}
