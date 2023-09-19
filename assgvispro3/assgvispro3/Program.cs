using System;

class Program
{
    static void Main()
    {
        bool continueCalculations = true;

        while (continueCalculations)
        {
            //display teks 
            Console.WriteLine("Masukkan dua bilangan puluhan:");

            //minta input bilangan satu
            Console.Write("Bilangan pertama: ");
            int bilangan1 = Convert.ToInt32(Console.ReadLine());

            //minta input bilangan kedua
            Console.Write("Bilangan kedua: ");
            int bilangan2 = Convert.ToInt32(Console.ReadLine());

            //proses perhitungan
            double tambah = bilangan1 + bilangan2;
            double kurang = bilangan1 - bilangan2;
            double kali = bilangan1 * bilangan2;
            double bagi = bilangan1 != 0 ? (double)bilangan1 / bilangan2 : 0; // Mencegah pembagian dengan nol

            //display hasil perhitungan
            Console.WriteLine("C Hasil penambahan bilangan a + b: " + tambah);
            Console.WriteLine("D Hasil pengurangan bilangan a - b: " + kurang);
            Console.WriteLine("E Hasil perkalian bilangan a * b: " + kali);
            Console.WriteLine("F Hasil pembagian bilangan a != b: " + bagi);

            //true false
            bool tambahkurangkali = tambah < kali;
            bool tambahbesarKali = tambah > kali;
            bool kurangkurangsamabagi = kurang < bagi;
            bool kuranglebihsamabagi = kurang >= bagi;
            bool tambahsamakali = tambah == kali;
            bool kurangtaksamabagi = kurang != bagi;

            //display true false
            Console.WriteLine("Hasil c < e: " + tambahkurangkali);
            Console.WriteLine("Hasil c > e: " + tambahbesarKali);
            Console.WriteLine("Hasil d < f: " + kurangkurangsamabagi);
            Console.WriteLine("Hasil d >= f: " + kuranglebihsamabagi);
            Console.WriteLine("Hasil c = e: " + tambahsamakali);
            Console.WriteLine("Hasil d != f: " + kurangtaksamabagi);

            //minta lanjutkan perhitungan?
            Console.WriteLine("Lanjutkan perhitungan? (ya/tidak)");
            string lanjutkan = Console.ReadLine();

            if (lanjutkan.ToLower() != "ya")
            {
                continueCalculations = false;
            }
        }
    }
}
