//25.11.6576
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDanObject_6576
{
    public class Mahasiswa
    {
        public string Nim {  get; set; }
        public  string Nama { get; set; }
        public float Ipk { get; set; }


        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("NIM: {0}", Nim);
            Console.WriteLine("IPK:{0}", Ipk);
            Console.WriteLine("\nTelah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses Krs", Nama);
        }

    }
}
