﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("After Swapping : ");
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + number2);
        }
    }
}
