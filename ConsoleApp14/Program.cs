using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input();
        }
        public static void Input()
        {
            Conclusion($"y=", Math.Round(Func(7) + Func(11) + Func(15), 2));
            Console.ReadKey();
        }
        public static double Func(int a)
        {
            return (Math.Sqrt(a) + a) / 3;
        }
        public static void Conclusion(string message, double max)
        {
            Console.WriteLine($"{message} {max}");
        }
    }
}
