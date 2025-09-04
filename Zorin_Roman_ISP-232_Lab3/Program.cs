using System.Runtime.ExceptionServices;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение и то, сколько раз его нужно повторить");
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(str);
            }


        }
    }
}