using System;

namespace TTriangle
{
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
