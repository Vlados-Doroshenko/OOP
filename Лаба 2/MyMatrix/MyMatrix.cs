using System;
using System.Collections.Generic;
using System.Text;

namespace MyMatrix
{
    class MyMatrix
    {
        private double n;
        private double[,] array;
        public MyMatrix()
        {
        }

        public int Height
        {
            get => this.array.GetLength(0);
        }

        public int Width
        {
            get => this.array.GetLength(1);
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
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
        public MyMatrix(String[] text)
        {
            int size = text[0].Split('/ ').Length;
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (size != text[i].Split('/ ').Length)
                        throw new Exception("Матриця має рiзну кiлькiсть елементiв");
                }
                array = new double[text.Length, size];
                for (int i = 0; i < Height; i++)
                {
                    String[] numbers = text[i].Split(' ');
                    for (int j = 0; j < Width; j++)
                        this.array[i, j] = Convert.ToDouble(numbers[j]);
                }
            }
            catch
            {
                Console.WriteLine("Матриця має рiзну кiлькiсть елементiв");
            }
        }

    }
}
