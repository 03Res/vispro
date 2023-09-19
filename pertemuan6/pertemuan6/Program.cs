using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Segitiga Pascal");
            Console.WriteLine("2. Deret Fibonacci");
            Console.WriteLine("3. About");
            Console.WriteLine("0. Keluar");
            Console.Write("Pilih menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Masukkan jumlah baris segitiga Pascal: ");
                    int numRows = int.Parse(Console.ReadLine());
                    GeneratePascalTriangle(numRows);
                    break;

                case 2:
                    Console.Write("Masukkan panjang deret Fibonacci: ");
                    int fibLength = int.Parse(Console.ReadLine());
                    GenerateFibonacciSeries(fibLength);
                    break;

                case 3:
                    DisplayAbout();
                    break;

                case 0:
                    Console.WriteLine("Terima kasih telah menggunakan program ini!");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    break;
            }
        } while (choice != 0);
    }

    static void GeneratePascalTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            BigInteger currentValue = 1;
            int leadingSpaces = numRows - i;

            // Tambahkan spasi di awal setiap baris
            for (int j = 0; j < leadingSpaces; j++)
            {
                Console.Write("  ");
            }

            // Cetak nilai dalam baris saat ini
            for (int j = 0; j <= i; j++)
            {
                Console.Write(currentValue.ToString().PadLeft(4));
                currentValue = currentValue * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }

    static void GenerateFibonacciSeries(int length)
    {
        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 0; i < length; i++)
        {
            Console.Write(a + " ");
            BigInteger temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine();
    }

    static void DisplayAbout()
    {
        Console.WriteLine("Tentang Program Segitiga Pascal dan Deret Fibonacci:");
        Console.WriteLine("-Program ini adalah contoh sederhana dari penggunaan menu dalam aplikasi konsol.");
        Console.WriteLine("-Dapat digunakan untuk menghasilkan Segitiga Pascal dan Deret Fibonacci.");
        Console.WriteLine("-Segitiga Pascal adalah pola angka segitiga yang muncul dalam matematika, sementara Deret Fibonacci adalah deret angka di mana setiap angka adalah penjumlahan dari dua angka sebelumnya.");
        Console.WriteLine("-Program ini dibuat oleh [soruday, quaresma pergamus].");
    }
}
