using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Handphone : IKomunikasi 
    {
        public void Menginput()
        {
            Console.WriteLine("Handphone menginput dengan bantuan Pengguna nya");
            Console.WriteLine(" Dan Dengan bantuan hardware HP");
        }
    }
}