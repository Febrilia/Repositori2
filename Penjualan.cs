using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
        public void tambahpenjualan()
        {
            Console.WriteLine("Nota : 001");
            Console.WriteLine("Tanggal : 07-07-2020");
            Console.WriteLine("Customer : Anis");
            Console.WriteLine("Jenis [T/K]: T");
            Console.WriteLine("Total Nota : 500000");
        }

        public void hapuspenjualan()
        {
            Console.WriteLine("Nota : 1234");
            Console.WriteLine("\nNota tidak ditemukan");

            Console.WriteLine("Nota : 003");
            Console.WriteLine("\nData penjualan berhasil di hapus");
        }

        public void tampilpenjualan()
        {
            Console.WriteLine("1. 001, 07-07-2020, Anis, Tunai, 500000");
            Console.WriteLine("2. 002, 07-07-2020, Abdul, Tunai, 700000");
            Console.WriteLine("3. 003, 07-07-2020, Ahmad, Kredit, 750000");
            Console.WriteLine("4. 004, 07-07-2020, Sadewa, Kredit, 850000");
        }
    }
}
