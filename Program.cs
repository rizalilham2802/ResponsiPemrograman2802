using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2802
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan Karyawan1 = new karyawan ("1.","190302123","Paijo",3000000);
            karyawan Karyawan2 = new karyawan("2.", "190302124", "Jono",2000000);
            Console.WriteLine("No\tNIK\t Nama\t  gaji Bulanan\t");
            Console.WriteLine("----------------------------------");
            Karyawan1.GajiMurni();
            Karyawan2.GajiMurni();
            Console.WriteLine();
            Console.WriteLine("\nAsyiiiiik kenaikan gaji 10%!!\n");
            Console.WriteLine("No\tNIK\t Nama\t  gaji Bulanan\t");
            Console.WriteLine("----------------------------------");
            Karyawan1.KenaikanGaji();
            Karyawan2.KenaikanGaji();
            Console.ReadKey();

        
        }
    }
}
