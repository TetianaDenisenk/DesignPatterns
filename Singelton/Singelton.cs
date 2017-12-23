using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
   public class Singelton
    {
        public Singelton singelton { get; set; }
        private Singelton() { }
        public Singelton GetInstanse() {
            if (singelton == null)
            {
                singelton = new Singelton();
            }
            return singelton;
        }
    }
}
