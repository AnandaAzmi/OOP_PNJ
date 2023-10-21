using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kesetaraan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 6;

            string foo1 = "Foo";
            string foo2 = "Foo";
            string foo3 = "foo";

            Console.WriteLine((a + b) == c);
            Console.WriteLine((a * b) == c);
            Console.WriteLine((a + b) != c);

            Console.WriteLine(foo1 == foo2);
            Console.WriteLine(foo1 == foo3);
            Console.WriteLine(foo1.ToLower() == foo3);

            Console.Read();
            //ToLower adalah metode atau fungsi yang digunakan untuk mengubah semua huruf dalam sebuah string menjadi huruf kecil (lowercase).
        }
    }
}
