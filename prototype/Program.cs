using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var prot1 = new ConcratePrototype1(1);
            var protClone = prot1.Clone();
            Console.WriteLine(protClone.Name);

            var prot2 = new ConcratePrototype2(1);
            var protClone2 = prot2.Clone();
            Console.WriteLine(protClone2.Name);
            Console.Read();
        }
    }
}
