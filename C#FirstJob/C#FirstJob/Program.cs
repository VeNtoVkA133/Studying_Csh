using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_FirstJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e;
            double x;
            double y;
            double d;
            double d1;
            double d2;
            double dd;
            int nd;
            string s1 = "Задание: ";
            string s2 = "Вычислить значение арифметического выражения.";
            string s3 = "x, y - исходные данные";
            string ss2 = "Преобразовать вещественные данные в целые.";
            string ss3 = "([*]- целая часть числа)";
            string se = "Экспонента = ";

            e = Math.Exp(1);
            Console.WriteLine(se+ e);

            /* Console.ForegroundColor = ConsoleColor.Cyan;*/
            Console.WriteLine(s1 /* Console.ForegroundColor = ConsoleColor.White, */ + s2 + /* Console.ForegroundColor = ConsoleColor.Yellow, */ s3);
            /* Console.ForegroundColor = ConsoleColor.White; */

            Console.WriteLine("Введите значение X...");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите значение Y...");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            d = (x * Math.Pow(e, x * y) + 8 * Math.Pow(Math.Sin(x), 2)) / (x * (x - y) * (3 * x + y));

            Console.WriteLine("d = " + d);

            d1 = x * Math.Pow(e, x * y) + 8 * Math.Pow(Math.Sin(x), 2);
            d2 = x * (x - y) * (3 * x + y);
            dd = d1 / d2;

            Console.WriteLine("dd = " + dd);

            /* Console.ForegroundColor = ConsoleColor.Cyan; */
            Console.WriteLine(s1 /* Console.ForegroundColor = ConsoleColor.White, */+ ss2 +/* Console.ForegroundColor = ConsoleColor.Yellow, */ ss3);
            /* Console.ForegroundColor = ConsoleColor.White; */

            nd = Convert.ToInt32(d);

            Console.WriteLine("m = " + d);
            Console.WriteLine("n = " + nd);

            Console.ReadLine();

        }
    }
}
