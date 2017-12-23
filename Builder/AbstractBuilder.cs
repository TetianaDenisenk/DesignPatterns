using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
 public abstract class  AbstractBuilder
    {
        public abstract void BuildA();
        public abstract void BuildB();
        public abstract void BuildC();
        public abstract product ReturnDish();
    }
}
