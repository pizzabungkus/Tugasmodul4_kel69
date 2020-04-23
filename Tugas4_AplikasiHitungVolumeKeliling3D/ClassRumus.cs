using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas4_AplikasiHitungVolumeKeliling3D
{
    class ClassRumus
    {
        public double volumeBalok(double a, double b, double c)
        {          
            double d = a * b * c;
            Console.WriteLine("Volume Balok = " + d + " cm^3");
            return d;
        }
        public double kelilingBalok(double a, double b, double c)
        {
            double d = 4*(a+b+c);
            Console.WriteLine("Keliling Balok = " + d + " cm");
            return d;
        }
        public double volumeKubus(double a)
        {
            double d = a * a * a; 
            Console.WriteLine("Volume Kubus = " + d + " cm^3");
            return d;
        }
        public double kelilingKubus(double a)
        {
            double d = 12 * a;
            Console.WriteLine("Keliling Kubus = " + d + " cm");
            return d;
        }
       
    }
}
