using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static void Value()
        {
            int k = Input("Введите количество километров ");
            int m = Input("Введите количество метров ");
            Conclusion("Количество метров =", Meters(k, m));
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Meters(int k,int m) 
        {
            return k * 1000 + m;
        }
        public static void Conclusion(string message, int m)
        {
            Console.WriteLine($"{message} {m}");
            Console.ReadLine();
        }
    }
}
