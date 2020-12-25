using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._3
{
    class Program
    {
        public static double Fac(double n)
        {
            double factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            try
            {
                double result = 0;
                Console.WriteLine("Введите число рядов: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число x: ");
                int x = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    result += (Math.Pow(3, i)) * Math.Pow(x, 2)/ Fac(i);
                }
                Console.WriteLine($"Сумма {n} рядов = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}