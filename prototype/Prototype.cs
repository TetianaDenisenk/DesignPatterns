using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
  public abstract class Prototype
    {
        public string Name { get; set; }
        public int id { get; set; }
        public Prototype(int id)
        {
            this.id = id;
        }
        public abstract Prototype Clone();
    }
}
