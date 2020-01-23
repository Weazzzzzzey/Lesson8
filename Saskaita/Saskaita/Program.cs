using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saskaita
{

    struct Saskaitele
    {
        private string _gavejas;
        private string _siuntejas;
        private double _moketiViso;
        private string _saskNr;

        public Saskaitele(string gavejas,string siuntejas,double suma)
        {
            this._gavejas = gavejas;
            this._siuntejas = siuntejas;
            this._moketiViso = suma;
            this._saskNr = DateTime.Now.ToString("NR_yyyy_MM_dd_01");
            SaskaitosInfoPrint();
        }

        public string Gavejas {
            get { return _gavejas; }
            private set { }
        }

        public string Siuntejas
        {
            get { return _siuntejas; }
            private set { }
        }

        public double Moketi
        {
            get { return _moketiViso; }
            private set { }
        }

        public string SaskaitosNumeris
        {
            get { return _saskNr; }
            set { }
        }
        public void SaskaitosInfoPrint()
        {
            Console.WriteLine("Saskaitos gavejas: {0} ",Gavejas);
            Console.WriteLine("Saskaitos siuntejas: {0} ", Siuntejas);
            Console.WriteLine("Saskaitos suma: {0}€", Moketi);
            Console.WriteLine("Saskaitos numeris: {0}",SaskaitosNumeris);
            Console.ReadLine();
        }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Saskaitele s1 = new Saskaitele("UAB G","UAB S",20.43);
        }
    }
}
