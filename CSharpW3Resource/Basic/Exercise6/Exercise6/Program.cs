using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.Write("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Input the Third Number : ");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The product of numbers : {0} x {1} x {2} = {3}", 
                number1, number2, number3, number1*number2*number3);
        }
    }
}
