using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetika_Linear
{
    class Program
    {
        static void Main(string[] args)
        {
            //unary aritmetika test
            float a, b;
            a = b = 32.2f;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("-a = {0}", -a);
            Console.WriteLine("+a = {0}", +a);
            Console.WriteLine();

            //postfix ++
            Console.WriteLine("a= {0}", a);
            Console.WriteLine("a++ = {0}", a++);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine();

            //prefix ++
            Console.WriteLine("b= {0}", b);
            Console.WriteLine("++b = {0}", ++b);
            Console.WriteLine("b= {0}", b);
            Console.WriteLine();
            Console.Read();

            //yang membedakan postfix operator dengan prefix operator adalah :
            //Jika Anda menggunakan operator postfix, nilai variabel digunakan terlebih dahulu dalam perhitungan sebelum ditingkatkan atau diturunkan.
            //Sedangkan operator prefix akan terlebih dahulu meningkatkan atau menurunkan nilai variabel dan kemudian nilai yang baru diperoleh digunakan dalam perhitungan.
        }
    }
}
