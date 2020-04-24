using System;

namespace Tugas4_AplikasiHitungVolumeKeliling3D
{
    class Program
    {
        static void Intro()
        {
            Console.WriteLine("====Selamat datang di Aplikasi Perhitungan Volume dan Keliling Bangun 3D Kelompok 69==== ");
            Console.WriteLine("====Di Aplikasi ini, kamu bisa menghitung Volume dan Keliling dari bangun 3D seperti Balok, Kubus, dan Tabung==== ");
        }

        static void Main(string[] args)
        {
            bool ulang = true;
            string pilihan1, pilihan2;

            Intro();
            while (ulang == true)
            {
                Console.WriteLine(" ----Pilih Bangunan apa yang ingin dihitung---- ");
                Console.WriteLine(" ----Tekan 1 Untuk Bangun Balok---- ");
                Console.WriteLine(" ----Tekan 2 Untuk Bangun Kubus---- ");
                Console.WriteLine(" ----Tekan 3 Untuk Bangun Tabung---- ");
                pilihan1 = Console.ReadLine();

                //BALOK
                if (pilihan1 == "1")
                {
                    Console.WriteLine("Tekan 1 untuk menghitung Volume Balok, Tekan 2 untuk menghitung Keliling Balok");
                    pilihan2 = Console.ReadLine();
                    ClassRumus objek = new ClassRumus();
                    if (pilihan2 == "1")
                    {
                        Console.WriteLine("Masukan Panjang Balok = (Dalam CM) ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukan Lebar Balok = (Dalam CM) ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukan Tinggi Balok = (Dalam CM) ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        objek.volumeBalok(p, l, t);
                        perulangan();
                    }
                    else if (pilihan2 == "2")
                    {
                        Console.WriteLine("Masukkan Panjang Balok = (Dalam CM) ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan Lebar Balok = (Dalam CM) ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan Tinggi Balok = (Dalam CM) ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        objek.kelilingBalok(p, l, t);
                        perulangan();
                    }
                    else Console.WriteLine("Pilihan yang anda tekan salah !");
                }

                //KUBUS
                else if (pilihan1 == "2")
                {
                    Console.WriteLine("Tekan 1 untuk menghitung Volume Kubus, Tekan 2 untuk menghitung Keliling Kubus");
                    pilihan2 = Console.ReadLine();
                    ClassRumus objek = new ClassRumus();
                    if (pilihan2 == "1")
                    {
                        Console.WriteLine("Masukkan Rusuk Kubus = (Dalam CM) ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        objek.volumeKubus(r);
                        perulangan();
                    }
                    else if (pilihan2 == "2")
                    {

                        Console.WriteLine("Masukkan Rusuk Kubus = (Dalam CM) ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        objek.kelilingKubus(r);
                        perulangan();
                    }
                    else Console.WriteLine("Pilihan yang anda tekan salah !");
                }

                //TABUNG
                else if (pilihan1 == "3")
                {
                    Console.WriteLine("Tekan 1 untuk menghitung Volume Tabung, Tekan 2 untuk menghitung Keliling Alas Tabung");
                    pilihan2 = Console.ReadLine();
                    ClassRumus objek = new ClassRumus();
                    if (pilihan2 == "1")
                    {
                        Console.WriteLine("Masukkan Jari-jari Alas Tabung = (Dalam CM) ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan Tinggi Tabung = (Dalam CM)");
                        double t = Convert.ToDouble(Console.ReadLine());
                        objek.volumeTabung(r, t);
                        perulangan();
                    }
                    else if (pilihan2 == "2")
                    {

                        Console.WriteLine("Masukan Jari-jari Alas Tabung = (Dalam CM) ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        objek.kelilingTabung(r);
                        perulangan();
                    }
                    else Console.WriteLine("Pilihan yang anda tekan salah !");
                }

                void perulangan()
                {
                    bool ulang2 = true;
                    while (ulang2 == true)
                    {
                        Console.WriteLine("Apakah anda ingin menghitung lagi dengan aplikasi ini ?, tekan y untuk Ya, n untuk selesai");
                        string yesno;
                        yesno = Console.ReadLine();
                        if (yesno == "y")
                        {
                            ulang = true;
                            ulang2 = false;
                        }
                        else if (yesno == "n")
                        {
                            ulang = false;
                            ulang2 = false;
                        }
                        else Console.WriteLine("Mohon untuk menekan y atau n untuk melanjutkan");
                    }
                }
            }
        }
    }
}
