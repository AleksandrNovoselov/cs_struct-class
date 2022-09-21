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
            public decimal OrderAmount { get => _orderAmount; set => _orderAmount = value; }

            public int orderCode;
            public string client;
            public DateTime date;
            public string[] products;

            public void Print()
            {
                Console.WriteLine($"Номер заказа: {orderCode} \nклиент: {client}" +
                    $" \nдата заказа: {date.ToShortDateString()} \nСумма заказа: {_orderAmount} \nтовары:");
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
            request.orderCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя клиента");
            request.client = Console.ReadLine();

            //Console.WriteLine("Введите дату заказа");
            request.date = DateTime.Now;

            Console.WriteLine("Введите количество купленых продуктов");
            int order = int.Parse(Console.ReadLine());

            // decimal sum = 0;
            request.products = new string[order];
            for (int i = 0; i < order; i++)
            {
                Console.WriteLine($"Введите название {i+1} продукта");
                request.products[i] = Console.ReadLine();

                Console.WriteLine($"Введите стоимость {i+1} продукта");
                request.OrderAmount += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывожу данные");

            request.Print();

            //Console.WriteLine(request.ToString()); 

            Console.ReadLine();
        }
    }
}