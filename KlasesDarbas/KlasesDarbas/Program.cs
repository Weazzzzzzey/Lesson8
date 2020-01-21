using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesDarbas
{
    public struct Mokinys
    {

        private List<int> trimestas1;
        private List<int> trimestas2;
        private List<int> trimestas3;

        public Mokinys(List<int> pirmas,List<int> antras,List<int> trecias)
        {
            this.trimestas1 = pirmas;
            this.trimestas2 = antras;
            this.trimestas3 = trecias;
        }
        
        public double pirmoTrimestoVidurkis()
        {
            return trimestas1.Average();
        }
        public double antroTrimestoVidurkis()
        {
            return trimestas2.Average();
        }
        public double trecioTrimestoVidurkis()
        {
            return trimestas3.Average();
        }

        public double metinisPazimys()
        {
            return (pirmoTrimestoVidurkis() + antroTrimestoVidurkis() + trecioTrimestoVidurkis()) / 3;
        }


    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirmas = new List<int>(); 
            List<int> antras = new List<int>(); 
            List<int> trecias = new List<int>();

            pirmas.Add(10);
            pirmas.Add(10);
            pirmas.Add(10);
            antras.Add(5);
            antras.Add(5);
            antras.Add(5);
            trecias.Add(6);
            trecias.Add(6);
            trecias.Add(6);
            
            Mokinys Tomas = new Mokinys(pirmas,antras,trecias);
            Console.WriteLine(Tomas.pirmoTrimestoVidurkis());
            Console.WriteLine(Tomas.antroTrimestoVidurkis());
            Console.WriteLine(Tomas.trecioTrimestoVidurkis());
            Console.WriteLine(Tomas.metinisPazimys());

            Console.ReadLine();
        
        
        
        }
    }
}
