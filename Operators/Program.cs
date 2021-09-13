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

            int value1, value2, addition, subtraction, multiplication, division;

            Console.WriteLine("enter first value : ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second value : ");
            value2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("addition : ");
            addition = value1 + value2;
            Console.WriteLine(addition);

            Console.Write("Subtraction : ");
            subtraction = value1 - value2;
            Console.WriteLine(subtraction);

            Console.Write("Multiplication : ");
            multiplication = value1 * value2;
            Console.WriteLine(multiplication);

            Console.Write("Division : ");
            division = value1 / value2;
            Console.WriteLine(division);

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
