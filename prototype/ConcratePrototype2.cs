using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class ConcratePrototype2 : Prototype
    {
        public ConcratePrototype2(int id) : base(id)
        {
            Name = "ConcratePrototype2";
        }

        public override Prototype Clone()
        {
            return new ConcratePrototype2(id);
        }
    }
}
