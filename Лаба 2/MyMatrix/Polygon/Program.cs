using System;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть к-ть сторiн багатокутника: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть параметри сторiн багатокутника в см: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Polygon pol = new Polygon(n,a);
            pol.n = n;
            pol.a = a;

            Console.WriteLine("Периметр багатокутника = " + pol.Perimetr());            
            Console.WriteLine("Площа багатокутника = " + pol.Square());
            Console.ReadKey();
        }
    }
}
