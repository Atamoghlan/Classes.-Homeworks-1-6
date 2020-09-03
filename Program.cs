using System;

namespace Задача_4_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Money num = new Money();
            Console.WriteLine("Введите номинал купюры");
            num.First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество купюр");
            num.Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара");
            num.Price = Convert.ToInt32(Console.ReadLine());
            num.QuantityOfMoney();
            num.EnoughMoneyOrNot();
            num.CanBuyQuantity();
        }
        public class Money
        {
            public int First { get; set; }
            public int Second { get; set; }
            public int Price { get; set; }
            public int QuantityOfItems { get; set; }
            public int Cash
            {
                get
                {
                    int cash = First * Second;

                    return cash;
                }

            }
            public Money() { }
            public Money(int first, int second, int price, int quantityofitems) { First = first; Second = second; Price = price; QuantityOfItems = quantityofitems; }
            public void QuantityOfMoney()
            {
                Console.WriteLine($"Номинал:{First}    Количество купюр:{Second}");
            }
            public int EnoughMoneyOrNot()
            {
                if (Cash >= Price)
                {
                    Console.WriteLine($"У вас достаточно средств для покупки товара на сумму {Price} рублей");
                    return 1;
                }
                else
                {
                    Console.WriteLine($"У вас не достаточно средств для покупки товара на сумму {Price} рублей");
                    return 2;
                }
            }
            public void CanBuyQuantity()
            {
                int QuantityOfItems = Cash / Price;
                if (QuantityOfItems < 1)
                { Console.WriteLine($"Вы не можете купить даже 1 штуку товара"); }
                else { Console.WriteLine($"Вы можете купить {QuantityOfItems} шт. товара(ов)"); }
            }
        }
    }
}
