using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //task9();
            //task265();
            //task10();
            task15();
        }
         static void task9()
        //9.	Одна штука некоторого товара стоит 20,4 грн. Напечатать таблицу стоимости 2, 3, ...,
        //20 штук …этого товара.
        {
            int x; double y = 20.4;
            for (x = 2; x < 21; x++)
            {
                Console.WriteLine($"Количество: {x}, Стоимость товара: {y}, Общая стоимость: {x * y}");
            }
        }
         static void task265()
        {
            double a=3, x, b = 0.2, y;
           
            for (x = -5; x < 5.5; x += 0.5)
            {
                y= 2.05 * a * Math.Pow(x, 3) - 3 * b * Math.Sqrt(5 - Math.Pow(Math.Sin(4 * x), 3)) / Math.Abs(0.3 * Math.Pow(Math.Tanh(x - 2), 3));
                    
                               Console.WriteLine($"ЗНАЧЕНИЕ X: {x}, РЕЗУЛЬТАТ Y: {y}");
             }
        }
        static void task10()
        {
            double q, x = 0.423; 
            for (q = 1; q < 11; q++)
            {
                Console.WriteLine($"Вес в фунтах {q} - Вес в килограммах {q*x}");
            }
        }
        static void task15()
        {//таблица умножения на 7
            for (int e = 7; e < 11;e++)
            { for (int r = 1; r < 11; r++)
                {
                    if (e >7)
                    break;
                    Console.WriteLine($"{e} * {r} = {e*r}");
                }
            }
           
        }
    }
}

