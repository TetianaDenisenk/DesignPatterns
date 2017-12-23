using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TortRecepy : AbstractBuilder
    {
        List<string> products = new List<string>();
        public override void BuildA()
        {
            products.Add("Korz");
        }

        public override void BuildB()
        {
            products.Add("Krem");
        }

        public override void BuildC()
        {
            products.Add("Fructy");
        }
        public override product ReturnDish()
        {
            return new product() { products = this.products };
        }
    }
}
