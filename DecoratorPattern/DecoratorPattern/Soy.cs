using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : BeverageDecorator
    {
        public Soy(Beverage beverage)
            : base(beverage)
        {

        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", this.beverage.GetDescription(), "Soy");
        }

        public override double GetCost()
        {
            return this.beverage.GetCost() + 0.50;
        }
    }
}
