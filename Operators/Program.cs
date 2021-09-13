using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, result;

            Console.WriteLine("enter first value : ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second value : ");
            value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result : ");
            result = value1 - value2;
            Console.WriteLine(result);

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
