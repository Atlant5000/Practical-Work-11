using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input();
        }
        public static void Input()
        {
            Conclusion($"x=", Math.Round(Func(2, 5) + Func(5, 13) + Func(11, 8)));
            Console.ReadKey();
        }
        public static double Func(int a, int b)
        {
            return (Math.Sqrt(a) + a / Math.Sqrt(b) + b);
        }
        public static void Conclusion(string message, double max)
        {
            Console.WriteLine($"{message} {max}");
        }
    }
}
