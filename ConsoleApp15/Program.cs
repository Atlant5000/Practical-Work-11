using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input();
        }
        public static void Input()
        {
            Conclusion($"x=", Math.Round(Func(15, 8) + Func(6, 12) + Func(7, 21)));
            Console.ReadKey();
        }
        public static double Func(int a, int b)
        {
            return a+Math.Sqrt(b)  / b+Math.Sqrt(a);
        }
        public static void Conclusion(string message, double max)
        {
            Console.WriteLine($"{message} {max}");
        }
    }
}
