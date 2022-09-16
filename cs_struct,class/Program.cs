using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cs_struct_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int number, count=0;

            Console.WriteLine("Дан какой-то массив целых чисел от 0 до 9." +
                "\nВведите число и узнаем сколько раз оно встречается в массиве.");
            
            do 
            {
                result = int.TryParse(Console.ReadLine(), out number);

                if (!result)
                    Console.WriteLine("Вводить надо цифры");
                if (number < 0 || number > 9)
                { 
                    Console.WriteLine("Вводить надо цифры от 0 до 9");
                    result = false;
                }

            } while (!result);

            int size = 250;
            var random = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(0, 10);
            }
            for (int i = 0; i < size ; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nПровожу поиск...");

            foreach (var item in arr)
            {
                if (item==number)
                    count++;
            }
            Thread.Sleep(1000);

            Console.WriteLine($"Число \"{number}\" встречается {count} раз") ;


            Console.ReadLine();
        }
        
    }
}
