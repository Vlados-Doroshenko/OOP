using System;


namespace MyMatrix
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiрнiсть матрицi: ");
            double entmat = Convert.ToInt32(Console.ReadLine());
            MyMatrix mass1 = new MyMatrix((int)entmat);
            MyMatrix mass2 = new MyMatrix((int)entmat);
            MyMatrix mass3 = new MyMatrix((int)entmat);
            MyMatrix mass4 = new MyMatrix((int)entmat);
            Console.WriteLine("Введення Матрицi А: ");
            mass1.WriteMat();
            Console.WriteLine("Введення Матрицi B: ");
            mass2.WriteMat();

            Console.WriteLine("Матриця А: ");
            mass1.ReadMat();
            Console.WriteLine();
            Console.WriteLine("Матриця В: ");
            Console.WriteLine();
            mass2.ReadMat();

            Console.WriteLine("Додавання Матриць А i Б: ");
            mass3 = (mass1 + mass2);
            mass3.ReadMat();
            Console.WriteLine("Множення Матриць А i Б: ");
            mass4 = (mass1 * mass2);
            mass4.ReadMat();

            Console.ReadKey();
        }
    }
}
