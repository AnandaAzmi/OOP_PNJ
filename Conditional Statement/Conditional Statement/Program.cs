using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
        //Contoh Program IF-Else
            int a = 10, b = 20, c, d, e;
            c = a * b;

            if (c > 100)
                d = c - a;
            else
                d = c - b;
            e = d + c;

            Console.WriteLine("Hasil Nilai C = " + c);
            Console.WriteLine("Hasil Nilai D = " + d);
            Console.WriteLine("Hasil Nilai E = " + e);

            Console.ReadKey();

        //Contoh program login dengan IF

            string Username;
            String Password;

            //digunakan untuk menginput
            Console.WriteLine("Username :");
            Username = Console.ReadLine();

            Console.Write("Password : ");
            Password = Console.ReadLine();

            //logika percabangan jika username dan pass sama
            //maka konsisi pertama akan terpenuhi

            if (Username == "anandaazmi" && Password == "imzaadnana")
                Console.WriteLine("Anda berhasil login");
            //Kika tidak maka kondisi kedua akan terpenuhi
            else
                Console.WriteLine("Username atau Password anda salah");
            Console.ReadKey();

            //Contoh Menentukan predikat dengan If bersarang
            Console.Write("Masukan IPK : ");
            float ipk = Convert.ToSingle(Console.ReadLine());
            string predikat;

            if (ipk > 3.5)
                predikat = "Cum Laude";
            else if (ipk > 3)
                predikat = "Sangat Memuaskan";
            else if (ipk >= 2.75)
                predikat = "Memuaskan";
            else if (ipk >= 2)
                predikat = "Cukup";
            else
                predikat = "Memuakkan";

            Console.WriteLine("Predikat Anda adalah : {0}", predikat);

            Console.ReadKey();

            //Contoh Program Switch 1 : Menampilkan Nama Hari

            int Hari;
            Console.Write("Masukan Pilihan Hari (1-7) : ");
            Hari = Int32.Parse(Console.ReadLine());
            switch (Hari)
            {
                case 1:
                    Console.WriteLine("Hari Minggu");
                    break;
                case 2:
                    Console.WriteLine("Hari Senin");
                    break;
                case 3:
                    Console.WriteLine("Hari Selasa");
                    break;
                case 4:
                    Console.WriteLine("Hari Rabu");
                    break;
                case 5:
                    Console.WriteLine("Hari Kamis");
                    break;
                case 6:
                    Console.WriteLine("Hari Jumat");
                    break;
                case 7:
                    Console.WriteLine("Hari Sabtu");
                    break;
                default:
                    Console.WriteLine("Anda Salah memasukan input (1-7");
                    break;
                
            }
            Console.Read();

            //Contoh Program Switch 2 ; Memilih Minuman 
            string pilihan;
            Console.WriteLine("1 Untuk teh botol \n 2 Untuk fanta");
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
