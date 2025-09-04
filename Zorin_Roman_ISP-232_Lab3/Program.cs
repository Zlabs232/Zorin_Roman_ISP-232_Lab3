using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Здарова, ты попал на стрельбище!!");
        Console.WriteLine("Введите 'Stop' если хотите завершить стерльбу");
        int n = 0;
        while (true)
        {
            Console.WriteLine("Нажмите Enter для выстрела: ");
            string enter = Console.ReadLine().ToLower();
            if (enter == "стоп")
            {
                Console.WriteLine($"Выстрелов совершено {n}");
                break;
            }
            else
            {
                Console.WriteLine("Выстрел совершен.");
                ++n;
            }
        }
    }
}