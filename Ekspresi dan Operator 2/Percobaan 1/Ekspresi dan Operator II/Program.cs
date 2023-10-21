using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekspresi_dan_Operator_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int binaryTest = 0b_1000_0010;

            Console.WriteLine($"{ Convert.ToString(binaryTest, toBase: 2)} adalah bentuk biner untuk bilangan bulat {binaryTest}.");
            Console.WriteLine($"Dalam format char, {Convert.ToString(binaryTest, toBase: 2)} adalah {Convert.ToChar(binaryTest)}");
            Console.ReadLine();
        }
    }
}
