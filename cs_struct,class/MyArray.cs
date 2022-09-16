using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_struct_class
{
    internal class MyArray
    {
        private int _number;
        private bool _result;
        int _count = 0;
        int _size = 250;

        public void InputNumber()
        {
            Console.WriteLine("Дан какой-то массив целых чисел от 0 до 9." +
                "\nВведите число и узнаем сколько раз оно встречается в массиве.");

            do
            {
                _result = int.TryParse(Console.ReadLine(), out _number);

                if (!_result)
                    Console.WriteLine("Вводить надо цифры");
                if (_number < 0 || _number > 9)
                {
                    Console.WriteLine("Вводить надо цифры от 0 до 9");
                    _result = false;
                }

            } while (!_result);
        }

        public void FindNumber()
        {
            var random = new Random();
            int[] arr = new int[_size];

            for (int i = 0; i < _size; i++)
            {
                arr[i] = random.Next(0, 10);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nПровожу поиск...");

            foreach (var item in arr)
            {
                if (item == _number)
                    _count++;
            }

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"Число \"{_number}\" встречается {_count} раз");

        }
    }
}
