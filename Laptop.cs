using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Laptop : IKomunikasi
    {
        public void Menginput()
        {
            Console.WriteLine("Laptop Menginput dengan Bantuan Hardware");
            Console.WriteLine("Dan Di Input dengan Pengguna nya sendiri");
            Console.WriteLine("Serta bantuan Mesin yang sudah tertanam di Laptop");
        }
    }
}