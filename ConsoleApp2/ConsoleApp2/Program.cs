using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class data_diri
    {
        static void Main(string[] args)
        {
            string nama = " quaresma";
            string marga = " soruday";
            string asal = " ambon";
            string falkutas = " ilmu komputer";
            string jurusan = " informatika";
            string gender = " laki-laki";
            string no_regis = " s22110238";
            string hobi = " main games";
            string agama = " kristen(protestan)";
            string email = " s22110238@student.unklab.ac.id";
            string alamat_sekarang = " airmadidi";
            string status_kawin = " belum kawin";
            string NIM = "105022110038" ;
            int semester = 5 ;
            int tinggi_badan = 179 ;
            string cm = "cm";

            Console.WriteLine("nama: {0}", nama);
            Console.WriteLine("marga: {0}", marga);
            Console.WriteLine("asal: {0}", asal);
            Console.WriteLine("falkutas: {0}", falkutas);
            Console.WriteLine("jurusan: {0}", jurusan);
            Console.WriteLine("gender: {0}", gender);
            Console.WriteLine("nomor registrasi: {0}", no_regis);
            Console.WriteLine("hobby: {0}", hobi);
            Console.WriteLine("agama: {0}", agama);
            Console.WriteLine("email student: {0}", email);
            Console.WriteLine("alamata tempat tinggal: {0}", alamat_sekarang);
            Console.WriteLine("status kawin: {0}", status_kawin);
            Console.WriteLine("nomor induk mahasiswwa: {0}", NIM);
            Console.WriteLine("semester sekarang: {0}", semester);
            Console.WriteLine("tinggi badan: {0} {1}", tinggi_badan,cm);

            Console.Read();
        }
    }
}