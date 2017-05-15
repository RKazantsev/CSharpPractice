using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSum : {0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("Difference : {0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("Product : {0} x {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("Quotient : {0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("Remainder : {0} mod {1} = {2}", number1, number2, number1 % number2);
        }
    }
}
