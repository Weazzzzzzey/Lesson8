using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbaiIkiSestadienio
{
    public struct Miskas
    {
        public string MiskoV;
        public List<int> medziai;
        public Miskas(string MiskoVardas)
        {
            this.MiskoV = MiskoVardas;
            medziai = new List<int>();
        }

        public void PasodintiMedi()
        {
            medziai.Add(1);
        }

        public int Medis
        {
            get
            {
                int kiekis = medziai.Count();
                return kiekis;
            }
            private set { }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Miskas m1 = new Miskas("Obeliu MIskas");
            m1.PasodintiMedi();
            m1.PasodintiMedi();
            m1.PasodintiMedi();
            m1.PasodintiMedi();
            Console.WriteLine(m1.Medis);
            Console.ReadLine();
        }
    }
}
