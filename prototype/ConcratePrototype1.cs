using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class ConcratePrototype1 : Prototype
    {
        public ConcratePrototype1(int id) : base(id)
        {
            Name = "ConcratePrototype1";
        }

        public override Prototype Clone()
        {
            return new ConcratePrototype1(id);
        }
        
    }
}
