using System.Runtime.ExceptionServices;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число натуральное n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {Math.Pow(i,2)}");
            }
        }
    }
}