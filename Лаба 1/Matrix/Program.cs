using System;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] W =
            {
                new int[] {0, 10, 4 },
                new int[] {4, -10, -2, 100},
                new int[] {6}
            };
 
            int minValue = W[0][0];
            int maxValue = W[0][0];
 
            for(int i = 0; i < W.Length; i++)
            {
                for(int j = 0; j < W[i].Length; j++)
                {
                    Console.Write($"{W[i][j],3}");
                }
                Console.WriteLine();
            }
 
            for (int i = 0; i < W.Length; i++)
            {
                for (int j = 0; j < W[i].Length; j++)
                {
                    if (minValue > W[i][j])
                        minValue = W[i][j];
                    if (maxValue < W[i][j])
                        maxValue = W[i][j];
                }
            }
 
            Console.WriteLine("Мiнiмальне значення масиву: " + minValue);
            Console.WriteLine("Максимальне значення масиву: " + maxValue);
 
            Console.ReadKey();
        }
    }
}
