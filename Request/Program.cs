using System;

//Описать структуру Request содержащую поля: код заказа; клиент; дата заказа;
//перечень заказанных товаров; сумма заказа(реализовать вычисляемым свойством).

namespace Request
{
    internal class Program
    {
        public struct Request
        {
            private decimal _orderAmount;
            private int _orderCode;
            private string _client;
            private DateTime _date;

            public decimal OrderAmount { get => _orderAmount; set => _orderAmount = value; }
            public int OrderCode { get => _orderCode; set => _orderCode = value; }
            public string Client { get => _client; set => _client = value; }
            public DateTime Date { get => _date; set => _date = value; }

            public string[] products;

            public void Print()
            {
                Console.WriteLine($"Номер заказа: {OrderCode} \nклиент: {Client}" +
                    $" \nдата заказа: {_date.ToShortDateString()} \nСумма заказа: {OrderAmount} \nтовары:");
                writeProducts(ref products);
            }

            private void writeProducts(ref string[] products)
            {
                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void Main(string[] args)
        {
            Request request = new Request();

            Console.WriteLine("Введите код заказа");
            request.OrderCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя клиента");
            request.Client = Console.ReadLine();

            request.Date = DateTime.Now;

            Console.WriteLine("Введите количество купленых продуктов");
            int order = int.Parse(Console.ReadLine());

            request.products = new string[order];
            for (int i = 0; i < order; i++)
            {
                Console.WriteLine($"Введите название {i + 1} продукта");
                request.products[i] = Console.ReadLine();

                Console.WriteLine($"Введите стоимость {i + 1} продукта");
                request.OrderAmount += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывожу данные");

            request.Print();

            Console.ReadLine();
        }
    }
}