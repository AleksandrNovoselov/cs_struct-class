using System;

namespace Client
{
    internal class Program
    {
        public struct Client
        {
            public int idClient;
            private static int id = 1;

            public string fio;
            public string address;
            public int phone;

            private int orders;
            private int totalSum;

            public int TotalSum
            {
                get => totalSum;
                set
                {
                    orders++;
                    totalSum += value;
                }
            }

            public Client(string fio, string address, Random phone)
            {
                idClient = id++;
                this.fio = fio;
                this.address = address;
                this.phone = phone.Next(111111, 999999);
                orders = 0;
                totalSum = 0;
            }

            public void Print()
            {
                Console.WriteLine($"Номер клиента: {idClient} ФИО: {fio}" +
                    $" адресс: {address} тел.: {phone} Кол-во заказов: {orders} Сумма заказов: {totalSum}");
            }

            public void fillArray(ref Client[] client)
            {
            }
        }

        private static void Main(string[] args)
        {
            //Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон;
            //количество заказов осуществленных клиентом;общая сумма заказов клиента.

            int number = 0;
            var random = new Random();

            Client[] client = new Client[3];

            for (int i = 0; i < client.Length; i++)
            {
                client[i] = new Client("Petrov" + i, "Izhevsk", random); //заполним какими-то клиентами
                client[i].Print();
            }

            while (number != -1)
            {
                Console.WriteLine("Введите номер клиента (для выхода 0)");
                number = int.Parse(Console.ReadLine());
                number--;

                if (number == -1)
                    break;

                Console.Write("Сумма заказа: ");

                client[number].TotalSum = int.Parse(Console.ReadLine());

                foreach (var item in client)
                {
                    item.Print();
                }
            }

            Console.WriteLine("Пока пока");
            Console.ReadLine();
        }
    }
}