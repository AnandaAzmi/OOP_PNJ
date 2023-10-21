using System;

namespace Tugas_2_2207431024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama           : ");
            string nama = Console.ReadLine();

            Console.Write("Nama Panggilan : ");
            string namaP = Console.ReadLine();

            Console.Write("NIM            : ");
            string NIM = Console.ReadLine();

            Console.Write("Tempat Lahir   : ");
            string tempatL = Console.ReadLine();

            Console.Write("Umur           : ");
            string umur = Console.ReadLine();

            Console.Write("Alamat         : ");
            string alamat = Console.ReadLine();

            Console.Write("Telepon        : ");
            string telepon = Console.ReadLine();

            Console.WriteLine("Assalamualaikum. Let me introduce myself.");
            Console.WriteLine("My name is {0}, but you can call me {1}.", nama, namaP);
            Console.WriteLine("My NPM is {0}.", NIM);
            Console.WriteLine("I was born in {0} and I am {1} years old.", tempatL, umur);
            Console.WriteLine("I am very glad if you want to invite me to your house at {0}.", alamat);
            Console.WriteLine("So, don't forget to call me at {0}.", telepon);

            Console.WriteLine("Thank you.");
            Console.Read();
        }
    }
}
