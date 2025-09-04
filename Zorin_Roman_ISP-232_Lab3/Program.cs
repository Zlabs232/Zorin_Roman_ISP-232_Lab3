namespace Program
{
    class Program
    {
        enum OrderStatus { New, Processing, Shipped, Delivered}

        static void Main()
        {
            OrderStatus[] test =
            {
                OrderStatus.New,
                OrderStatus.Processing,
                OrderStatus.Shipped,
                OrderStatus.Delivered,
            };

            foreach(var status in test)
            {
                bool canC = Check(status);
                Console.WriteLine($"Статус заказа: {status}, Можно ли отменить: {(canC == true ? "Да" : "Нет")}");
            }
        }

        static bool Check(OrderStatus status)
        {
            return status == OrderStatus.New || status == OrderStatus.Processing;
        }
    }
}