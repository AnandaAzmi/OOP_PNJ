using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memilih_minuman
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            Console.WriteLine("1 Untuk teh botol \n2 Untuk fanta");
            Console.Write("Masukan Pilihan Anda : ");
            pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Anda memilih Teh botol");
                    break;
                default:
                    Console.Write("Anda lebih memilih Fanta");
                    break;
            }
            Console.Read();

        }
    }
}
