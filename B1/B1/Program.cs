using System;

class Program
{
    static int CalculatePascalCoefficient(int row, int col)
    {
        if (col == 0 || col == row)
            return 1;
        return CalculatePascalCoefficient(row - 1, col - 1) + CalculatePascalCoefficient(row - 1, col);
    }

    static void DisplayPascalTriangle(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int space = 1; space < rows - i; space++)
                Console.Write("  ");

            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalCoefficient(i, j) + "   ");
            }
            Console.WriteLine();
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void DisplayExplanation()
    {
        Console.WriteLine("Penjelasan Deret Fibonacci:");
        Console.WriteLine("Deret Fibonacci adalah deret bilangan yang dimulai dari 0 dan 1,");
        Console.WriteLine("dengan setiap bilangan berikutnya adalah penjumlahan dari dua bilangan sebelumnya.");
        Console.WriteLine("Contoh: 0, 1, 1, 2, 3, 5, 8, 13, ...");

        Console.WriteLine("\nPenjelasan Segitiga Pascal:");
        Console.WriteLine("Segitiga Pascal adalah pola angka yang dihasilkan dengan aturan berikut:");
        Console.WriteLine("1. Angka di baris atas selalu 1.");
        Console.WriteLine("2. Angka di setiap baris selain baris atas adalah hasil penjumlahan");
        Console.WriteLine("   dari dua angka di atasnya di baris sebelumnya.");
        Console.WriteLine("Contoh segitiga Pascal dengan 4 baris:");
        Console.WriteLine("       1");
        Console.WriteLine("      1 1");
        Console.WriteLine("     1 2 1");
        Console.WriteLine("    1 3 3 1");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tampilkan Segitiga Pascal");
            Console.WriteLine("2. Tampilkan Deret Fibonacci");
            Console.WriteLine("3. Penjelasan Deret Fibonacci dan Segitiga Pascal");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan Anda: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Masukkan jumlah baris untuk Segitiga Pascal: ");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    DisplayPascalTriangle(rows);
                    break;
                case 2:
                    Console.Write("Masukkan jumlah bilangan dalam deret Fibonacci: ");
                    int fibCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Deret Fibonacci:");
                    for (int i = 0; i < fibCount; i++)
                    {
                        Console.Write(Fibonacci(i) + " ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    DisplayExplanation();
                    break;
                case 4:
                    Console.WriteLine("Terima kasih telah menggunakan program ini.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    break;
            }
        } while (choice != 4);
    }
}
