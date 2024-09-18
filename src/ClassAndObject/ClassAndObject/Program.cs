using System;
using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Buku buku = new Buku("Nama Buku", "Penulis Buku", 2021);
            buku.TampilkanInfo();

            Mobil mobil = new Mobil("Toyota", "Corolla", 2020);
            mobil.TampilkanSpesifikasi();

            Laptop laptop = new Laptop("Dell", "Intel Core i7", 16, 512);
            laptop.TampilkanSpesifikasi();

            Sepeda sepeda = new Sepeda("Polygon", "Mountain Bike", 14.5);
            sepeda.TampilkanInformasi();

            Kalkulator kalkulator = new Kalkulator();

            double penjumlahan = kalkulator.Tambah(5, 3);
            double pengurangan = kalkulator.Kurang(5, 3);
            double perkalian = kalkulator.Kali(5, 3);
            double pembagian = kalkulator.Bagi(6, 3);

            Console.WriteLine("Hasil Penjumlahan: " + penjumlahan);
            Console.WriteLine("Hasil Pengurangan: " + pengurangan);
            Console.WriteLine("Hasil Perkalian: " + perkalian);
            Console.WriteLine("Hasil Pembagian: " + pembagian);

            try
            {
                double hasilBagiNol = kalkulator.Bagi(3.5, 0);
                Console.WriteLine("Hasil pembagian dengan nol: " + hasilBagiNol);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Kesalahan: " + e.Message);
            }
        }
    }
}