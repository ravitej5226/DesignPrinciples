using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class BeverageDecorator : Beverage
    {
        public Beverage beverage;

        public BeverageDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
