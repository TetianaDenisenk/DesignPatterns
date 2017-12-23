using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Kuxar
    {
        AbstractBuilder builder;
       public Kuxar(AbstractBuilder builder)
        {
            this.builder = builder;

        }
        public product Cook()
        {
            builder.BuildA();
            builder.BuildB();
            builder.BuildC();
            return builder.ReturnDish();
        }
        public void ShowMeDish()
        {
            foreach (var item in builder.ReturnDish().products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
