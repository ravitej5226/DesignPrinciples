using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override string GetDescription()
        {
            return "Dark Roast";
        }

        public override double GetCost()
        {
            return 1.50;
        }
    }
}
