using System;

class Malware
{
    private string Nama { get; set; }
    private string Jenis { get; set; }
    private int Size { get; set; }
    private string Fungsi { get; set; }

    public Malware(string nama, string jenis, int size, string fungsi)
    {
        this.Nama = nama;
        this.Jenis = jenis;
        this.Size = size;
        this.Fungsi = fungsi;
    }

    public void DisplayMalwareInfo()
    {
        Console.WriteLine("Nama malware berikut ini adalah " + this.Nama);
        Console.WriteLine("malware " + this.Nama + " termasuk jenis " + this.Jenis);
        Console.WriteLine("malware " + this.Nama + " berkapasitas " + this.Size + " MB");
        Console.WriteLine("kemampuan " + this.Nama + " adalah " + this.Fungsi);
    }
}

class Program
{
    static void Main()
    {
        // Membuat objek malware "backdoorWin32.exe"
        Malware malware = new Malware("backdoorWin32.exe", "trojan", 14, "shut down setiap 30 menit");
        malware.DisplayMalwareInfo();

        Console.ReadLine();
    }
}
