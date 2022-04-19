using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4274
{
    class Karyawan
    {
        static void Main(string[] args)
        {
            Karyawan data1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan data2 = new Karyawan(190302124, "Jono", 2000000);

            Console.WriteLine("No Nik/Nama       Gaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. " + data1.nik + " " + data1.nama + "     " + data1.gajibulanan);
            Console.WriteLine("2. " + data2.nik + " " + data2.nama + "     " + data2.gajibulanan);
            Console.WriteLine();
            Console.WriteLine("No Nik/Nama       Gaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. " + data1.nik + " " + data1.nama + "     " + data1.gajibulanan * 110 / 100);
            Console.WriteLine("2. " + data2.nik + " " + data2.nama + "     " + data2.gajibulanan * 110 / 100);

            Console.ReadKey();
        }
    }
}