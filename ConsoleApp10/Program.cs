using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static void Value()
        {
            int m = Input("Введите количество метров ");
            int c = Input("Введите количество сантиметров ");
            Conclusion("Количество сантиметров =", Centimeters(c, m));
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Centimeters(int c, int m)
        {
            return  m+100+c;
        }
        public static void Conclusion(string message, int c)
        {
            Console.WriteLine($"{message} {c}");
            Console.ReadLine();
        }
    }
}
