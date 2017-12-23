using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class SalatRecepy : AbstractBuilder
    {
        List<string> products = new List<string>();

        public override void BuildA()
        {
            products.Add("Kapusta");
        }

        public override void BuildB()
        {
            products.Add("Smetana");
        }

        public override void BuildC()
        {
            products.Add("Ogirki");
        }

        public override product ReturnDish()
        {
            return new product() { products = this.products };
        }
    }
}
