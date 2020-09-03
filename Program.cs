using System;
namespace Задача_3_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задан прямоугольник.");
            Rectangle num = new Rectangle();
            Console.WriteLine("Введите длину прямоугольника");
            num.A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника");
            num.B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num.RealOrNot);
            num.Length();
            num.Perimeter();
            num.Area();

        }

    }
    public class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public string RealOrNot
        {
            get
            {
                if (A == B)
                    return "Данный прямоугольник является квадратом";
                else
                    return "Данный прямоугольник не является квадратом";
            }
        }
        public Rectangle() { }
        public Rectangle(int a, int b) { A = a; B = b; }
        public void Length()
        {
            Console.WriteLine($"Длина прямоугольника: {A}");
            Console.WriteLine($"Ширина прямоугольника: {B}");
        }
        public void Perimeter()
        {
            int perimeter = 2 * (A + B);
            Console.WriteLine($"Периметр равен: {perimeter}");

        }
        public void Area()
        {
            int area = A * B;
            Console.WriteLine($"Площадь прямоугольника равна: {area}");
        }
    }
}