using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetika_Biner
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 18.2f;
            float b = 0f;

            Console.WriteLine("a = {0} dan b = {1}", a, b);
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);

            a += b;
            //assignment
            Console.WriteLine("a += b adalah {0}", a);
            Console.Read();
            
        }
    }
}
