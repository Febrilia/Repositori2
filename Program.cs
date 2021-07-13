using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Nota : 001");
            Console.WriteLine("Tanggal : 07-07-2020");
            Console.WriteLine("Customer : Anis");
            Console.WriteLine("Jenis [T/K]: T");
            Console.WriteLine("Total Nota : 500000");
       
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Nota : 1234");
            Console.WriteLine("\nNota tidak ditemukan");

            Console.WriteLine("Nota : 003");
            Console.WriteLine("\nData penjualan berhasil di hapus");
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("1. 001, 07-07-2020, Anis, Tunai, 500000");
            Console.WriteLine("2. 002, 07-07-2020, Abdul, Tunai, 700000");
            Console.WriteLine("3. 003, 07-07-2020, Ahmad, Kredit, 750000");
            Console.WriteLine("4. 004, 07-07-2020, Sadewa, Kredit, 850000");

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
