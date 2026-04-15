using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDanObject_6576
{
     class Program
    {
        static void Main(string[] args)

        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nim = "25.11.6576";
            saya.Nama = "Defvin";
            saya.Ipk = 4.0f;


            kamu.Nim = "6576";
            kamu.Nama = "Taqiy";
            kamu.Ipk = 3.5f;

            saya.Registrasi();
            saya.IsiKrs();

            Console.WriteLine();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();

        }
    }
}
