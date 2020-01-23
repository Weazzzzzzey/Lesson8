using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmeND
{
    public struct Palme
    {

        private int _amzius;
        private int _vaisiuK;

        public Palme(int amzius, int kiekis)
        {
            this._amzius = amzius;
            this._vaisiuK = kiekis;
        }

        public int Amzius
        {
            get { return _amzius; }
            private set { }
        }

        public int Vaisiai
        {
            get { return _vaisiuK; }
            private set { }
        }

        public int PridetiVienaMenesiAmziaus()
        {
            if (Amzius == 12) { _amzius = 0; _vaisiuK = 0; } else _amzius++;
            VaisiuKiekis();
            return Amzius;
        }

        public void VaisiuKiekis()
        {
            if (Amzius >= 5)
            {
                _vaisiuK = 3 * _amzius;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
