using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IF_ELSE_024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nilai akhir [0....100] : ");
            string input = Console.ReadLine();
            float nilai_akhir;
            string grade;
            if (float.TryParse(input, out nilai_akhir))
            {
                if (nilai_akhir >= 0 && nilai_akhir <= 100)
               {
                    if (nilai_akhir >= 81)
                        grade = "Grade A";
                    else if (nilai_akhir >= 76)
                        grade = "Grade A-";
                    else if (nilai_akhir >= 72)
                        grade = "Grade B+";
                    else
                        grade = "Grade Z";
                    Console.WriteLine("{0}", grade);
                }
                else
                    Console.WriteLine("Inputan nilai salah");

            }
            else
                Console.WriteLine("Inputan harus nilai");
            
            
            Console.ReadKey();
        }
    }
}
