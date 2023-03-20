using System;

namespace MenuMatematika
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan = 0;
            do
            {
                Console.WriteLine("Menu Matematika");
                Console.WriteLine("================");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("5. Keluar");

                Console.Write("Masukkan pilihan Anda (1-5): ");
                pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.Write("Masukkan angka pertama: ");
                        int angka1 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua: ");
                        int angka2 = int.Parse(Console.ReadLine());
                        int hasilJumlah = angka1 + angka2;
                        Console.WriteLine("Hasil penjumlahan adalah: " + hasilJumlah);
                        break;

                    case 2:
                        Console.Write("Masukkan angka pertama: ");
                        int angka3 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua: ");
                        int angka4 = int.Parse(Console.ReadLine());
                        int hasilKurang = angka3 - angka4;
                        Console.WriteLine("Hasil pengurangan adalah: " + hasilKurang);
                        break;

                    case 3:
                        Console.Write("Masukkan angka pertama: ");
                        int angka5 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua: ");
                        int angka6 = int.Parse(Console.ReadLine());
                        int hasilKali = angka5 * angka6;
                        Console.WriteLine("Hasil perkalian adalah: " + hasilKali);
                        break;

                    case 4:
                        Console.Write("Masukkan angka pertama: ");
                        int angka7 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua: ");
                        int angka8 = int.Parse(Console.ReadLine());
                        double hasilBagi = (double)angka7 / angka8;
                        Console.WriteLine("Hasil pembagian adalah: " + hasilBagi);
                        break;

                    case 5:
                        Console.WriteLine("Terima kasih telah menggunakan program ini.");
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid, silakan coba lagi.");
                        break;
                }

                Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            while (pilihan != 5);
        }
    }
}
