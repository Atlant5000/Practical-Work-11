﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Func(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        static void Value()
        {
            int number1 = Input("a=");
            int number2 = Input("b=");
            int number3 = Input("c=");
            int number4 = Input("d=");
            Conclusion($"Наибольшее число = ", Func(number1, number2)+Func(number3,number4));
            Console.ReadLine();
        }
        public static void Conclusion(string message, int max)
        {
            Console.WriteLine($"{message} {max}");
        }
    }
}