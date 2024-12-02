using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static void Value()
        {
            int r = Input("Введите количество рублей ");
            int k = Input("Введите количество копеек ");
            Conclusion("Количество копеек =", Kop(r, k));
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Kop (int r, int k)
        {
            return k + r*100;
        }
        public static void Conclusion(string message, int m)
        {
            Console.WriteLine($"{message} {m}");
            Console.ReadLine();
        }
    }
}
