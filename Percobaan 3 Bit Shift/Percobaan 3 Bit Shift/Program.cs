using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percobaan_3_Bit_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            // bit shifting untuk perkalian dan pembagian 2***
            int a = 2048; int b = 1339; double c = 1355; int d = -20; int e = -35;

            int a_divide = a / 8; int a_shift = a >> 3;
            int b_divide = b / 4 * 2; int b_shift = (b >> 2) << 1;
            double c_divide = c / 4 * 2; int c_shift = ((int) c >> 2) << 1; // error jika tidak di-cast ke int = int e_divide = e / 16 * 2; int e_shift (e >> 4) << 1; =
            int d_divide = d / 8; int d_shift = d >> 3;
            int e_divide = e / 16 * 2; int e_shift = (e >> 4) << 1;

            Console.WriteLine("a={0} ({1})", a, Convert.ToString(a, toBase: 2)); 
            Console.WriteLine("a / 8 = {0} ({1})", a_divide, Convert.ToString(a_divide, toBase: 2));
            Console.WriteLine("a >> 3 = {0} ({1})", a_shift, Convert.ToString(a_shift, toBase: 2));
            Console.WriteLine();

            Console.WriteLine("b={0} ({1})", b, Convert.ToString(b, toBase: 2));
            Console.WriteLine("b / 4 * 2 = {0} ({1})", b_divide, Convert.ToString(b_divide, toBase: 2));
            Console.WriteLine("(b >> 2) << 1 = {0} ({1})", b_shift, Convert.ToString(b_shift, toBase: 2));
            Console.WriteLine();

            Console.WriteLine("c = {0} ({1})", c, Convert.ToString(BitConverter.DoubleToInt64Bits(c), toBase: 2));
            Console.WriteLine("c / 4 * 2 = {0} ({1})", c_divide, Convert.ToString(BitConverter.DoubleToInt64Bits(c_divide), toBase: 2));
            Console.WriteLine("(c >> 2) << 1 = {0} ({1})", c_shift, Convert.ToString(c_shift, toBase: 2));
            Console.WriteLine();

            Console.WriteLine("d={0} ({1})", d, Convert.ToString(d, toBase: 2));
            Console.WriteLine("d / 8 = {0} ({1})", d_divide, Convert.ToString(d_divide, toBase: 2));
            Console.WriteLine("d >> 3 = {0} ({1})", d_shift, Convert.ToString(d_shift, toBase: 2));
            Console.WriteLine();

            Console.WriteLine("e = {0} ({1})", e, Convert.ToString(e, toBase: 2));
            Console.WriteLine("e / 16 * 2 = {0} ({1})", e_divide, Convert.ToString(e_divide, toBase: 2)); 
            Console.WriteLine("(e >> 4) << 1 = {0} ({1})", e_shift, Convert.ToString(e_shift, toBase: 2));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
