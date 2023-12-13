using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AbstractClassVeMethods
{
    // abstact class kullanımı;
    abstract class Cihaz
    {
        public string Barkod { get; set; }

        public string BarkodYaz()
        {
            return "Barkod" + this.Barkod;
        }
    }

    class Elektronik : Cihaz 
    { 
      public string RAM { get; set; }
      public string CPU { get; set; }
    }

}
