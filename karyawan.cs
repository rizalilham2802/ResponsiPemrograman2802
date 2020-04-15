using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2802
{
    class karyawan
    {
        public string No { get; set; }
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public karyawan(string no, string nik, string nama, int gajibulanan)
        {
            No = no;
            Nik = nik;
            Nama = nama;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }
        }
        public void GajiMurni()
        {
            Console.WriteLine(" {0} {1}\t {2}\t {3}\t", No, Nik, Nama, GajiBulanan);
        }
        public void KenaikanGaji()
        {
            Console.WriteLine(" {0} {1}\t {2}\t {3}\t", No, Nik, Nama, (GajiBulanan * 110/100));
        }
    }
}
