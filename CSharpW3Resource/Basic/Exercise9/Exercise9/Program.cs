using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4;
            Console.WriteLine("Input four numbers : ");
            Console.Write("Input the 1st number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2nd number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd number : ");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 4th number : ");
            number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of {0}, {1}, {2}, {3} numbers is {4}.",
                number1, number2, number3, number4, (number1 + number2 + number3 + number4) / 4);
        }
    }
}
