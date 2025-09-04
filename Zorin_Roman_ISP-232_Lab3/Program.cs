namespace Program
{
    class Program
    {
        enum Hero { Воин, Маг, Вор }
        enum TimeOfDay { Утро, День, Вечер, Ночь }
        static void Main(string[] args)
        { 
            
            var times = Enum.GetValues(typeof(TimeOfDay));
            var heroes = Enum.GetValues(typeof(Hero));

            for (int i = 0; i < times.Length; i++)
            {
                TimeOfDay time = (TimeOfDay)times.GetValue(i);
                Console.Write($"\nВремя сейчас {time}:\n");

                for(int j = 0; j < heroes.Length; j++)
                {
                    Hero h = (Hero)heroes.GetValue(j);
                    Console.Write($"{h} - ");
                    
                    switch (time)
                    {
                        case TimeOfDay.Утро:
                            Console.WriteLine(h switch
                            {
                                Hero.Воин => "делает зарядку",
                                Hero.Маг => "заваривает зелья",
                                Hero.Вор => "крадётся по базару",
                                _ => "ничего не делает "
                            });
                            break;
                        case TimeOfDay.День:
                            Console.WriteLine(h switch
                            {
                                Hero.Воин => "тренируется на арене",
                                Hero.Маг => "изучает древние книги",
                                Hero.Вор => "прячется в тенях",
                                _ => "ничего не делает "
                            });
                            break;
                        case TimeOfDay.Вечер:
                            Console.WriteLine(h switch
                            {
                                Hero.Воин => "ест мясо у костра",
                                Hero.Маг => "создаёт магический щит",
                                Hero.Вор => "планирует налет",
                                _ => "ничего не делает "
                            });
                            break;
                        case TimeOfDay.Ночь:
                            Console.WriteLine(h switch
                            {
                                Hero.Воин => "спит в палатке",
                                Hero.Маг => "медитирует под луной",
                                Hero.Вор => "лезет в чужой дом",
                                _ => "ничего не делает "
                            });
                            break;
                    }
                }
            }
        }
    } 
}