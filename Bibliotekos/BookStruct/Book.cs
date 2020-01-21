using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStruct
{
    public struct Book
    {
        private string _Name;
        private string _ID;


        public string Name {
            get { return _Name; }
            set { _Name = value; } 
        }

        public string ID { 
            get { return _ID; } 
            set {
                if (value != "")
                {
                    _ID = value;
                }
                else
                {
                    _ID = "1000";
                }
            } 
        }

        public string LocalID {
            get { return _Name + "_" + _ID; }
            private set { } 
        }

    }
}
