using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SecondOperand()
            {
                Console.WriteLine("Operand kedua diperiksa");
                return true;
            }

            bool a = false;

            //negation
            Console.WriteLine("a ={0}, maka !a={1}", a, !a);
            Console.WriteLine();

            //bitwice
            Console.WriteLine(false & SecondOperand());
            Console.WriteLine(true & SecondOperand());
            Console.WriteLine(false | SecondOperand());
            Console.WriteLine();

            //conditional logic
            Console.WriteLine(false && SecondOperand());
            Console.WriteLine(true && SecondOperand());
            Console.WriteLine(true || SecondOperand());
            Console.WriteLine();

            //ternary
            Console.WriteLine(a ? 1 : 0);
            Console.WriteLine(!a ? 1 : 0);
            Console.WriteLine();
            Console.Read();

            //yang membedakan | dengan || adalah
            //Operator "|" adalah operator bitwise yang dapat digunakan untuk melakukan operasi OR bit-level pada nilai-nilai integer.
            //Operator "||" adalah operator logika yang digunakan untuk melakukan operasi OR logika pada nilai-nilai boolean.
        }
    }
}
