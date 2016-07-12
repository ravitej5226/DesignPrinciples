using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription()
        {
            return "House Blend";
        }

        public override double GetCost()
        {
            return 1.20;
        }
    }
}
