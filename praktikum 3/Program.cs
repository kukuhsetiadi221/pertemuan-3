using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new mobil();
            mobil mobil2 = new mobil();

            mobil1.Merek = "Jeep";
            mobil1.Jumlah_pintu = 4f;
            mobil1.Warna = "Putih";
            mobil1.Model = "Rubicon";
            mobil1.Kecepatan = 180f;
            mobil1.Tahun_keluaran = "2003";
            mobil1.Suara = "telolet telolet";


            mobil1.Gas();
            mobil1.Klakson();
            mobil1.TampilkanInfo();
        }
    }
}
