using System;

class Program
{
    static void Main()
    {
        bool Even = true;
        for (int i = 0; i < 10; i++)
            if (int.Parse(Console.ReadLine()) % 2 != 0) Even = false;
        Console.WriteLine(Even ? "YES" : "NO");
    }
}