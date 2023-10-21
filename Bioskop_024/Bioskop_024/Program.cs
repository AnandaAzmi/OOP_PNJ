using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bioskop_024
{
    class Program
    {
        static void Main(string[] args)
        {

            int hargaH = 1;
            int hargaR = 1;
            int horor = 1;
            int romantic = 1;
            Console.WriteLine("Horor :");
            Console.WriteLine("1. Annabelle ");
            Console.WriteLine("2. The Conjuring ");
            Console.WriteLine("3. KKN di Desa Penari ");
            Console.WriteLine();
            Console.WriteLine("Romantic : ");
            Console.WriteLine("1. Be With You");
            Console.WriteLine("2. Tune in for Love ");
            Console.WriteLine("3. Habibie dan Ainun ");
            Console.WriteLine();

            Console.WriteLine("Silahkan pilih film anda :");
            Console.Write("Horor : ");
            horor = Int32.Parse(Console.ReadLine());
            Console.Write("Romantic : ");
            romantic = Int32.Parse(Console.ReadLine());
            switch (horor)
            {
                case 1:
                    hargaH = 7500;
                    break;
                case 2:
                    hargaH = 6000;
                    break;
                case 3:
                    hargaH = 4000;
                    break;
                default:
                    Console.WriteLine("empty");
                    break;
            }

            switch (romantic)
            {
                case 1:
                    hargaR = 5000;
                    break;
                case 2:
                    hargaR = 3000;
                    break;
                case 3:
                    hargaR = 2500;
                    break;
                default:
                    Console.WriteLine("empty");
                    break;
            }
            Console.WriteLine();
            int bayar = hargaH + hargaR;
            Console.WriteLine("Harga Bayar : {0}", bayar);
            Console.ReadLine();
 
        }
    }
}
