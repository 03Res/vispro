using System;

class Program
{
    static void Main()
    {
        // Membuat objek Random untuk menghasilkan angka acak
        Random random = new Random();

        // Memilih angka acak antara 1 dan 100
        int targetNumber = random.Next(1, 101);

        int attempts = 0; // Menghitung jumlah percobaan
        bool guessedCorrectly = false; // Menandai apakah pemain telah menebak angka dengan benar
        //jikaa bool true maka kondisi while tidak bisa di eksekusi

        Console.WriteLine("Selamat datang di permainan Tebak Angka!");
        Console.WriteLine("Saya telah memilih angka antara 1 dan 100. Cobalah menebaknya.");

        // Loop while ini akan berjalan sampai pemain menebak angka yang benar
        while (!guessedCorrectly)
        {
            Console.Write("Masukkan tebakan Anda: ");
            string userInput = Console.ReadLine();

            // Mengecek apakah input yang dimasukkan oleh pemain adalah angka
            if (int.TryParse(userInput, out int guess))
            {
                attempts++; // Menambah jumlah percobaan

                if (guess == targetNumber)
                {
                    guessedCorrectly = true; // Pemain menebak angka dengan benar, permainan berakhir
                    Console.WriteLine($"Selamat! Anda menebak angka yang benar, yaitu {targetNumber}.");
                    Console.WriteLine($"Anda membutuhkan {attempts} percobaan.");
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Angka yang Anda tebak terlalu kecil. Coba lagi.");
                }
                else
                {
                    Console.WriteLine("Angka yang Anda tebak terlalu besar. Coba lagi.");
                }
            }
            else
            {
                Console.WriteLine("Masukan tidak valid. Harap masukkan angka yang benar.");
            }
        }

        Console.WriteLine("Terima kasih sudah bermain!");
    }
}
