using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_3
{
    internal class mobil
    {
        public string Warna { get; set; }
        public float Jumlah_pintu { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public string Tahun_keluaran { get; set; }
        public float Kecepatan { get; set; }
        public string Suara { get; set; }

        public void Gas()
        {
            Console.Write(" Mobil {0}", Model);
            Console.Write(" berjalan dengan kecepatan {0}km/jam\n", Kecepatan);
        }

        public void Klakson()
        {
            Console.WriteLine("\n Suara {0}\n", Suara);
        }

        public void TampilkanInfo()
        {
            Console.Write(" Mobil saya berwarna {0}", Warna);
            Console.Write(" merek {0}", Merek);
            Console.Write(" model {0}", Model);
            Console.Write(" keluaran tahun {0}", Tahun_keluaran);
            Console.Write(" jumlah pintu sebanyak {0}\n", Jumlah_pintu);
            Console.ReadKey();   
        }
    }
}
