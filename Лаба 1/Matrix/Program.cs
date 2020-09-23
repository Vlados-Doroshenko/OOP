using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols, a, b, sizerows;

            int[][] W;
            int[] T;

            int pos = 0;

            Console.Clear();

            Console.Write("Введiть к-ть рядкiв матрицi: ");
            sizerows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть iнтервали для визначення кiлькостi стовпцiв матрицi ");
            Console.Write("Вiд числа ");
            a = int.Parse(Console.ReadLine());
            Console.Write("До числа ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Random rand = new Random();

            W = new int[sizerows][];
            for (rows = 0; rows < sizerows; rows++)
                W[rows] = new int[rand.Next(a, b)];

            for (rows = 0; rows < sizerows; rows++)
                for (cols = 0; cols < W[rows].Length; cols++)
                {
                    W[rows][cols] = rand.Next(a, b);
                }

            foreach (int[] u in W)
            {
                foreach (int v in u)
                {
                    Console.Write("{0,4}", v);
                }
                Console.WriteLine();
            }
            T = new int[pos];
            foreach (int v in T)
            {
                Console.Write("{0, 4}", v);
            }
            
            Console.ReadKey();
        }
    }
}
