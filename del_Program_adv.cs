using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3012T
{

    class Program
    {

        delegate double Method_return_double_accepts_2_doubles(double a, double b);

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Minus(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Number 1:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number 2:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operation + - * / ");
            string operation = Console.ReadLine();

            Dictionary<string, Method_return_double_accepts_2_doubles> mapOperToMethod = 
                new Dictionary<string, Method_return_double_accepts_2_doubles>();
            mapOperToMethod.Add("+", Add);
            mapOperToMethod.Add("ADD", Add);
            mapOperToMethod.Add("-", Minus);
            mapOperToMethod.Add("*", Mul);
            mapOperToMethod.Add("/", Div);

            Console.WriteLine(mapOperToMethod[operation].Invoke(x, y));
        }
    }
}
