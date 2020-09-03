using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Classes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point num = new Point();
            Console.WriteLine("Введите число для Х");
            num.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число для Y");
            num.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число для S");
            num.S = Convert.ToInt32(Console.ReadLine());
            num.GetPoint();
            num.GetDistance();
            num.GetQuarter();
            num.Scalar();
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int S { get; set; }
        public Point() { }
        public Point(int x, int y, int s) { X = x; Y = y; S = s; }
        public void GetPoint()
        {
            Console.WriteLine($"Абсцисса {X} ордината {Y}");
        }
        public void GetDistance()
        {
            double distance = Math.Sqrt((X * X) + (Y * Y));
            Console.WriteLine($"Расстояние: {distance}");
        }
        public void GetQuarter()
        {
            if (X > 0 && Y > 0) { Console.WriteLine("1-ая Четверть"); }
            else if (X < 0 && Y > 0) { Console.WriteLine("2-ая Четверть"); }
            else if (X < 0 && Y < 0) { Console.WriteLine("3-я Четверть"); }
            else if (X > 0 && Y < 0) { Console.WriteLine("4-ая Четверть"); }
            else { Console.WriteLine("Точка находится на оси"); }
        }
        public void Scalar()
        {
            int scalarX = S * X;
            int scalarY = S * Y;
            Console.WriteLine($"Скаляр X:  {scalarX}     Скаляр Y:  {scalarY}");
        }
    }
}