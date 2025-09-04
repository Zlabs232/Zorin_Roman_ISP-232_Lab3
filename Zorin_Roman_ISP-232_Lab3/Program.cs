namespace Program
{
    class Program
    {
        enum TrafficLight { Red, Yellow, Green }

        static void Main()
        {
            TrafficLight cur = TrafficLight.Green;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Текущий свет: {cur}");

                cur = cur switch
                {
                    TrafficLight.Red => TrafficLight.Yellow,
                    TrafficLight.Yellow => TrafficLight.Green,
                    TrafficLight.Green => TrafficLight.Red,
                    _ => cur
                };

                Console.WriteLine($"Следующий свет: {cur}");
                Console.WriteLine("---");
            } 
            
        }
    }
}