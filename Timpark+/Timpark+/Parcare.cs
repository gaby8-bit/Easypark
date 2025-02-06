using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timpark_
{
    internal class Parcare
    {
        private int numar;
        private string timp;
       public Parcare(int numar, string timp)
        {
            this.numar = numar;
            this.timp = timp;
        }
        public string Timp
        {
            get { return timp; } 
            set { timp = value; } 
        }
       public int Numar
        {
            get { return numar; }
            set { numar = value; }
        }
        public string afisare_finala()
        {
            if (timp == null)
                return "Locul:" + numar + " " + "este liber";
            else
                return "Locul:" + numar + " " + "este rezervat intre orele:" + timp;
        }
       
    }
}
