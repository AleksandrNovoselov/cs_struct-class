using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cs_struct_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();

            myArray.InputNumber();
            myArray.FindNumber();

            Console.ReadLine();
        }
    }
}
