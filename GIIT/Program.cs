using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите число: #");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: #");
            int y = int.Parse(Console.ReadLine());
            stepen(x, y);
            Console.WriteLine("Результат : " + stepen(x, y));
            int o = 0;
            string str = "";
        }
        public static int stepen(int x, int y)
        {
            int res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }
        public static int Kyb(int x)
        {
            int res = 1;
            for (int i = 0; i < 3; i++)
            {
                res = x * x;
            }
            return res;
        }
        public static int Kybb(int x)
        {
            int res = 1;
            for (int i = 0; i < 3; i++)
            {
                res = x * x;
            }
            return res;
        }

    }
}

