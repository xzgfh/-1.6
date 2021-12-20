using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба__1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation obj = new LinearEquation()
            {
                A = 1,
                B = 4,
                C = 0
            };
            double result = obj.F();
            if (double.IsNaN(result))
            {
                Console.WriteLine($"ошибка");
            }
            else
            {
                Console.WriteLine($"x={result}");
            }
        }
    }
}
