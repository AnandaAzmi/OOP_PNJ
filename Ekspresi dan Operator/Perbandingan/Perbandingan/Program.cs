using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perbandingan
{
    class Program
    {
        static void Main(string[] args)
        {
            //bolean test
            float a = 32.3f;
            float b = 22.7f;
            float c = a;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("a > b = {0}", a > b);
            Console.WriteLine("a < b = {0}", a < b);
            Console.WriteLine("a >= b = {0}", a >= b);
            Console.WriteLine("a >= c = {0}", a >= c);
            Console.WriteLine("a <= b = {0}", a <= b);
            Console.WriteLine("a <= c = {0}", a <= c);

            Console.Read();
        }
    }
}
