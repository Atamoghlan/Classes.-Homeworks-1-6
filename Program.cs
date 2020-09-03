using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Class_6_DoubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayC num = new ArrayC();
            num.ArrayElements();
            num.ToConsole();
            Console.WriteLine($"\nКоличество элементов: \n{num.Quantity}");
            num.SortEl();

        }
        class ArrayC
        {
            public int Quantity
            {
                get
                {
                    int Q = M * N;
                    return Q;
                }
            }
            public double Scalar
            {
                set
                {
                    
                    for (int m = 0; m < N; m++)
                    {
                        for (int x = 0; x < M; x++)
                        {
                            Console.Write(DoubelArray[m, x] + " ");
                          
                        }
                    }
                    
                }
            }

            public double[,] DoubelArray { get; set; }
            public int N { get; set; }
            public int M { get; set; }
            public double ScalarMultiply
            {
                set
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            DoubelArray[i, j] = DoubelArray[i, j] * value;
                        }
                    }
                }
            }

            public ArrayC() { }
            public ArrayC(int[,] doubelarray, int n, int m) { DoubelArray[N, M] = doubelarray[n, m]; }
            public void ArrayElements()
            {
                Console.Write("Введите количество N элементов массива:\t");
                N = int.Parse(Console.ReadLine());
                Console.Write("Введите количество M элементов массива:\t");
                M = int.Parse(Console.ReadLine());
                DoubelArray = new double[N, M];
                for (int i = 0; i < N; i++)
                {
                    for (int h = 0; h < M; h++)
                    {
                        Console.WriteLine($"Введите значение элемента под индексом N:{i} M:{h}:\t");
                        DoubelArray[i, h] = int.Parse(Console.ReadLine());
                    }
                }
            }
            public void ToConsole()
            {
                Console.WriteLine("Элементы массива:");
                for (int m = 0; m < N; m++)
                {
                    for (int x = 0; x < M; x++)
                    {
                        Console.Write(DoubelArray[m, x] + " ");
                    }
                }
            }
            public void SortEl()
            {
                Console.WriteLine("\nСортировка элементов по убыванию:");
                double temp = 0;
                int k = 0;
                int s;
                int l;
                {
                    for (s = 0; s < M; s++)
                    {
                        for (l = s + 1; l < M; l++)
                            if (DoubelArray[k, l] > DoubelArray[k, s])
                            {
                                temp = DoubelArray[k, s];
                                DoubelArray[k, s] = DoubelArray[k, l];
                                DoubelArray[k, l] = temp;
                            }


                        Console.Write($"{DoubelArray[k, s]}\n");

                    }
                }
            }
        }
    }
}
