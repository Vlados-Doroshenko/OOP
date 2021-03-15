using System;
using System.Collections.Generic;
using System.Linq;

namespace Division
{
    class Program
    {
        delegate List<int> filter(int[] array);
        static void Main(string[] args)
        {
            filter filt;
            List<int> divBy3, divBy7;
            int[] array = new int[99];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {                
                array[i] = rand.Next(1, 100);
                Console.Write(array[i] + " ");
            }
            array[3] = 21;
            filt = DivBy3;
            divBy3 =filt(array);
            filt = DivBy7;
            divBy7 =filt(array);
            var result = divBy3.Intersect(divBy7);

            Console.WriteLine("\nresult nubers divided by 3 and 7:");
            foreach(var i in result)
            {
                Console.Write(i + " ");
            }

        }
        public static List<int> DivBy3(int[] array)
        {
            Console.WriteLine();
            List<int> temp = new List<int>();
            Console.WriteLine("Nubers divided by 3");
            foreach(var i in array)
            {
                if(i % 3 == 0)
                {
                    Console.Write(i + " ");
                    temp.Add(i);
                }
                
            }
            return temp;
        }
        public static List<int> DivBy7(int[] array)
        {
            Console.WriteLine();
            List<int> temp = new List<int>();
            Console.WriteLine("Nubers divided by 7");
            foreach (var i in array)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                    temp.Add(i);
                }

            }
            return temp;
        }
    }
}
