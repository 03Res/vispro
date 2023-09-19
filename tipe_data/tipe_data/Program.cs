using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipe_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan bilangan puluhan: ");
            int num = Convert.ToInt32(Console.ReadLine());

            List<int> digits = new List<int>();

            // Membuat fungsi untuk menambahkan digit-digit bilangan ke dalam list
            void TambahDigit(int number)
            {
                while (number > 0)
                {
                    digits.Add(number % 10);
                    number = number / 10;
                }
            }

            TambahDigit(num);

            // Menampilkan digit-digit yang diinputkan
            Console.Write("Digit-digit yang diinputkan: ");
            for (int i = 0; i < digits.Count; i++)
            {
                Console.Write(digits[i]);
                if (i != digits.Count - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();

            // Menghitung pertambahan dari masing-masing digit
            int total = 0;
            for (int i = 0; i < digits.Count; i++)
            {
                total += digits[i];
            }

            Console.WriteLine("Hasil pertambahan: " + total);

            //const Double PI= 3.14;
            //String jari_jari;
            //Double konversi, Luas, Keliling;
            //Console Write("masukan jari jari:");
            //jari_jari = Console.ReadLine();
            //konversi= Convert.ToDouble(jari_jari);
            //Luas = PI * konversi * konversi;
            //Keliling = 2 * PI * konversi;
            //Console.WriteLine("luas lingkaran= {0}", Luas);
            //Console.WriteLine("keliling lingkaran = {0}", Keliling);
            //Console.ReadLine();

            //const int nilai= 15;
            //string angka;
            //int tambah= 10;
            //Console.WriteLine("masukan nilai");
            //angka= Console.ReadLine();
            //hitung = angka + tambah;


            //Console.WriteLine(angka, hitung, "+ 15 =");
            //Console.ReadLine();
        }
    }
}


            