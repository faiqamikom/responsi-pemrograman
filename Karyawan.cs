using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4274
{
    class Karyawan
    {
        public int nik;
        public string nama;
        public int gajibulanan;

        public int Nik
        {
            get { return nik; }
            set { nik = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int GajiBulanan
        {
            get { return gajibulanan; }
            set { gajibulanan = value; }
        }

        public Karyawan(int nik, string nama, int gajibulanan)
        {
            this.nik = nik;
            this.nama = nama;
            this.gajibulanan = gajibulanan;
            if(gajibulanan < 0 )
            {
                this.gajibulanan = 0;
            }
        }
    }
}
