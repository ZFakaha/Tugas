using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2283
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            // pengesetan properties
            karyawan1.NIK = "21114337";
            karyawan1.Nama = "Zulfa Fakaha";
            karyawan1.Gaji = 10000000;

            // membuat objek Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            Console.WriteLine("=============== Gaji Karyawan ===============");
            Console.WriteLine("---------------------------------------------");

            // pengesetan properties
            karyawan2.NIK = "21114337";
            karyawan2.Nama = "Zul";
            karyawan2.Gaji = 15000000;
            

            //pemanggilan method
            Console.WriteLine("No. \tNik\t/Nama\t\tGaji Bulanan");

            Console.WriteLine("1. \t{0} {1}\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Gaji);
          
            if (karyawan1.Gaji <= 0)
            {
                Console.WriteLine("Mohon maaf gaji anda harus lebih dari Rp.100");
            }
            else
            {
                Console.WriteLine("2. \t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.Gaji);
            }
            Console.WriteLine("\n");
            Console.WriteLine("SELAMATTTT ANDA NAIK GAJI 10% !!! ");

            Console.WriteLine();

            
            Console.WriteLine("\n");
            Console.WriteLine("============= Gaji anda saat ini =============");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("No. \tNik\t/Nama\t\tGaji Bulanan");
            Console.WriteLine("1. \t{0} {1}\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Gaji + (karyawan1.Gaji * 0.10));
            if (karyawan1.Gaji <= 0)
            {
                Console.WriteLine("Mohon maaf gaji anda harus lebih dari Rp.100");
            }
            else
            {
                Console.WriteLine("2. \t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.Gaji + (karyawan2.Gaji * 0.10));
            }
            Console.ReadKey();
        }
    }
}