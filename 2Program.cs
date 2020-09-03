using System;
using System.Reflection.Metadata.Ecma335;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задан треугольник");
            Triangle num = new Triangle();
            Console.WriteLine("Введите длину стороны A");
            num.A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны B");
            num.B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны C");
            num.C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num.SV);
            
                num.Length();
                num.Perimeter();
                num.Area();
            
        }
    }
    public class Triangle
    {

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int P { get; set; }
        public string SV
        {
            get
            {
                if ((A + B) < C & (A + C) < B & (B + C) < A)
                {
                    return "Треугольник не реальный";
                }
                else
                { return "Треугольник реальный"; }
            }
        }
        public Triangle() { }
        public Triangle(int a, int b, int c) { A = a; B = b; C = c; }
        public void Length()
        {
            Console.WriteLine($"Длина стороны А: {A}  Длина стороны В: {B}  Длина стороны C: {C}");
        }
        public int Perimeter()
        {

            int perimeter = A + B + C;
            return perimeter;
        }
        public void Area()
        {
            double p = Perimeter();
            double PForArea = p / 2;
            double area = Math.Sqrt(PForArea * (PForArea - A) * (PForArea - B) * (PForArea - C));
            Console.WriteLine($"Площадь треугольника равна {area}");
        }
    }
}