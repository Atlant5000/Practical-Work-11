using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static void Value()
        {
            int s = Input("Введите количество секунд ");
            int m = Input("Введите количество минут ");
            int h = Input("Введите количество часов ");
            Conclusion("Количество секунд =", Seconds(s,m,h));
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Seconds(int s, int m, int h)
        {
            return s + m * 60 + h * 3600;
        }
        public static void Conclusion(string message, int s)
        {
            Console.WriteLine($"{message} {s}");
            Console.ReadLine();
        }
    }
}
