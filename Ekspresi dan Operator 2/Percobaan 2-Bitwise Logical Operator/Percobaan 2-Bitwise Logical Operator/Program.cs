using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan_2_Bitwise_Logical_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // bitwise XOR untuk mengubah case huruf + type conversion
            char testChar = 'c';
            var caseMask = 0b_0010_0000;
            Console.WriteLine("{0} adalah representasi biner untuk huruf {1} dengan desimal {2}", Convert.ToString(testChar, toBase: 2), testChar, (int)testChar);
            char maskedChar = (char)(testChar ^ caseMask);
            Console.WriteLine("Hasil XOR dari testChar {0} adalah huruf {1} dengan desimal {2}", Convert.ToString(testChar, toBase: 2), maskedChar, (int)maskedChar);
            char maskedChar2 = (char)(maskedChar ^ caseMask);
            Console.WriteLine("Hasil XOR dari maskedChar = {0} adalah huruf {1} dengan desimal {2}",
            Convert.ToString(maskedChar, toBase: 2), maskedChar2,
            (int)maskedChar2);
            Console.ReadLine();
        }
    
    }
}
