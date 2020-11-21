using System;

namespace TCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть радiус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть дiаметр: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть кут: ");
            double l = Convert.ToDouble(Console.ReadLine());
            
            TCircle circle = new TCircle(r, d, l);
            circle.r = r;
            circle.d = d;
            circle.l = l;

            TCircle circle2 = new TCircle(circle);
            circle2.r = r;
            circle2.d = d;
            circle2.l = l;

            Console.WriteLine();
            
            Console.WriteLine("Вхiднi данi оригiнального кола: " + circle.r + " " + circle.d + " " + circle.l);
            Console.WriteLine("Скопiйованi данi оригiнального кола: " + circle2.r + " " + circle2.d + " " + circle2.l);
            
            Console.WriteLine();
            
            Console.WriteLine(circle.ToString());
            
            Console.WriteLine();
            
            Console.Write("Введiть висоту: ");
            double h = Convert.ToDouble(Console.ReadLine());
           
            TCone cone = new TCone(h, r);
            cone.h = h;
            cone.r = circle.r;
            
            Console.WriteLine(cone.ToString());

            Console.ReadKey();
        }
    }
}
