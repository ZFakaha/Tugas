using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2283
{
    class Karyawan
    {
        //CONSTRUCTOR
        public Karyawan()
        {

        }
        //OVERLOAD
        public Karyawan(string nama, string nik, int gaji)
        {
            Nama = nama;
            NIK = nik;
            Gaji = gaji;
        }
        
        //PROPERTIES
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int Gaji { get; set; }


    }
}