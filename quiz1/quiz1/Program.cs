class Tabung
{
    public double JariJari { get; set; } // Property untuk jari-jari tabung=di encapsulate
    public double Tinggi { get; set; }   // Property untuk tinggi tabung=di encapsulate

    public double HitungLuasAlas()      // Method untuk menghitung luas alas tabung = askes spesifier public
    { return Math.PI * JariJari * JariJari; // Menggunakan rumus luas lingkaran (π * r^2) = akses spesifier public
    }
    public double HitungVolume()         // Method untuk menghitung volume tabung
    { return HitungLuasAlas() * Tinggi; // Menggunakan luas alas * tinggi
    }
}

class Program
{
    //class tabung
    static void Main()
    {   
        Tabung tabung = new Tabung(); // bikin objek Tabung


        Console.Write("Masukkan jari-jari tabung: ");
        tabung.JariJari = double.Parse(Console.ReadLine()); // minta input jari-jari
        Console.Write("Masukkan tinggi tabung: ");
        tabung.Tinggi = double.Parse(Console.ReadLine());   // minta input tinggi

        //output
        Console.WriteLine($"Luas alas tabung: {tabung.HitungLuasAlas():0.##}"); // kase tampil  output luas alas dengan 2 desimal
        Console.WriteLine($"Volume tabung: {tabung.HitungVolume():0.##}");     // kse tampil output volume dengan 2 desimal
    }
}
