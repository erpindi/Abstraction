using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IKomunikasi komunikasi;

            komunikasi = new Komputer();
            komunikasi.Menginput();

            Console.WriteLine();

            komunikasi = new Handphone();
            komunikasi.Menginput();

            Console.WriteLine();

            komunikasi = new Laptop();
            komunikasi.Menginput();

            Console.ReadKey();
        }
    }
}