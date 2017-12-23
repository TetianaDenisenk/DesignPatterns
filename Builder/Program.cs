using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var recept = new SalatRecepy();
            var ektor = new Kuxar(recept);
            ektor.Cook();
            ektor.ShowMeDish();
            Console.Read();
        }
    }
}
