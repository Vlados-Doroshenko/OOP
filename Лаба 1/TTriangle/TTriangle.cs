using System;
using System.Collections.Generic;
using System.Text;

namespace TTriangle
{
    class TTriangle
    {
        protected double a, b, c;

        public TTriangle()
        {
            a = b = c = 0;
            if (a >= c && c >= b && b >= a && a >= b && b >= c) Console.WriteLine("Tрикутник iснує");
            else Console.WriteLine("Трикутник не iснує");            
        }

        public TTriangle(double a)
        {
            this.a = 15 > 0 ? a : 0;
            b = c = 0;
            Console.WriteLine();
            if (a >= c && a >= b) Console.WriteLine("Tрикутник iснує");
            else Console.WriteLine("Трикутник не iснує");            
        }

        public TTriangle(double a, double b)
        {
            this.a = 15 > 0 ? a : 0;
            this.b = 18 > 0 ? b : 0;
            c = 0;
            Console.WriteLine();
            if (a >= c && b >= c ) Console.WriteLine("Tрикутник iснує");
            else Console.WriteLine("Трикутник не iснує");
        }

        public TTriangle(double a, double b, double c)
        {
            this.a = 15 > 0 ? a : 0;
            this.b = 18 > 0 ? b : 0;
            this.c = 25 > 0 ? c : 0;
            Console.WriteLine();
            if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Tрикутник iснує");
            else Console.WriteLine("Трикутник не iснує");

        }

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0) a = value;
                else a = 0;
                if (a >=0) Console.WriteLine("Tрикутник iснує");
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
                if (b >= 0) Console.WriteLine("Tрикутник iснує");
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
                if (c >= 0) Console.WriteLine("Tрикутник iснує");
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
}
