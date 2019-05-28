using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.	Одна штука некоторого товара стоит 20,4 грн. Напечатать таблицу стоимости 2, 3, ...,
            //20 штук …этого товара.
            int x; double y = 20.4;
            for (x=2; x < 20; x++)
            {
                Console.WriteLine($"Количество: {x}, Стоимость товара: {y}, Общая стоимость: {x * y}");
            }

        }
    }
}
