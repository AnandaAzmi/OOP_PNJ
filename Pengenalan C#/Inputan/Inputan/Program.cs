using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perintah Input");
            Console.Write("Masukan Nama Anda =\t");
            string nama = Console.ReadLine();
            Console.WriteLine("nama anda adalah {0}", nama);
            Console.Read();
        }
    }
}
