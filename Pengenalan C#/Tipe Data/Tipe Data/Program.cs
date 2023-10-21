using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipe_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            double harga = 30;
            double diskon = 0.2;
            double hargaDiskon = harga - (harga * diskon);

            Console.WriteLine("Harga Dasar  : " + harga);
            Console.WriteLine("Diskon   : " + diskon * 100 + "%");
            Console.WriteLine("Harga    : " + hargaDiskon);
            Console.Read();
        }
    }
}
