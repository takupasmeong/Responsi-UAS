using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                reinput:
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan(daftarPenjualan);
                        break;

                    case 2:
                        HapusPenjualan(daftarPenjualan);
                        break;

                    case 3:
                        TampilPenjualan(daftarPenjualan);
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        goto reinput;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("menu :\n1. Tambah Penjualan\n2. Hapus Penjualan\n3. Tampilkan Penjualan\n4. Keluar");
        }

        static void TambahPenjualan(List<Penjualan> ListPenjualan)
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan\n");

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Console.Write("Nota : ");
            penjualan.NoNota = Console.ReadLine();
            Console.Write("Tanggal [dd/mm/yyyy]: ");
            penjualan.Tanggal = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Customer : ");
            penjualan.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            penjualan.JenisPembayaran = Console.ReadLine();
            Console.Write("Total Nota : ");
            penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

            ListPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan(List<Penjualan> ListPenjualan)
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Penjualan\n");

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            string NoNota;
            bool status = false;

            Console.Write("Nota : ");
            NoNota = Console.ReadLine();

            for (int i = 0; i < ListPenjualan.Count; i++)
            {
                if (NoNota == ListPenjualan[i].NoNota)
                {
                    ListPenjualan.Remove(ListPenjualan[i]);
                    status = true;
                }
                else
                {
                    status = false;
                }
            }

            if (status)
            {
                Console.WriteLine("\nData penjualan berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nNota tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan(List<Penjualan> ListPenjualan)
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan\n");

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int noUrut = 1;

            foreach (Penjualan penjualan in ListPenjualan)
            {
                if (penjualan.JenisPembayaran == "T")
                {
                    penjualan.JenisPembayaran = "Tunai";
                }
                else if (penjualan.JenisPembayaran == "K")
                {
                    penjualan.JenisPembayaran = "Kredit";
                }
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", noUrut, penjualan.NoNota, penjualan.Tanggal.ToString("dd-MM-yyyy"), penjualan.Customer, penjualan.JenisPembayaran, penjualan.TotalNota);
                noUrut++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
