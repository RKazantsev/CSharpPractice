using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Input the Number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Output : ");
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }
        }
    }
}
