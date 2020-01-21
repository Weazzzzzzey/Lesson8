using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saskaitos
{
    struct Saskaita
    {
        private int SasNr;
        private double Viso;

        public Saskaita(int Nr, double Suma)
        {
            this.SasNr = Nr;
            this.Viso = Suma;
        }

        public int getSasNr()
        {
            return SasNr;
        }

        public double getSasSuma()
        {
            return Viso;
        }

        public string BendraInfo()
        {
            string BendraI = $"Saskaitos nr.: {getSasNr()}, Moketina suma: {getSasSuma()}";
            return BendraI;
        }
    }

    public struct Buhalterija
    {
        private int BuhalterineA;
        private List<Saskaita> saskaitos;

        public Buhalterija(int MenesioNr)
        {
            this.BuhalterineA = MenesioNr;
            saskaitos = new List<Saskaita>();
        }

        public void MenesiuSaskaituIpildymas(int Nr, double Suma)
        {
            saskaitos.Add(new Saskaita(Nr,Suma));
        }

        public double getSaskaitosSuma(int i)
        {
            return saskaitos[i].getSasSuma();
        }

        public string getPasirinktaSaskaita(int q)
        {
            for (int i = 0; i < saskaitos.Count(); i++)
            {
                if (saskaitos[i].getSasNr() == q)
                {
                    return saskaitos[i].BendraInfo();
                    break;
                }
            }
            return "Saskaita Nerasta";
            
        }

        public double VisuSaskaituSuma()
        {
            double suma = 0;
            for (int i = 0; i < saskaitos.Count; i++)
            {
                suma = suma + getSaskaitosSuma(i);
            }
            return suma;
        }

        public string SaskaituKiekisIrBendraSuma()
        {
            string ApmokejimoInfo = $"Saskaitu skaicius: {saskaitos.Count()}, Bendra suma si menesi: {VisuSaskaituSuma()}";
            return ApmokejimoInfo;
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Buhalterija b1 = new Buhalterija(1);
            b1.MenesiuSaskaituIpildymas(0001, 10.50);
            b1.MenesiuSaskaituIpildymas(0002, 40.70);
            b1.MenesiuSaskaituIpildymas(0003, 20.50);
            b1.MenesiuSaskaituIpildymas(0004, 29.55);

            Console.WriteLine(b1.getPasirinktaSaskaita(0004));
            Console.WriteLine(b1.SaskaituKiekisIrBendraSuma());
            Console.ReadLine();
        
        }
    }
}
