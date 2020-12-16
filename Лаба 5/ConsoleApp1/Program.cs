using System;

namespace ConsoleApp1
{
    class Program
    {
        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            a.Divide(b);
            curr = a.Multiply(b); 
            curr = curr.Add(curr); 

            Console.WriteLine("2*a*b = " + curr);



            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }
        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            T aMinusB = a.Subtract(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine("(a-b) = " + aMinusB);
            Console.WriteLine("(a-b)^2 = " + aMinusB.Multiply(aMinusB));
            Console.WriteLine("a^2-b^2/a+b = " + aMinusB.Multiply(aMinusB) + " / " + aPlusB);

            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");

        }
        static void Main(string[] args)
        {
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            testAPlusBSquare(new MyComplex(1, 2), new MyComplex(1, 5));
            testAPlusBSquare(new MyComplex(1.2, 3), new MyComplex(3.54, 6));
            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            MyFrac[] fracs = { new MyFrac(9, 7), new MyFrac(4, 1), new MyFrac(5, 9), new MyFrac(7, 2) };
            foreach (MyFrac f in fracs)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            Array.Sort(fracs);
            foreach (MyFrac f in fracs)
            {
                Console.Write(f + " ");
            }
            Console.ReadKey();

        }
    }
}
