using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input();
        }
        public static void Input()
        {
            Conclusion($"x=",Math.Round(Func(6) + Func(13) + Func(21), 2));
            Console.ReadKey();
        }
        public static double Func(int a)
        {
            return (Math.Sqrt(a) + a) / 2;
        }
        public static void Conclusion(string message, double max)
        {
            Console.WriteLine($"{message} {max}");
        }
    }
}
