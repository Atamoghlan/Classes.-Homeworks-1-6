using System;

namespace Classes_5_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass num = new ArrayClass();
            num.ArrayElements();
            num.ElementsToConsole();
            num.Sort();
        }
    }
    public class ArrayClass
    {
        public int Scalar
        {
            set
            {
                Console.WriteLine("Введите скаляр");
                int s = Convert.ToInt32(Console.ReadLine());
                for (int f = 0; f < Array.Length; f++)
                {
                    Array[f] = s * Array[f];
                    value = Array[f];                
                }
                
            }
        }
        
        public int[] Array { get; set; }
        public int N { get;}
        
        public ArrayClass() { }
        public ArrayClass (int [] array, int n, int s) {Array[N] = array[n]; N = n; }
        public void ArrayElements()
        {
            Console.Write("Введите количество элементов массива:\t");
            int elements = int.Parse(Console.ReadLine());
            Array = new int[elements];
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}:\t");
                Array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ElementsToConsole()
        {
            Console.WriteLine("Элементы массива:");
            for (int m = 0; m <= Array.Length-1; m++)
            {
                int S = Array[m];
                
                Console.Write($"{S}\n");
            }
        }
        public void Sort()
        {
            Console.WriteLine("Элементы по возрастанию:");
            int temp = 0;
            for (int m = 0; m < Array.Length; m++)
            {
                for (int l = m + 1; l < Array.Length; l++)
                    if (Array[l] < Array[m])
                    {
                        temp = Array[m];
                        Array[m] = Array[l];
                        Array[l] = temp;
                    }

                Console.Write($"{Array[m]}\n");
            }
        }

    }
}
