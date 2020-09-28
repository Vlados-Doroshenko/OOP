using System;


namespace MyMatrix
{

    class MyMatrix
    {
        private double n;
        private double [,] array;
        public MyMatrix() { 
        }
        public double N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }
        public MyMatrix(int n)
        {
            this.n = n;
            array = new double[(int)this.n, (int)this.n];
        }
        public double this[int i, int j]
        {
            get
            {
                return (int)array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }
        public void WriteMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введiть елемент матрицi {0}:{1}", i + 1, j + 1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void ReadMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void oneMat(MyMatrix a)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 1 && i == j)
                    {
                        count++;
                    }
                }

            }
            if (count == a.N)
            {
                Console.WriteLine("Одинична");
            }
            else Console.WriteLine("Не одинична");
        }

        public static MyMatrix multmat(MyMatrix a, int num)
        {
            MyMatrix resMass = new MyMatrix((int)a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    resMass[i, j] = a[i, j] * num;
                }
            }
            return resMass;
        }
        public static MyMatrix mult(MyMatrix a, MyMatrix b)
        {
            MyMatrix resMass = new MyMatrix((int)a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMass[i, j] += a[i, k] * b[k, j];

            return resMass;
        }
        public static MyMatrix sum(MyMatrix a, int num)
        {
            MyMatrix resMass = new MyMatrix((int)a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    resMass[i, j] = a[i, j] + num;
                }
            }
            return resMass;
        }
        public static MyMatrix summ(MyMatrix a, MyMatrix b)
        {
            MyMatrix resMass = new MyMatrix((int)a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMass[i, j] += a[i, k] + b[k, j];

            return resMass;
        }
        public static MyMatrix operator +(MyMatrix a, MyMatrix b)
        {
            return MyMatrix.summ(a, b);
        }

        public static MyMatrix operator +(MyMatrix a, int b)
        {
            return MyMatrix.sum(a, b);
        }

        public static MyMatrix operator *(MyMatrix a, MyMatrix b)
        {
            return MyMatrix.mult(a, b);
        }

        public static MyMatrix operator *(MyMatrix a, int b)
        {
            return MyMatrix.multmat(a, b);
        }
       

}
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
